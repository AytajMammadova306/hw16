using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework16.Models
{
    internal class Orange:Fruit
    {
        public double VitaminC {  get; set; }
        public override void Taste()
        {
            Console.WriteLine("sour");
            Console.Beep();
        }
        public override string ToString()
        {
            return base.ToString()+$" VitaminC:{VitaminC}";
        }
    }
}
