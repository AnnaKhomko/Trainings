using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4._4
{
    public class Product
    {
        public string Name { get; set; } 
        public int Cost { get; set; }
        public int Amount { get; set; }

        public override string ToString()
        {
           return $"Name:{Name}\n   Cost: {Cost} \n   Amount: {Amount}\n";
        }
        
    }
}
