using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            BoiCua5();
        }
        public static void BoiCua5()
        {
            Console.Write("Nhập số lượng phần tử n: ");
            string input = Console.ReadLine();
            bool isValid = int.TryParse(input, out int n);

            if (isValid && n > 0)
            {
                for (int i = 0; i < n; i++)
                {
                    if (i % 5 == 0)
                    {
                        Console.WriteLine("Các số chia hết cho 5 là:" + i);
                    }  
                }
            }
            else
            {
                Console.WriteLine("Vui lòng nhập số lượng phần tử hợp lệ.");
            }
        }
    }
}

