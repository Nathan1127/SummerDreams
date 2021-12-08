using Capstone.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone.Interfaces
{
    interface IDataAccessLayer
    {
        IEnumerable<Item> GetItems();
        void AddItem(Item item);
    }
}
