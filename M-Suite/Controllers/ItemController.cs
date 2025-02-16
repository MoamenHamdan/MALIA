﻿using System;
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
    public class ItemController : Controller
    {
        private readonly MaliaContext _context;

        public ItemController(MaliaContext context)
        {
            _context = context;
        }

        // GET: Item
        public async Task<IActionResult> Index()
        {
            var maliaContext = _context.Items.Include(i => i.ItIt).Include(i => i.ItUom);
            return View(await maliaContext.ToListAsync());
        }

        // GET: Item/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var item = await _context.Items
                .Include(i => i.ItIt)
                .Include(i => i.ItUom)
                .FirstOrDefaultAsync(m => m.ItId == id);
            if (item == null)
            {
                return NotFound();
            }

            return View(item);
        }

        // GET: Item/Create
        public IActionResult Create()
        {
            ViewData["ItItId"] = new SelectList(_context.Items, "ItId", "ItId");
            ViewData["ItUomId"] = new SelectList(_context.Uoms, "UomId", "UomId");
            return View();
        }

        // POST: Item/Create
   
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ItId,ItItId,ItUomId,ItCdIdItg,ItCdIdIbd,ItCdIdIgp,ItCdIdIsg,ItCdIdItp,ItCode,ItDescriptionLan1,ItDescriptionLan2,ItDescriptionLan3,ItWeight,ItHasLot,ItHasProductionDate,ItHasExpiryDate,ItHasMultipleUom,ItHasSerial,ItIsDescription,ItIsSaleable,ItIsService,ItIsAsset,ItActive,ItImpUid,ItOrder,ItIsBadReturn")] Item item)
        {
            if (ModelState.IsValid)
            {
                _context.Add(item);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ItItId"] = new SelectList(_context.Items, "ItId", "ItId", item.ItItId);
            ViewData["ItUomId"] = new SelectList(_context.Uoms, "UomId", "UomId", item.ItUomId);
            return View(item);
        }

        // GET: Item/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var item = await _context.Items.FindAsync(id);
            if (item == null)
            {
                return NotFound();
            }
            ViewData["ItItId"] = new SelectList(_context.Items, "ItId", "ItId", item.ItItId);
            ViewData["ItUomId"] = new SelectList(_context.Uoms, "UomId", "UomId", item.ItUomId);
            return View(item);
        }

        // POST: Item/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ItId,ItItId,ItUomId,ItCdIdItg,ItCdIdIbd,ItCdIdIgp,ItCdIdIsg,ItCdIdItp,ItCode,ItDescriptionLan1,ItDescriptionLan2,ItDescriptionLan3,ItWeight,ItHasLot,ItHasProductionDate,ItHasExpiryDate,ItHasMultipleUom,ItHasSerial,ItIsDescription,ItIsSaleable,ItIsService,ItIsAsset,ItActive,ItImpUid,ItOrder,ItIsBadReturn")] Item item)
        {
            if (id != item.ItId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(item);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ItemExists(item.ItId))
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
            ViewData["ItItId"] = new SelectList(_context.Items, "ItId", "ItId", item.ItItId);
            ViewData["ItUomId"] = new SelectList(_context.Uoms, "UomId", "UomId", item.ItUomId);
            return View(item);
        }

        // GET: Item/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var item = await _context.Items
                .Include(i => i.ItIt)
                .Include(i => i.ItUom)
                .FirstOrDefaultAsync(m => m.ItId == id);
            if (item == null)
            {
                return NotFound();
            }

            return View(item);
        }

        // POST: Item/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var item = await _context.Items.FindAsync(id);
            if (item != null)
            {
                _context.Items.Remove(item);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ItemExists(int id)
        {
            return _context.Items.Any(e => e.ItId == id);
        }
    }
}
