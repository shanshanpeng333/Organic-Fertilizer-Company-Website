using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FourthDimensionOEC.Models;
using Microsoft.AspNetCore.Http;

namespace FDOEC.Controllers
{
    public class FDVarietyController : Controller
    {
        private readonly OECContext _context;

        public string VARIETYERRORMSG { get; private set; }

        public FDVarietyController(OECContext context)
        {
            _context = context;
        }

        // GET: FDVariety
       /* public async Task<IActionResult> Index()
        {
            var oECContext = _context.Variety.OrderBy(v => v.Name);
            return View(await oECContext.ToListAsync());
        }*/

        // GET: FDVariety
        public async Task<IActionResult> Index(int? id)
        {
            if (id != null)
            {
                HttpContext.Session.SetString("SessVarCropId", id.ToString());
            }
            else
            {
                id = Convert.ToInt32(HttpContext.Session.GetString("SessVarCropId"));
                if (id == 0)
                {
                    //return to View and Display Message if BusRouteCode is null
                    TempData["message"] = "Please select a crop...";
                    return RedirectToAction("Index", "FDCrop");
                    //var oECContextAll = _context.Variety.OrderBy(v => v.Name);
                    //return View(await oECContextAll.ToListAsync());
                }
            }

            var oECContext = _context.Variety.Include(v => v.Crop)
                .OrderBy(v => v.Name)
                .Where(v => v.CropId == id);

            if (oECContext == null)
            {
                return NotFound();
            }
            return View(await oECContext.ToListAsync());

        }

            // GET: FDVariety/Details/5
            public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var variety = await _context.Variety
                .Include(v => v.Crop)
                .FirstOrDefaultAsync(m => m.VarietyId == id);
            if (variety == null)
            {
                return NotFound();
            }

            return View(variety);
        }

        // GET: FDVariety/Create
        /*public IActionResult Create()
        {
            ViewData["CropId"] = new SelectList(_context.Crop, "CropId", "CropId");
            return View();
        }*/

        // GET: FDVariety/Create
        public IActionResult Create()
        {
            var id = Convert.ToInt32(HttpContext.Session.GetString("SessVarCropId"));
            if (id <= 0)
            {
                ViewData["CropId"] = new SelectList(_context.Crop, "CropId", "CropId");
                return View();
            }
            else
            {
                ViewData["CropId"] = new SelectList(_context.Crop, "CropId", "CropId", id);
                return View();
            }

        }

        // POST: FDVariety/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("VarietyId,CropId,Name")] Variety variety)
        {
            if (ModelState.IsValid)
            {
                _context.Add(variety);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CropId"] = new SelectList(_context.Crop, "CropId", "CropId", variety.CropId);
            return View(variety);
        }

        // GET: FDVariety/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var variety = await _context.Variety.FindAsync(id);
            if (variety == null)
            {
                return NotFound();
            }
            ViewData["CropId"] = new SelectList(_context.Crop, "CropId", "CropId", variety.CropId);
            return View(variety);
        }

        // POST: FDVariety/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("VarietyId,CropId,Name")] Variety variety)
        {
            if (id != variety.VarietyId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(variety);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VarietyExists(variety.VarietyId))
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
            ViewData["CropId"] = new SelectList(_context.Crop, "CropId", "CropId", variety.CropId);
            return View(variety);
        }

        // GET: FDVariety/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var variety = await _context.Variety
                .Include(v => v.Crop)
                .FirstOrDefaultAsync(m => m.VarietyId == id);
            if (variety == null)
            {
                return NotFound();
            }

            return View(variety);
        }

        // POST: FDVariety/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var variety = await _context.Variety.FindAsync(id);
            _context.Variety.Remove(variety);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VarietyExists(int id)
        {
            return _context.Variety.Any(e => e.VarietyId == id);
        }
    }
}
