namespace BVMINH.Demo.OOP.Polymorphism_Inheritance
{
    public class Rectangle_v1
    {
        protected double width;

        protected double height;

        public double GetArea()
        {
            return width * height;
        }

        // Để override được thì lớp cha phải có từ khóa virtual
        public virtual void GetInfor()
        {
            System.Console.WriteLine($"Rectangle - Width: {width} - Height: {height}");
        }

        public Rectangle_v1(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public Rectangle_v1(double edge)
        {
            width = edge;
            height = edge;
        }
    }
}