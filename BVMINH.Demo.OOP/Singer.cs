namespace BVMINH.Demo.OOP.Object_Class_AccessModifier
{
    public class Singer
    {
        private string nickName;

        private int totalHits;

        public static string _bank = "686868";

        public void SetName(string nickName)
        {
            this.nickName = nickName;
        }

        public string GetName()
        {
            return this.nickName;
        }

        public void SetTotalHits(int totalHits)
        {
            this.totalHits = totalHits;
        }

        public int GetTotalHits()
        {
            return this.totalHits;
        }

        public void GetDetail()
        {
            System.Console.WriteLine($"Thong tin singer - NickName: {nickName} - TotalHits: {totalHits} - Bank: {_bank}");
        }

        public static void LiveShow()
        {
            System.Console.WriteLine($"Lalala -  Bank: {_bank}");
            //System.Console.WriteLine($"Lalala - NickName: {_nickName} - TotalHits: {_totalHits} - Bank: {_bank}");
        }

        //prop -> Lay get set
        public Singer(string name, int totalHits)
        {
            this.nickName = name;
            this.totalHits = totalHits;
        }
    }
}