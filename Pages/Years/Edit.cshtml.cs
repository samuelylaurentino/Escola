using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Escola.Data;
using Escola.Models;

namespace Escola.Pages.Years
{
    public class EditModel : PageModel
    {
        private readonly Escola.Data.SchoolContext _context;

        public EditModel(Escola.Data.SchoolContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Year Year { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Years == null)
            {
                return NotFound();
            }

            var year =  await _context.Years.FirstOrDefaultAsync(m => m.ID == id);
            if (year == null)
            {
                return NotFound();
            }
            Year = year;
           ViewData["CourseID"] = new SelectList(_context.Courses, "ID", "ID");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Year).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!YearExists(Year.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool YearExists(int id)
        {
          return _context.Years.Any(e => e.ID == id);
        }
    }
}
