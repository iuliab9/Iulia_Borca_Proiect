using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Iulia_Borca_Proiect.Data;
using Iulia_Borca_Proiect.Models;

namespace Iulia_Borca_Proiect.Pages.Greenhouses
{
    public class EditModel : PageModel
    {
        private readonly Iulia_Borca_Proiect.Data.Iulia_Borca_ProiectContext _context;

        public EditModel(Iulia_Borca_Proiect.Data.Iulia_Borca_ProiectContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Greenhouse Greenhouse { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Greenhouse == null)
            {
                return NotFound();
            }

            var greenhouse =  await _context.Greenhouse.FirstOrDefaultAsync(m => m.ID == id);
            if (greenhouse == null)
            {
                return NotFound();
            }
            Greenhouse = greenhouse;
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

            _context.Attach(Greenhouse).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GreenhouseExists(Greenhouse.ID))
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

        private bool GreenhouseExists(int id)
        {
          return _context.Greenhouse.Any(e => e.ID == id);
        }
    }
}
