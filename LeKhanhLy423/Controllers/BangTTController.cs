using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DemoMvc.Data;
using LeKhanhLy423.Models;

namespace LeKhanhLy423.Controllers
{
    public class BangTTController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BangTTController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: BangTT
        public async Task<IActionResult> Index()
        {
            return View(await _context.BangTT.ToListAsync());
        }

        // GET: BangTT/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bangTT = await _context.BangTT
                .FirstOrDefaultAsync(m => m.ID == id);
            if (bangTT == null)
            {
                return NotFound();
            }

            return View(bangTT);
        }

        // GET: BangTT/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: BangTT/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Fullname,Tuoi,Address")] BangTT bangTT)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bangTT);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(bangTT);
        }

        // GET: BangTT/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bangTT = await _context.BangTT.FindAsync(id);
            if (bangTT == null)
            {
                return NotFound();
            }
            return View(bangTT);
        }

        // POST: BangTT/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Fullname,Tuoi,Address")] BangTT bangTT)
        {
            if (id != bangTT.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bangTT);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BangTTExists(bangTT.ID))
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
            return View(bangTT);
        }

        // GET: BangTT/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bangTT = await _context.BangTT
                .FirstOrDefaultAsync(m => m.ID == id);
            if (bangTT == null)
            {
                return NotFound();
            }

            return View(bangTT);
        }

        // POST: BangTT/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var bangTT = await _context.BangTT.FindAsync(id);
            if (bangTT != null)
            {
                _context.BangTT.Remove(bangTT);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BangTTExists(int id)
        {
            return _context.BangTT.Any(e => e.ID == id);
        }
    }
}
