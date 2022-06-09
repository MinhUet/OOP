using System;

namespace BVMINH.Demo.OOP.Object_Class_AccessModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            var PI = 3.14;
            var companyName = "MISA";

            var locPhat = new Singer("Loc Phat", 10);
            var batTu = new Singer("Bat Tu", 2);

            locPhat.GetDetail();

            Singer._bank = "662204";

            locPhat.GetDetail();
            batTu.GetDetail();
        }
    }
}
