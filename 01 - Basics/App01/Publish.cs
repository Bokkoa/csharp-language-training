using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App01
{
    public class Publish
    {
        // Public - Can be accessed by every resource
        // Protected - Just subclasses can access to the property\
        // Private - Only accesible by the code inside the class

        public string? Name { get; set; }
        public decimal Price { get; set; }
        public int Pages { get; set;  }

        public Publish(string? name, decimal price, int pages)
        {
            Name = name;
            Price = price;
            Pages = pages;
        }
        // virtual allows children to override method
        public virtual string GetDescription() => $"{Name} and price of {Price}$";

    }
}
