using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Capstone.Data;
using Capstone.Models;

namespace Capstone.Pages.Items
{
    public class DetailsModel : PageModel
    {
        private readonly Capstone.Data.CapstoneContext _context;

        public DetailsModel(Capstone.Data.CapstoneContext context)
        {
            _context = context;
        }

        public items items { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            items = await _context.items.FirstOrDefaultAsync(m => m.ID == id);

            if (items == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
