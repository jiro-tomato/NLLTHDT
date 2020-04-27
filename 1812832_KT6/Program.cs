using System;

namespace _1812832_KT6
{
  class Program
    {
        static void Main(string[] args)
        {
            var hinhtron = new HinhTron();
            hinhtron.BanKinh = 5;
            System.Console.Write("Ban kinh la ");
            System.Console.WriteLine(hinhtron.BanKinh);
            System.Console.Write("Dien tich hinh tron la ");
            System.Console.WriteLine(hinhtron.DienTich);
            System.Console.Write("The tich hinh cau la ");
            System.Console.WriteLine(hinhtron.TheTich);

        }
    }
}
