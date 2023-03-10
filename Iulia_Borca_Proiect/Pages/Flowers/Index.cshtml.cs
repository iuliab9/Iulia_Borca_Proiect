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
    public class IndexModel : PageModel
    {
        private readonly Iulia_Borca_Proiect.Data.Iulia_Borca_ProiectContext _context;

        public IndexModel(Iulia_Borca_Proiect.Data.Iulia_Borca_ProiectContext context)
        {
            _context = context;
        }

        public IList<Flower> Flower { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Flower != null)
            {
                Flower = await _context.Flower.ToListAsync();
            }
        }
    }
}
