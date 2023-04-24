using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Escola.Data;
using Escola.Models;

namespace Escola.Pages.Years
{
    public class CreateModel : PageModel
    {
        private readonly Escola.Data.SchoolContext _context;

        public CreateModel(Escola.Data.SchoolContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["CourseID"] = new SelectList(_context.Courses, "ID", "Title");
            return Page();
        }

        [BindProperty]
        public Year Year { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Years.Add(Year);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
