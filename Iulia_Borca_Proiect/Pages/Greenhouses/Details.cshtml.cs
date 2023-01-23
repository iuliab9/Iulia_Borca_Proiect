using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Iulia_Borca_Proiect.Data;
using Iulia_Borca_Proiect.Models;

namespace Iulia_Borca_Proiect.Pages.Greenhouses
{
    public class DetailsModel : PageModel
    {
        private readonly Iulia_Borca_Proiect.Data.Iulia_Borca_ProiectContext _context;

        public DetailsModel(Iulia_Borca_Proiect.Data.Iulia_Borca_ProiectContext context)
        {
            _context = context;
        }

      public Greenhouse Greenhouse { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Greenhouse == null)
            {
                return NotFound();
            }

            var greenhouse = await _context.Greenhouse.FirstOrDefaultAsync(m => m.ID == id);
            if (greenhouse == null)
            {
                return NotFound();
            }
            else 
            {
                Greenhouse = greenhouse;
            }
            return Page();
        }
    }
}
