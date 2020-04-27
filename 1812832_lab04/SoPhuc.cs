using System;
namespace Training
{
  public class Sophuc
  {
    public int _thuc {get; set;}
    public int _ao {get; set;}

    public Sophuc(int thuc, int ao)
    {
      this._thuc = thuc;
      this._ao = ao;
    }
    public bool SoThuanAo {get => this._thuc == 0;}
    public bool SoThuc {get => this._ao ==0;}

    public static Sophuc TaoSoPhuc()
    {
      int thuc = TienIch.NhapSoNguyen("Nhap phan thuc");
      int ao = TienIch.NhapSoNguyen("Nhap phan ao"); 
      return new Sophuc(thuc, ao);
    }
    


  }
}