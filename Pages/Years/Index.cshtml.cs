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
    public class IndexModel : PageModel
    {
        private readonly Escola.Data.SchoolContext _context;

        public IndexModel(Escola.Data.SchoolContext context)
        {
            _context = context;
        }

        public IList<Year> Year { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Years != null)
            {
                Year = await _context.Years
                .Include(y => y.Course).ToListAsync();
            }
        }
    }
}
