using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FourthDimensionOEC.Models;

namespace FourthDimensionOEC.Controllers
{
    public class FDCropController : Controller
    {
        private readonly OECContext _context;

        public FDCropController(OECContext context)
        {
            _context = context;
        }

        // GET: FDCrop
        public async Task<IActionResult> Index()
        {
            var crop = _context.Crop.OrderBy(c => c.Name);
            return View(await crop.ToListAsync());       
        }

        // GET: FDCrop/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var crop = await _context.Crop
                .FirstOrDefaultAsync(m => m.CropId == id);
            if (crop == null)
            {
                return NotFound();
            }

            return View(crop);
        }

        // GET: FDCrop/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: FDCrop/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CropId,Name,Image")] Crop crop)
        {
            if (ModelState.IsValid)
            {
                _context.Add(crop);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(crop);
        }

        // GET: FDCrop/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var crop = await _context.Crop.FindAsync(id);
            if (crop == null)
            {
                return NotFound();
            }
            return View(crop);
        }

        // POST: FDCrop/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CropId,Name,Image")] Crop crop)
        {
            if (id != crop.CropId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(crop);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CropExists(crop.CropId))
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
            return View(crop);
        }

        // GET: FDCrop/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var crop = await _context.Crop
                .FirstOrDefaultAsync(m => m.CropId == id);
            if (crop == null)
            {
                return NotFound();
            }

            return View(crop);
        }

        // POST: FDCrop/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var crop = await _context.Crop.FindAsync(id);
            _context.Crop.Remove(crop);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CropExists(int id)
        {
            return _context.Crop.Any(e => e.CropId == id);
        }
    }
}
