using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using coreproject.Models;

namespace coreproject.Controllers
{
    [Area("AdminPanel")]
    public class CategroysController : Controller
    {
        private readonly NewContext _context;

        public CategroysController(NewContext context)
        {
            _context = context;
        }

        // GET: Categroys
        public async Task<IActionResult> Index()
        {
            return View(await _context.Categroys.ToListAsync());
        }

        // GET: Categroys/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var categroy = await _context.Categroys
                .FirstOrDefaultAsync(m => m.Id == id);
            if (categroy == null)
            {
                return NotFound();
            }

            return View(categroy);
        }

        // GET: Categroys/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Categroys/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Description")] Categroy categroy)
        {
            if (ModelState.IsValid)
            {
                _context.Add(categroy);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(categroy);
        }

        // GET: Categroys/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var categroy = await _context.Categroys.FindAsync(id);
            if (categroy == null)
            {
                return NotFound();
            }
            return View(categroy);
        }

        // POST: Categroys/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Description")] Categroy categroy)
        {
            if (id != categroy.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(categroy);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CategroyExists(categroy.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(categroy);
        }

        // GET: Categroys/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var categroy = await _context.Categroys
                .FirstOrDefaultAsync(m => m.Id == id);
            if (categroy == null)
            {
                return NotFound();
            }

            return View(categroy);
        }

        // POST: Categroys/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var categroy = await _context.Categroys.FindAsync(id);
            _context.Categroys.Remove(categroy);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CategroyExists(int id)
        {
            return _context.Categroys.Any(e => e.Id == id);
        }
    }
}
