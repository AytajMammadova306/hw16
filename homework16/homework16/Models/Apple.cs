using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework16.Models
{
    internal class Apple:Fruit
    {
        public double VitaminA { get; set; }
        public double VitaminB { get; set; }
        public override void Taste()
        {
            Console.WriteLine("sweet and sour");
        }
        public override string ToString()
        {
            return base.ToString() + $" VitaminA:{VitaminA}, VitaminB:{VitaminB}";
        }
    }
}
