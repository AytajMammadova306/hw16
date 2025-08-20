using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework16.Models
{
    internal abstract class Fruit
    {
        public decimal Price { get; set; }
        public string Sort {  get; set; }
        public virtual void Taste()
        {
            Console.WriteLine("tastes sweet");
        }
        public override string ToString()
        {
            return ($"Price:{Price}, Sort:{Sort}, ");
        }
    }
}
