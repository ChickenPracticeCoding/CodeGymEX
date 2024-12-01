namespace OOPExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HCN hcn1 = new HCN();
            hcn1.NHAP();
            Console.WriteLine("Chu vi hinh chu nhat la: {0}", hcn1.CHuVi());
            Console.WriteLine("Dien tich hình chu nhat la {0} ", hcn1.DienTich());
        }
    }
}
