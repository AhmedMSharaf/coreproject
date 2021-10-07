using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using coreproject.Models;
using Microsoft.AspNetCore.Hosting;
using System.IO;

namespace coreproject.Controllers
{
    [Area("AdminPanel")]
    public class TeammemmbersController : Controller
    {
        private readonly NewContext _context;
        private IWebHostEnvironment host;
        public TeammemmbersController(NewContext context,IWebHostEnvironment _host)
        {
            _context = context;
            host = _host;
        }
        void uploadphoto(Teammemmber model)
        {
            if(model.File !=null)
            {
                string uploadfile = Path.Combine(host.WebRootPath, "images/Team");
                string uniqname=Guid.NewGuid()+".jpg";
                string filepath = Path.Combine(uploadfile, uniqname);
                using (var filestream = new FileStream(filepath, FileMode.Create))
                {
                    model.File.CopyTo(filestream);
                }
                model.Image = uniqname;
            }
        }
        // GET: Teammemmbers
        public async Task<IActionResult> Index()
        {
            return View(await _context.Teammemmbers.ToListAsync());
        }

        // GET: Teammemmbers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var teammemmber = await _context.Teammemmbers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (teammemmber == null)
            {
                return NotFound();
            }

            return View(teammemmber);
        }

        // GET: Teammemmbers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Teammemmbers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create( Teammemmber teammemmber)
        {
            if (ModelState.IsValid)
            {
                uploadphoto(teammemmber);
                _context.Add(teammemmber);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(teammemmber);
        }

        // GET: Teammemmbers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var teammemmber = await _context.Teammemmbers.FindAsync(id);
            if (teammemmber == null)
            {
                return NotFound();
            }
            return View(teammemmber);
        }

        // POST: Teammemmbers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id,Teammemmber teammemmber)
        {
            if (id != teammemmber.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    uploadphoto(teammemmber);
                    _context.Update(teammemmber);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TeammemmberExists(teammemmber.Id))
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
            return View(teammemmber);
        }

        // GET: Teammemmbers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var teammemmber = await _context.Teammemmbers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (teammemmber == null)
            {
                return NotFound();
            }

            return View(teammemmber);
        }

        // POST: Teammemmbers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var teammemmber = await _context.Teammemmbers.FindAsync(id);
            _context.Teammemmbers.Remove(teammemmber);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TeammemmberExists(int id)
        {
            return _context.Teammemmbers.Any(e => e.Id == id);
        }
    }
}
