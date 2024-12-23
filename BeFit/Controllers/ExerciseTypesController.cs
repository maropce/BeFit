﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BeFit.Data;
using BeFit.Models;

namespace BeFit.Controllers
{
    public class ExerciseTypesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ExerciseTypesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ExerciseTypes
        public async Task<IActionResult> Index()
        {
            return View(await _context.ExerciseType.ToListAsync());
        }

        // GET: ExerciseTypes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var exerciseType = await _context.ExerciseType
                .FirstOrDefaultAsync(m => m.Id == id);
            if (exerciseType == null)
            {
                return NotFound();
            }

            return View(exerciseType);
        }

        // GET: ExerciseTypes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ExerciseTypes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name")] ExerciseType exerciseType)
        {
            if (ModelState.IsValid)
            {
                _context.Add(exerciseType);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(exerciseType);
        }

        // GET: ExerciseTypes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var exerciseType = await _context.ExerciseType.FindAsync(id);
            if (exerciseType == null)
            {
                return NotFound();
            }
            return View(exerciseType);
        }

        // POST: ExerciseTypes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name")] ExerciseType exerciseType)
        {
            if (id != exerciseType.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(exerciseType);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ExerciseTypeExists(exerciseType.Id))
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
            return View(exerciseType);
        }

        // GET: ExerciseTypes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var exerciseType = await _context.ExerciseType
                .FirstOrDefaultAsync(m => m.Id == id);
            if (exerciseType == null)
            {
                return NotFound();
            }

            return View(exerciseType);
        }

        // POST: ExerciseTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var exerciseType = await _context.ExerciseType.FindAsync(id);
            if (exerciseType != null)
            {
                _context.ExerciseType.Remove(exerciseType);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ExerciseTypeExists(int id)
        {
            return _context.ExerciseType.Any(e => e.Id == id);
        }
    }
}
