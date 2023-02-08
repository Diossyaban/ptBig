using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PTBIG.Data;
using PTBIG.Models;

namespace PTBIG.Controllers
{
    public class AnakKelas11Controller : Controller
    {
        private readonly PTBIGContext _context;

        public AnakKelas11Controller(PTBIGContext context)
        {
            _context = context;
        }

        // GET: AnakKelas11
        public async Task<IActionResult> Index()
        {
            return View(await _context.AnakKelas11s.ToListAsync());
        }
        
        // GET: AnakKelas11/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var anakKelas11 = await _context.AnakKelas11s
                .FirstOrDefaultAsync(m => m.ID == id);
            if (anakKelas11 == null)
            {
                return NotFound();
            }

            return View(anakKelas11);
        }

        // GET: AnakKelas11/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AnakKelas11/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Nama,Kelas,Umur,Tinggi,Berat")] AnakKelas11 anakKelas11)
        {
            if (ModelState.IsValid)
            {
                _context.Add(anakKelas11);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(anakKelas11);
        }

        // GET: AnakKelas11/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var anakKelas11 = await _context.AnakKelas11s.FindAsync(id);
            if (anakKelas11 == null)
            {
                return NotFound();
            }
            return View(anakKelas11);
        }

        // POST: AnakKelas11/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Nama,Kelas,Umur,Tinggi,Berat")] AnakKelas11 anakKelas11)
        {
            if (id != anakKelas11.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(anakKelas11);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AnakKelas11Exists(anakKelas11.ID))
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
            return View(anakKelas11);
        }

        // GET: AnakKelas11/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var anakKelas11 = await _context.AnakKelas11s
                .FirstOrDefaultAsync(m => m.ID == id);
            if (anakKelas11 == null)
            {
                return NotFound();
            }

            return View(anakKelas11);
        }

        // POST: AnakKelas11/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var anakKelas11 = await _context.AnakKelas11s.FindAsync(id);
            _context.AnakKelas11s.Remove(anakKelas11);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AnakKelas11Exists(int id)
        {
            return _context.AnakKelas11s.Any(e => e.ID == id);
        }

        /*public async Task<IActionResult> DataData(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var anakKelas11 = (await _context.AnakKelas11s.ToListAsync());
            if (anakKelas11 == null)
            {
                return NotFound();
            }

            return View(anakKelas11);
        }*/
        /*public async Task<IActionResult> List()
        {
            return View(await _context.AnakKelas11s.ToListAsync());
        }*/
    }
}