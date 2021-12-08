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
    public class IndexModel : PageModel
    {
        private readonly Capstone.Data.CapstoneContext _context;

        public IndexModel(Capstone.Data.CapstoneContext context)
        {
            _context = context;
        }

        public IList<items> items { get;set; }

        public async Task OnGetAsync()
        {
            items = await _context.items.ToListAsync();
        }
    }
}
