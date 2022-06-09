using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BVMINH.Demo.OOP.Polymorphism_Inheritance
{
    /// <summary>
    /// Một class chứa hàm ABSTRACT tức là hàm ko code, nó giống như bản CONCEPT
    /// Nó chỉ là ý tưởng mà thoy vì thế class chưa hoàn hảo, chưa hành xử được
    /// Nên class chứa hàm ABSTRACT thì class CŨNG phải là ABSTRACT
    /// </summary>
    public abstract class Shape
    {
        private string Name;

        private string Color;

        public abstract double GetArea();

        public virtual void GetInfor()
        {
            System.Console.WriteLine($"Shape - Name: {Name} - Color: {Color}");
        }

        public Shape(string name, string color)
        {
            Name = name;
            Color = color;
        }
    }
}
