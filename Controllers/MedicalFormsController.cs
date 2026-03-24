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
    public class MedicalFormsController : Controller
    {
        private readonly BloodDbContext _context;

        public MedicalFormsController(BloodDbContext context)
        {
            _context = context;
        }

        // GET: MedicalForms
        public async Task<IActionResult> Index()
        {
            return View(await _context.MedicalForm.ToListAsync());
        }

        // GET: MedicalForms/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var medicalForm = await _context.MedicalForm
                .FirstOrDefaultAsync(m => m.Form_ID == id);
            if (medicalForm == null)
            {
                return NotFound();
            }

            return View(medicalForm);
        }

        // GET: MedicalForms/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MedicalForms/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Form_ID,Donor_ID,Nurse_ID,FormDate")] MedicalForm medicalForm)
        {
            if (ModelState.IsValid)
            {
                _context.Add(medicalForm);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(medicalForm);
        }

        // GET: MedicalForms/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var medicalForm = await _context.MedicalForm.FindAsync(id);
            if (medicalForm == null)
            {
                return NotFound();
            }
            return View(medicalForm);
        }

        // POST: MedicalForms/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Form_ID,Donor_ID,Nurse_ID,FormDate")] MedicalForm medicalForm)
        {
            if (id != medicalForm.Form_ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(medicalForm);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MedicalFormExists(medicalForm.Form_ID))
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
            return View(medicalForm);
        }

        // GET: MedicalForms/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var medicalForm = await _context.MedicalForm
                .FirstOrDefaultAsync(m => m.Form_ID == id);
            if (medicalForm == null)
            {
                return NotFound();
            }

            return View(medicalForm);
        }

        // POST: MedicalForms/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var medicalForm = await _context.MedicalForm.FindAsync(id);
            if (medicalForm != null)
            {
                _context.MedicalForm.Remove(medicalForm);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MedicalFormExists(int id)
        {
            return _context.MedicalForm.Any(e => e.Form_ID == id);
        }
    }
}
