using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App01
{
    public class Magazine: Publish
    {
        public string Journalist { get; set; }
        public Magazine(string journalist, string name, int quantityOfPages, decimal price): base(name, price, quantityOfPages){ 
            Journalist = journalist;
        }
        public override string GetDescription() => $"{Name} by journalist {Journalist} with {Pages} number of pages";

    }
}
