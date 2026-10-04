using System;

namespace Thuchanh04d

{
    public class PhuongTrinhBacHai
    {

        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public PhuongTrinhBacHai() { }

        public PhuongTrinhBacHai(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

       
        public string GiaiBacNhat()
        {
            if (A == 0)
            {
                if (B == 0) return "Phương trình có vô số nghiệm";
                return "Phương trình vô nghiệm";
            }
            double x = -B / A;
            return "Phương trình có nghiệm x = " + x.ToString("F2");
        }

    
        public string GiaiBacHai()
        {
            if (A == 0)
            {
               
                PhuongTrinhBacHai pt = new PhuongTrinhBacHai(B, C, 0);
                return pt.GiaiBacNhat();
            }

            double delta = B * B - 4 * A * C;
            if (delta < 0)
            {
                return "Phương trình vô nghiệm";
            }
            if (delta == 0)
            {
                double x = -B / (2 * A);
                return "Phương trình có nghiệm kép x1 = x2 = " + x.ToString("F2");
            }
            double x1 = (-B + Math.Sqrt(delta)) / (2 * A);
            double x2 = (-B - Math.Sqrt(delta)) / (2 * A);
            return "Phương trình có 2 nghiệm phân biệt x1 = " + x1.ToString("F2")
                 + " và x2 = " + x2.ToString("F2");
        }
    }
}