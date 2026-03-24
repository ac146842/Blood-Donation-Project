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
    public class FormAnswersController : Controller
    {
        private readonly BloodDbContext _context;

        public FormAnswersController(BloodDbContext context)
        {
            _context = context;
        }

        // GET: FormAnswers
        public async Task<IActionResult> Index()
        {
            return View(await _context.FormAnswers.ToListAsync());
        }

        // GET: FormAnswers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var formAnswers = await _context.FormAnswers
                .FirstOrDefaultAsync(m => m.Answers_ID == id);
            if (formAnswers == null)
            {
                return NotFound();
            }

            return View(formAnswers);
        }

        // GET: FormAnswers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: FormAnswers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Answers_ID,Form_ID,HealthQ_ID,Answer")] FormAnswers formAnswers)
        {
            if (ModelState.IsValid)
            {
                _context.Add(formAnswers);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(formAnswers);
        }

        // GET: FormAnswers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var formAnswers = await _context.FormAnswers.FindAsync(id);
            if (formAnswers == null)
            {
                return NotFound();
            }
            return View(formAnswers);
        }

        // POST: FormAnswers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Answers_ID,Form_ID,HealthQ_ID,Answer")] FormAnswers formAnswers)
        {
            if (id != formAnswers.Answers_ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(formAnswers);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FormAnswersExists(formAnswers.Answers_ID))
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
            return View(formAnswers);
        }

        // GET: FormAnswers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var formAnswers = await _context.FormAnswers
                .FirstOrDefaultAsync(m => m.Answers_ID == id);
            if (formAnswers == null)
            {
                return NotFound();
            }

            return View(formAnswers);
        }

        // POST: FormAnswers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var formAnswers = await _context.FormAnswers.FindAsync(id);
            if (formAnswers != null)
            {
                _context.FormAnswers.Remove(formAnswers);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FormAnswersExists(int id)
        {
            return _context.FormAnswers.Any(e => e.Answers_ID == id);
        }
    }
}
