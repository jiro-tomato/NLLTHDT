using System;

namespace Lab02
{
  class Program
  {
    static void Main(string[] args)
    {
      TestStaticField();
      TestPhanSo();

      return;
    }

    public static void TestStaticField()
    {
      var obj1 = new TetsStaticField();
      var obj2 = new TetsStaticField();

      obj1.I = 10;
      Console.WriteLine($"Gia tri I cua obj1: {obj1.I}");
      Console.WriteLine($"Gia tri I cua obj2: {obj2.I}");

      /*
      *   Bởi vì i là 1 trường static được tạo ra trước cả khi có bất kì đối tượng nào (obj1, obj2)
      *   Phạm vi truy cập của i gắn với chính bản thân class khai báo nó
      */
    }



    public static void TestPhanSo()
    {
      var ps1 = new PhanSo(5, 4);
      var ps2 = new PhanSo(1, 2);

      Console.WriteLine(-ps1);   // output: -5 / 4
      Console.WriteLine($"{ps1} + {ps2} = {ps1 + ps2}");  // output: 14 / 8 = 7 / 4
      Console.WriteLine($"{ps1} - {ps2} = {ps1 - ps2}");  // output: 6 / 8 = 3 / 4
      Console.WriteLine($"{ps1} * {ps2} = {ps1 * ps2}");  // output: 5 / 8
      Console.WriteLine($"{ps1} / {ps2} = {ps1 / ps2}");  // output: 10 / 4 = 5 / 2
      Console.WriteLine($"++{ps1} = {++ps1}");
      Console.WriteLine($"{ps1} == {ps2} ? {ps1 == ps2}");
      Console.WriteLine($"{ps1} != {ps2} ? {ps1 != ps2}");
    }
  }
}