using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BVMINH.Demo.OOP.Polymorphism_Inheritance
{
    public class Square : Rectangle_v1
    {
        public Square(double edge) : base(edge)
        {
        }

        // Để override phương thức lớp cha, lớp con phải có từ khóa override
        public override void GetInfor()
        {
            System.Console.WriteLine($"Square - Edge: {width}");
        }


        public void SayHi()
        {
            System.Console.WriteLine($"Square - Hello world");
        }
    }
}
