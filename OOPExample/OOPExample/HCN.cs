using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExample
{
    internal class HCN
    {
        public double CDai
        { get; set; }

        public double CRong
        { get;set; }
        
        public void NHAP()
        {
            Console.Write("Nhap chieu dai: ");
            CDai = int.Parse(Console.ReadLine());
            Console.Write("Nhap chieu rong: ");
            CRong = int.Parse(Console.ReadLine());
        }
        public HCN(){}

        public HCN(double _CDai, double _CRong)
        {
            CDai = _CDai;
            CRong = _CRong;
        }
        public double CHuVi()
        {
            return  (CDai + CRong) *2;
        }

        public double DienTich()
        {
            return CDai * CRong;
        }
    }
}
