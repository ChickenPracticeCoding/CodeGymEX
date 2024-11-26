namespace InSoNGuyen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            YCau();
        }
        public static void YCau()
        {
            Console.Write("Nhap so luong so nguyen can hien thi:");
            string str = Console.ReadLine();
            bool passSuccess = int.TryParse(str, out int n);
            if (passSuccess) 
            {
                int m = 2;
                int count = 0;
                while(count<n)
                {
                    if(IsPrime(m))
                    {
                        Console.Write(m + " ");
                        count++;
                    }
                    m++;
                }    

            }
            else 
            {
                Console.WriteLine("Loi nhap!");
            }
        }
        public static bool IsPrime(int num)
        {
            if (num < 2) return false;
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0) return false;
            }
            return true;
        }
    }
}
