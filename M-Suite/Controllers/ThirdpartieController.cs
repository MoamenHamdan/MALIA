using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using M_Suite.Context;
using M_Suite.Models;

namespace M_Suite.Controllers
{
    public class ThirdpartieController : Controller
    {
        private readonly MaliaContext _context;

        public ThirdpartieController(MaliaContext context)
        {
            _context = context;
        }

        // GET: Thirdpartie
        public async Task<IActionResult> Index()
        {
            return View(await _context.Thirdparties.ToListAsync());
        }

        // GET: Thirdpartie/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var thirdparty = await _context.Thirdparties
                .FirstOrDefaultAsync(m => m.ThpId == id);
            if (thirdparty == null)
            {
                return NotFound();
            }

            return View(thirdparty);
        }

        // GET: Thirdpartie/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Thirdpartie/Create
   
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ThpId,ThpOrgId,ThpCdIdTpg,ThpCdIdTps,ThpCode,ThpNameLan1,ThpNameLan2,ThpNameLan3,ThpIsCustomer,ThpIsSupplier,ThpIsCompany,ThpCreateDate,ThpModifiedDate,ThpActive,ThpImpUid,ThpRemarks,ThpImported,ThpReadonly,ThpUsIdCreated,ThpNewcode,ThpPrintLang,ThpPrintarabic,ThpIsB2b")] Thirdparty thirdparty)
        {
            if (ModelState.IsValid)
            {
                _context.Add(thirdparty);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(thirdparty);
        }

        // GET: Thirdpartie/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var thirdparty = await _context.Thirdparties.FindAsync(id);
            if (thirdparty == null)
            {
                return NotFound();
            }
            return View(thirdparty);
        }

        // POST: Thirdpartie/Edit/5
     
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ThpId,ThpOrgId,ThpCdIdTpg,ThpCdIdTps,ThpCode,ThpNameLan1,ThpNameLan2,ThpNameLan3,ThpIsCustomer,ThpIsSupplier,ThpIsCompany,ThpCreateDate,ThpModifiedDate,ThpActive,ThpImpUid,ThpRemarks,ThpImported,ThpReadonly,ThpUsIdCreated,ThpNewcode,ThpPrintLang,ThpPrintarabic,ThpIsB2b")] Thirdparty thirdparty)
        {
            if (id != thirdparty.ThpId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(thirdparty);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ThirdpartyExists(thirdparty.ThpId))
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
            return View(thirdparty);
        }

        // GET: Thirdpartie/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var thirdparty = await _context.Thirdparties
                .FirstOrDefaultAsync(m => m.ThpId == id);
            if (thirdparty == null)
            {
                return NotFound();
            }

            return View(thirdparty);
        }

        // POST: Thirdpartie/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var thirdparty = await _context.Thirdparties.FindAsync(id);
            if (thirdparty != null)
            {
                _context.Thirdparties.Remove(thirdparty);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ThirdpartyExists(int id)
        {
            return _context.Thirdparties.Any(e => e.ThpId == id);
        }
    }
}
