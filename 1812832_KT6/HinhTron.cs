namespace _1812832_KT6
{
  public class HinhTron
    {
        public double BanKinh{get; set;}

        public double DienTich
        {
          get 
          {
            var pi = 3.14;
            var dientich =  pi * BanKinh * BanKinh;
            return dientich;
          }
        }
        public double TheTich
        {
          get
          {
            var pi  = 3.14;
            var thetich  = (4*pi*BanKinh*BanKinh*BanKinh)/3;
            return thetich;
          }
        }


    }
}
