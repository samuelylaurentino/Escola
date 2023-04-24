using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Escola.Data;
using Escola.Models;

namespace Escola.Pages.Years
{
    public class DetailsModel : PageModel
    {
        private readonly Escola.Data.SchoolContext _context;

        public DetailsModel(Escola.Data.SchoolContext context)
        {
            _context = context;
        }

      public Year Year { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Years == null)
            {
                return NotFound();
            }

            var year = await _context.Years.FirstOrDefaultAsync(m => m.ID == id);
            if (year == null)
            {
                return NotFound();
            }
            else 
            {
                Year = year;
            }
            return Page();
        }
    }
}
