using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SIMS_Project.Data;
using SIMS_Project.Models;

public abstract class BaseController<T> : Controller where T : class
{
    protected readonly ApplicationDbContext _context;

    public BaseController(ApplicationDbContext context)
    {
        _context = context;
    }

    // Index: Displays all items of type T
    protected async Task<IActionResult> IndexBaseAsync()
    {
        var items = await _context.Set<T>().ToListAsync();
        return View(items);
    }

    // Details: Displays details of an item of type T
    protected async Task<IActionResult> DetailsBaseAsync(int id)
    {
        var item = await _context.Set<T>().FindAsync(id);
        if (item == null) return NotFound();
        return View(item);
    }

    // Create: Adds a new item of type T to the database
    protected async Task<IActionResult> CreateBaseAsync(T entity)
    {
        try
        {
            if (!ModelState.IsValid)
            {
                await _context.Set<T>().AddAsync(entity);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
        }
        catch (Exception ex)
        {
            ModelState.AddModelError("", $"Error: {ex.Message}");
        }
        return View(entity);
    }

    // Edit: Edits an existing item of type T in the database
    protected async Task<IActionResult> EditBaseAsync(int id, T entity)
    {
        try
        {
            if (id != (int)entity.GetType().GetProperty("ID").GetValue(entity, null))
            {
                return BadRequest();  // Ensure the IDs match
            }

            if (!ModelState.IsValid)
            {
                _context.Set<T>().Update(entity);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
        }
        catch (Exception ex)
        {
            ModelState.AddModelError("", $"Error: {ex.Message}");
        }
        return View(entity);
    }

    // Delete: Removes an item of type T from the database
    protected async Task<IActionResult> DeleteBaseAsync(int id)
    {
        var item = await _context.Set<T>().FindAsync(id);
        if (item == null) return NotFound();

        _context.Set<T>().Remove(item);
        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }
}
