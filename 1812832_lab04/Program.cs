using System;
namespace Training
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("nhap so phuc");
      var sp = Sophuc.TaoSoPhuc();
      Console.WriteLine(" so phuc cua ban la {0} + {1}i",sp._thuc,sp._ao);
      

    }
  }
}