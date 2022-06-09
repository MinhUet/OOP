using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BVMINH.Demo.OOP.Polymorphism_Inheritance
{
    /// <summary>
    /// 1. Phát hiện IS A
    /// 2. Đặc điểm: Con trùng hoàn toàn của cha, gửi cha giữ hết khỏi lo làm j, Nếu con dị biệt thì làm bình thường
    /// 3. Tạo contructor kết thừa của cha, và gán giá trị cho con
    /// 4. Hàm của con: Có quyền làm dị biệt như bthg
    /// - LEVEL 1 của kế thừa: Xài hoàn toàn của cha, ngứa tay muốn vượt mặt thì cứ OVERRIDE
    /// - LEVEL 2 của kế thừa: Con kết thừa từ cha, cha này là ABSTRACT cho nên con chỉ có 2 lựa chọn:
    ///     + Lựa chọn 1: Con làm biếng ko làm theo lời cha => ko thèm viết code cho hàm abstract của cha, 
    ///     tức là con chứa hàm abstract từ cha mà 1 class chứa hàm ABSTRACT thì class đó ko hoàn hảo (class đó chứa những ý tưởng)
    ///     không thể vận hành, do đó KO THỂ new để tạo object => cha ko tạo đc object, con ko tạo đc object
    ///     => cha, con đều vô sinh ko tạo được object
    ///     
    ///     + Lựa chọn 2: Con nghe lời cha, hoàn tất các ý tưởng của cha (viết code cho các hàm ABSTRACT của cha),
    ///     => CON là 1 lớp hoàn hảo
    ///     (Các vua hùng đã có công dựng nươc, bác cháu ta phải cùng nhau giữ lấy nước)
    /// </summary>
    public class Rectangle_v2 : Shape
    {
        private double Width;

        private double Height;

        public override double GetArea()
        {
            return Width * Height;
        }

        public override void GetInfor()
        {
            Console.WriteLine("Rectangle_v2");
        }
        public Rectangle_v2(string name, string color, double width, double height) : base(name, color)
        {
            Width = width;
            Height = height;
        }
        public Rectangle_v2(string name, string color, double edge) : base(name, color)
        {
            Width = edge;
            Height = edge;
        }
    }
}
