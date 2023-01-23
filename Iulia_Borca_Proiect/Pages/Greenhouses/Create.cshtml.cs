using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Iulia_Borca_Proiect.Data;
using Iulia_Borca_Proiect.Models;

namespace Iulia_Borca_Proiect.Pages.Greenhouses
{
    public class CreateModel : PageModel
    {
        private readonly Iulia_Borca_Proiect.Data.Iulia_Borca_ProiectContext _context;

        public CreateModel(Iulia_Borca_Proiect.Data.Iulia_Borca_ProiectContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Greenhouse Greenhouse { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Greenhouse.Add(Greenhouse);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
