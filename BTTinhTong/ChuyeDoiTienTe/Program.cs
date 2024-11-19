namespace ChuyeDoiTienTe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double rate = 25000; // Tỉ giá VND/USD

            Console.Write("Nhập giá trị USD: ");
            double usd = Convert.ToDouble(Console.ReadLine()); // Nhập giá trị USD từ người dùng

            double vnd = usd * rate; // Tính giá trị VND tương ứng

            Console.WriteLine($"Giá trị {usd} USD tương đương với {vnd} VND.");
        }
       
    }
}
