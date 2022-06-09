using System;

namespace BVMINH.Demo.OOP.Polymorphism_Inheritance
{
    public class SquareFake
    {
        public double Edge { get; set; }

        public double GetArea()
        {
            return Math.Pow(Edge, 2);
        }

        public SquareFake(double edge)
        {
            Edge = edge;
        }

    }
}