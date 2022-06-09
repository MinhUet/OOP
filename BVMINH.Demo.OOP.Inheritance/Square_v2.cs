using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BVMINH.Demo.OOP.Polymorphism_Inheritance
{
    public class Square_v2 : Rectangle_v2
    {
        public Square_v2(string name, string color, double edge) : base(name, color, edge)
        {
        }

        public override void GetInfor()
        {
            Console.WriteLine("Square_v2");
        }
    }
}
