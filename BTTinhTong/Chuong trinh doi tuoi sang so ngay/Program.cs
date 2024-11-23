namespace Chuong_trinh_doi_tuoi_sang_so_ngay
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tuoi_Ngay();
        }
        public static void Tuoi_Ngay()
        {
            string str = Console.ReadLine();
            bool parseSuccess = int.TryParse(str, out int month);

            if(parseSuccess)
            {
                switch (month) 
                {
                    
                    case 1:
                       Console.WriteLine("January");
                       break;
                    case 2:
                        Console.WriteLine("February");
                        break;
                    
                }
            }  
            else 
            {
                Console.WriteLine("Nhập sai định dạng");
            }
        }
    }
}
