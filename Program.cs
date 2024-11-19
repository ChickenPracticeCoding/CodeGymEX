using System;
namespace ConsoleApp1
{
    class Program
    {
        public static void Tong()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Nhập sô hạng thứ nhất: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhập sô hạng thứ hai: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("-----------------------");
            Console.Write("Tổng 2 số a + b ={0} ", a + b);

        }
        static void Main(string[] args)
        {
            Tong();
            Console.WriteLine("Helo World");
            
        }
       
    }



}
