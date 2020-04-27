using System;
namespace Training
{
  public static class TienIch
  {
    public static int NhapSoNguyen(string msg)
  {
    int kq;
    bool isValid = true ;
    do
    {
      Console.WriteLine(msg);
      isValid = int.TryParse(Console.ReadLine(), out kq);
    } while (!isValid);
    return kq;
  }

  public static void Swap(ref int a, ref int b)
  {
    int t = a;
    a = b;
    b = a; 
  }
  }
}