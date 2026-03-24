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
    public class FormQuestionsController : Controller
    {
        private readonly BloodDbContext _context;

        public FormQuestionsController(BloodDbContext context)
        {
            _context = context;
        }

        // GET: FormQuestions
        public async Task<IActionResult> Index()
        {
            return View(await _context.FormQuestions.ToListAsync());
        }

        // GET: FormQuestions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var formQuestions = await _context.FormQuestions
                .FirstOrDefaultAsync(m => m.HealthQ_ID == id);
            if (formQuestions == null)
            {
                return NotFound();
            }

            return View(formQuestions);
        }

        // GET: FormQuestions/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: FormQuestions/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("HealthQ_ID,Questions")] FormQuestions formQuestions)
        {
            if (ModelState.IsValid)
            {
                _context.Add(formQuestions);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(formQuestions);
        }

        // GET: FormQuestions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var formQuestions = await _context.FormQuestions.FindAsync(id);
            if (formQuestions == null)
            {
                return NotFound();
            }
            return View(formQuestions);
        }

        // POST: FormQuestions/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("HealthQ_ID,Questions")] FormQuestions formQuestions)
        {
            if (id != formQuestions.HealthQ_ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(formQuestions);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FormQuestionsExists(formQuestions.HealthQ_ID))
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
            return View(formQuestions);
        }

        // GET: FormQuestions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var formQuestions = await _context.FormQuestions
                .FirstOrDefaultAsync(m => m.HealthQ_ID == id);
            if (formQuestions == null)
            {
                return NotFound();
            }

            return View(formQuestions);
        }

        // POST: FormQuestions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var formQuestions = await _context.FormQuestions.FindAsync(id);
            if (formQuestions != null)
            {
                _context.FormQuestions.Remove(formQuestions);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FormQuestionsExists(int id)
        {
            return _context.FormQuestions.Any(e => e.HealthQ_ID == id);
        }
    }
}
