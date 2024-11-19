namespace DienTicCN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            S_Chu_Nhat();
        }
        public static void S_Chu_Nhat()
        {
            float width;
            float height;
            Console.Write("Enter width: ");
            width = float.Parse(Console.ReadLine());
            Console.Write("Enter height: ");
            height = float.Parse(Console.ReadLine());
            float area = width * height;
            Console.WriteLine("Area is: " + area);
        }
    }
}
