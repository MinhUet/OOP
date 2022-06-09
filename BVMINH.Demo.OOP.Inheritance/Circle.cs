using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BVMINH.Demo.OOP.Polymorphism_Inheritance
{
    public class Circle : Shape
    {
        private double radius;
        public Circle(string name, string color, double radius) : base(name, color)
        {
            this.radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        public override void GetInfor()
        {
            Console.WriteLine("radius");
        }
    }
}
