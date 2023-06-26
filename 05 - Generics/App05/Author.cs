using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App05
{
    public class Author : Person, IComparable<Author>
    {

        public Author(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }

        // WITHOUT GENERIC USE
        //public int CompareTo(object? obj)
        //{
        //    if (obj is null) return 1;

        //    if (obj is Author author) // if it is the same type, generates and instance
        //    {
        //        return this.ToString().CompareTo(author.ToString());
        //    }

        //    throw new ArgumentException("Is not a author instance", nameof(author));
        //}

        public override string ToString()
        {
            return $"{Name} {Surname}";
        }

        // WITH THE GENERIC USE
        public int CompareTo(Author? other)
        {
            return this.ToString().CompareTo(other?.ToString());
        }
    }
}
