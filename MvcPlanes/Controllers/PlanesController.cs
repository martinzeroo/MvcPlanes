﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MvcPlane.Models;
using MvcPlanes.Data;

namespace MvcPlanes.Controllers
{
    public class PlanesController : Controller
    {
        private readonly MvcPlanesContext _context;

        public PlanesController(MvcPlanesContext context)
        {
            _context = context;
        }

       
       
 // GET: Planes
        // GET: Planes/Details/5
        public async Task<IActionResult> Index(string searchString)
        {
            var planes = from m in _context.Plane
                         select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                planes = planes.Where(s => s.Name.Contains(searchString));
            }

            return View(await planes.ToListAsync());
        }

        // GET: Planes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Planes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Departure,Type,Price")] Plane plane)
        {
            if (ModelState.IsValid)
            {
                _context.Add(plane);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(plane);
        }

        // GET: Planes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var plane = await _context.Plane.FindAsync(id);
            if (plane == null)
            {
                return NotFound();
            }
            return View(plane);
        }

        // POST: Planes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Departure,Type,Price")] Plane plane)
        {
            if (id != plane.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(plane);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PlaneExists(plane.Id))
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
            return View(plane);
        }

        // GET: Planes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var plane = await _context.Plane
                .FirstOrDefaultAsync(m => m.Id == id);
            if (plane == null)
            {
                return NotFound();
            }

            return View(plane);
        }

        // POST: Planes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var plane = await _context.Plane.FindAsync(id);
            _context.Plane.Remove(plane);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PlaneExists(int id)
        {
            return _context.Plane.Any(e => e.Id == id);
        }
    }
}
