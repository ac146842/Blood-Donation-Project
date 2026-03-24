using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Blood_Donation_Project.Models;

namespace Blood_Donation_Project.Controllers
{
    public class BloodTypeTablesController : Controller
    {
        private readonly BloodDbContext _context;

        public BloodTypeTablesController(BloodDbContext context)
        {
            _context = context;
        }

        // GET: BloodTypeTables
        public async Task<IActionResult> Index()
        {
            return View(await _context.BloodTypeTable.ToListAsync());
        }

        // GET: BloodTypeTables/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bloodTypeTable = await _context.BloodTypeTable
                .FirstOrDefaultAsync(m => m.BloodType_ID == id);
            if (bloodTypeTable == null)
            {
                return NotFound();
            }

            return View(bloodTypeTable);
        }

        // GET: BloodTypeTables/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: BloodTypeTables/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("BloodType_ID,BloodType")] BloodTypeTable bloodTypeTable)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bloodTypeTable);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(bloodTypeTable);
        }

        // GET: BloodTypeTables/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bloodTypeTable = await _context.BloodTypeTable.FindAsync(id);
            if (bloodTypeTable == null)
            {
                return NotFound();
            }
            return View(bloodTypeTable);
        }

        // POST: BloodTypeTables/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("BloodType_ID,BloodType")] BloodTypeTable bloodTypeTable)
        {
            if (id != bloodTypeTable.BloodType_ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bloodTypeTable);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BloodTypeTableExists(bloodTypeTable.BloodType_ID))
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
            return View(bloodTypeTable);
        }

        // GET: BloodTypeTables/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bloodTypeTable = await _context.BloodTypeTable
                .FirstOrDefaultAsync(m => m.BloodType_ID == id);
            if (bloodTypeTable == null)
            {
                return NotFound();
            }

            return View(bloodTypeTable);
        }

        // POST: BloodTypeTables/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var bloodTypeTable = await _context.BloodTypeTable.FindAsync(id);
            if (bloodTypeTable != null)
            {
                _context.BloodTypeTable.Remove(bloodTypeTable);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BloodTypeTableExists(int id)
        {
            return _context.BloodTypeTable.Any(e => e.BloodType_ID == id);
        }
    }
}
