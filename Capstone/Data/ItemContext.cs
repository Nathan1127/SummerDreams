using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Capstone.Models;
namespace Capstone.Data
{
    public class ItemContext : DbContext
    {
        public ItemContext() : base()
        {

        }

        public DbSet<Item> Item { get; set; }

    }
}
