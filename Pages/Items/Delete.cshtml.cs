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
    public class DeleteModel : PageModel
    {
        private readonly Capstone.Data.CapstoneContext _context;

        public DeleteModel(Capstone.Data.CapstoneContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            items = await _context.items.FindAsync(id);

            if (items != null)
            {
                _context.items.Remove(items);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
