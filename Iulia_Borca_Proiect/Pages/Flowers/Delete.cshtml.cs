using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Iulia_Borca_Proiect.Data;
using Iulia_Borca_Proiect.Models;

namespace Iulia_Borca_Proiect.Pages.Flowers
{
    public class DeleteModel : PageModel
    {
        private readonly Iulia_Borca_Proiect.Data.Iulia_Borca_ProiectContext _context;

        public DeleteModel(Iulia_Borca_Proiect.Data.Iulia_Borca_ProiectContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Flower Flower { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Flower == null)
            {
                return NotFound();
            }

            var flower = await _context.Flower.FirstOrDefaultAsync(m => m.ID == id);

            if (flower == null)
            {
                return NotFound();
            }
            else 
            {
                Flower = flower;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Flower == null)
            {
                return NotFound();
            }
            var flower = await _context.Flower.FindAsync(id);

            if (flower != null)
            {
                Flower = flower;
                _context.Flower.Remove(Flower);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
