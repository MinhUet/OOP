using System;
using System.Collections.Generic;

namespace BVMINH.Demo.OOP.Polymorphism_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle_v1 rectangle1 = new Rectangle_v1(10,3);
            Console.WriteLine(rectangle1.GetHashCode());

            SquareFake squareFake = new SquareFake(6);

            Square square = new Square(5);

            // đã sắp xếp được
            var listRectangles = new List<Rectangle_v1>() { rectangle1, square };

            Rectangle_v1 rectangle2 = new Square(3);

            rectangle2.GetInfor();

            // Con trỏ quay xe
            ((Square)rectangle2).SayHi();



            var a = new Rectangle_v2("HCN", "RED", 10, 3);
            var b = new Square_v2("HV", "GREEN", 5);
            var c = new Circle("HT", "YELLOW", 3);

            // đã sắp xếp được
            var listShapes = new List<Shape>() { a, b, c };


        }
    }
}
