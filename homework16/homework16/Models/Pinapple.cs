using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework16.Models
{
    internal class Pineapple:Fruit
    {
        public double VitaminE {  get; set; }
        public double VitaminD { get; set; }
        public override string ToString()
        {
            return base.ToString()+$" VitaminE:{VitaminE}, VitamiD:{VitaminD}";
        }
    }
}
