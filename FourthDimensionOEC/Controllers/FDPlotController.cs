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
    public class FDPlotController : Controller
    {
        private readonly OECContext _context;

        public FDPlotController(OECContext context)
        {
            _context = context;
        }

        // GET: FDPlot
        /*public async Task<IActionResult> Index(int? id)
        {
            TempData["message"] = $"id is {id}";
            var oECContext = _context.Plot.Include(p => p.Farm)
                .Include(p => p.Variety)
                .ThenInclude(p => p.Crop)
                .Include(p => p.Treatment)
                .OrderByDescending(p=>p.DatePlanted)
            return View(await oECContext.ToListAsync());
        }*/

        // GET: FDPlot
        public async Task<IActionResult> Index(int? id, string type="")
        {
            
            if(type == "crop")
            {
                //HttpContext.Session.SetString("SessPlotId", id.ToString());
                HttpContext.Session.SetString("SessVarCropId", id.ToString());
                HttpContext.Session.SetString("SessPlotName", type);
                var oECContext = _context.Plot.Include(p => p.Variety).ThenInclude(p => p.Crop)
                    .Include(p => p.Farm)
                    .Include(p => p.Treatment)
                    .OrderByDescending(p => p.DatePlanted)
                    .Where(p => p.Variety.CropId == id);

                return View(await oECContext.ToListAsync());
            }
            else if(type == "variety")
            {
                //HttpContext.Session.SetString("SessPlotId", id.ToString());
                HttpContext.Session.SetString("SessVarVarId", id.ToString());
                HttpContext.Session.SetString("SessPlotName", type);
                var tempcropid = Convert.ToInt32(HttpContext.Session.GetString("SessVarCropId"));
                var oECContext = _context.Plot.Include(p => p.Variety)
                    .Include(p => p.Farm)
                    .Include(p => p.Treatment)
                    .OrderByDescending(p => p.DatePlanted)
                    .Where(p => p.VarietyId == id && p.Variety.CropId == tempcropid);

                return View(await oECContext.ToListAsync());
            }
            else 
            {
                //id = Convert.ToInt32(HttpContext.Session.GetString("SessId"));
                type = HttpContext.Session.GetString("SessPlotName");
                if (type == "crop")
                {
                    id = Convert.ToInt32(HttpContext.Session.GetString("SessVarCropId"));
                    var oECContext = _context.Plot.Include(p => p.Variety).ThenInclude(p => p.Crop)
                    .Include(p => p.Farm)
                    .Include(p => p.Treatment)
                    .OrderByDescending(p => p.DatePlanted)
                    .Where(p => p.Variety.CropId == id);

                    return View(await oECContext.ToListAsync());
                }
                else if(type=="variety")
                {
                    id = Convert.ToInt32(HttpContext.Session.GetString("SessVarVarId"));
                    var tempcropid= Convert.ToInt32(HttpContext.Session.GetString("SessVarCropId"));
                    var oECContext = _context.Plot.Include(p => p.Variety).ThenInclude(p => p.Crop)
                    .Include(p => p.Farm)
                    .Include(p => p.Treatment)
                    .OrderByDescending(p => p.DatePlanted)
                    .Where(p => p.Variety.VarietyId == id && p.Variety.CropId == tempcropid);

                    return View(await oECContext.ToListAsync());
                }
                else 
                {
                    var oECContext = _context.Plot.Include(p => p.Farm)
                        .Include(p => p.Variety)
                        .ThenInclude(p => p.Crop)
                        .Include(p => p.Treatment)
                        .OrderByDescending(p => p.DatePlanted);
                    return View(await oECContext.ToListAsync());
                }

            }
            //var oECContext1 = _context.Plot.Include(p => p.Farm).Include(p => p.Variety.Crop).Include(p => p.Variety).Include(p => p.Treatment).OrderByDescending(p => p.DatePlanted);
            //return View(await oECContext1.ToListAsync());
        }
        

        // GET: FDPlot/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var plot = await _context.Plot
                .Include(p => p.Farm)
                .Include(p => p.Variety)
                .ThenInclude(p=>p.Crop)
                .OrderByDescending(p => p.DatePlanted)
                .FirstOrDefaultAsync(m => m.PlotId == id);
            if (plot == null)
            {
                return NotFound();
            }

            return View(plot);
        }

        // GET: FDPlot/Create
        public IActionResult Create()
        {
            
            //ViewData["FarmId"] = new SelectList(_context.Farm, "FarmId", "ProvinceCode");
            //ViewData["VarietyId"] = new SelectList(_context.Variety, "VarietyId", "VarietyId");
            int tempcropid = Convert.ToInt32(HttpContext.Session.GetString("SessVarCropId"));
            int tempvarid = Convert.ToInt32(HttpContext.Session.GetString("SessVarVarId"));

            var farmContext = _context.Farm.OrderBy(f => f.Name);
            if(tempcropid > 0)
            {
                var varietyContext = _context.Variety
                    .Include(v => v.Crop)
                    .Where(v=>v.Crop.CropId==tempcropid)
                    .OrderBy(v => v.Name);
                ViewData["VarietyId"] = new SelectList(varietyContext, "VarietyId", "Name", tempvarid.ToString());
                /*if(tempvarid > 0)
                {
                    varietyContext = _context.Variety
                    .Include(v => v.Crop)
                    .Where(v => v.VarietyId == tempvarid)
                    .OrderBy(v => v.Name);
                    ViewData["VarietyId"] = new SelectList(varietyContext, "VarietyId", "Name"); 
                }*/
            }
            else
            {
                var varietyContext = _context.Variety
                    .Include(v => v.Crop)
                    .OrderBy(v => v.Name);
                ViewData["VarietyId"] = new SelectList(varietyContext, "VarietyId", "Name");
            }
            ViewData["FarmId"] = new SelectList(farmContext, "FarmId", "Name");
            return View();
        }

        // POST: FDPlot/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PlotId,FarmId,VarietyId,DatePlanted,DateHarvested,PlantingRate,PlantingRateByPounds,RowWidth,PatternRepeats,OrganicMatter,BicarbP,Potassium,Magnesium,Calcium,PHsoil,PHbuffer,Cec,PercentBaseSaturationK,PercentBaseSaturationMg,PercentBaseSaturationCa,PercentBaseSaturationH,Comments")] Plot plot)
        {
            if (ModelState.IsValid)
            {
                _context.Add(plot);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
           // var farmContext = _context.Farm.OrderBy(f => f.Name);
            //var varietyContext = _context.Variety.OrderBy(v => v.Name);

           // ViewData["FarmId"] = new SelectList(farmContext, "FarmId", "Name", plot.FarmId);
           // ViewData["VarietyId"] = new SelectList(varietyContext, "VarietyId", "Name", plot.VarietyId);
            return View(plot);
        }

        // GET: FDPlot/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var plot = await _context.Plot.FindAsync(id);
            if (plot == null)
            {
                return NotFound();
            }
            var farmContext = _context.Farm.OrderBy(f => f.Name);
            var varietyContext = _context.Variety.OrderBy(v => v.Name);

            ViewData["FarmId"] = new SelectList(farmContext, "FarmId", "Name", plot.FarmId);
            ViewData["VarietyId"] = new SelectList(varietyContext, "VarietyId", "Name", plot.VarietyId);
            return View(plot);
        }

        // POST: FDPlot/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PlotId,FarmId,VarietyId,DatePlanted,DateHarvested,PlantingRate,PlantingRateByPounds,RowWidth,PatternRepeats,OrganicMatter,BicarbP,Potassium,Magnesium,Calcium,PHsoil,PHbuffer,Cec,PercentBaseSaturationK,PercentBaseSaturationMg,PercentBaseSaturationCa,PercentBaseSaturationH,Comments")] Plot plot)
        {
            if (id != plot.PlotId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(plot);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PlotExists(plot.PlotId))
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
            var farmContext = _context.Farm.OrderBy(f => f.Name);
            var varietyContext = _context.Variety.OrderBy(v => v.Name);

            ViewData["FarmId"] = new SelectList(farmContext, "FarmId", "Name", plot.FarmId);
            ViewData["VarietyId"] = new SelectList(varietyContext, "VarietyId", "Name", plot.VarietyId);
            return View(plot);
        }

        // GET: FDPlot/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var plot = await _context.Plot
                .Include(p => p.Farm)
                .Include(p => p.Variety)
                .FirstOrDefaultAsync(m => m.PlotId == id);
            if (plot == null)
            {
                return NotFound();
            }

            return View(plot);
        }

        // POST: FDPlot/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var plot = await _context.Plot.FindAsync(id);
            _context.Plot.Remove(plot);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PlotExists(int id)
        {
            return _context.Plot.Any(e => e.PlotId == id);
        }
    }
}
