using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorCompositePatterns
{
    public class MenuItem
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsVegetarian { get; set; }
        public decimal Price { get; set; }

        public MenuItem(string name, string description, bool isVegetarian, decimal price)
        {
            Name = name;
            Description = description;
            IsVegetarian = isVegetarian;
            Price = price;
        }
    }
}
