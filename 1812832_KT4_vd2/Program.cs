using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vidu2
{
  class XeHoi
  {
    protected int TocDo;
    protected string BienSo;
    protected string HangSX;
    public XeHoi(int td, string BS, string HSX)
    {
      TocDo = td;
      BienSo = BS;
      HangSX = HSX;
    }
    public void Xuat()
    {
      Console.Write("Xe :{0}, Bien so: {1}, Toc do: {2} kmh", HangSX, BienSo, TocDo);
    }
    class XeKhach : XeHoi
    {
      int SoHanhKhach;
      public XeKhach(int td, string BS, string HSX, int SHK) : base(td, BS, HSX)
      {
        SoHanhKhach = SHK;
      }
      public new void Xuat()
      {
        base.Xuat();
        Console.WriteLine(",{0} cho ngoi", SoHanhKhach);
      }
    }
    class program
    {
      static void Main(string[] args)
      {
        XeKhach c = new XeKhach(150, "49A-4444", "Toyota", 24);
        c.Xuat();
        Console.ReadLine();
      }
    }
  }
}