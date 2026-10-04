using System;
using System.Collections.Generic;
using System.Linq;

namespace ThucHanh04d
{
    public class MangSoNguyen
    {
        private List<int> ds = new List<int>();

        public int SoPhanTu { get { return ds.Count; } }

        // Nhập mảng từ chuỗi, các số cách nhau bằng dấu cách, phẩy hoặc chấm phẩy
        public bool Nhap(string chuoi, out string loi)
        {
            loi = "";
            string[] phan = chuoi.Split(new char[] { ' ', ',', ';' },
                StringSplitOptions.RemoveEmptyEntries);
            if (phan.Length == 0)
            {
                loi = "Vui lòng nhập dãy số nguyên!";
                return false;
            }

            List<int> tam = new List<int>();
            foreach (string s in phan)
            {
                int x;
                if (!int.TryParse(s, out x))
                {
                    loi = "'" + s + "' không phải là số nguyên!";
                    return false;
                }
                tam.Add(x);
            }
            ds = tam;
            return true;
        }

        public void Xoa() { ds.Clear(); }

        public void SapXep(bool tang)
        {
            ds.Sort();
            if (!tang) ds.Reverse();
        }

        public bool DaSapXepTang()
        {
            for (int i = 1; i < ds.Count; i++)
                if (ds[i] < ds[i - 1]) return false;
            return true;
        }

        public bool HopLeViTri(int vt) { return vt >= 0 && vt < ds.Count; }

        // Tìm vị trí (bắt đầu từ 0) của giá trị, -1 nếu không có
        public int TimGiaTri(int gt) { return ds.IndexOf(gt); }

        public int LayGiaTri(int vt) { return ds[vt]; }

        // Thêm giá trị tại vị trí (0 đến số phần tử)
        public bool Them(int gt, int vt)
        {
            if (vt < 0 || vt > ds.Count) return false;
            ds.Insert(vt, gt);
            return true;
        }

        public bool XoaGiaTri(int gt)
        {
            int i = ds.IndexOf(gt);
            if (i < 0) return false;
            ds.RemoveAt(i);
            return true;
        }

        public bool XoaViTri(int vt)
        {
            if (!HopLeViTri(vt)) return false;
            ds.RemoveAt(vt);
            return true;
        }

        public long Tong() { return ds.Sum(x => (long)x); }
        public long TongChan() { return ds.Where(x => x % 2 == 0).Sum(x => (long)x); }
        public long TongLe() { return ds.Where(x => x % 2 != 0).Sum(x => (long)x); }

        public int Max() { return ds.Max(); }
        public int Min() { return ds.Min(); }

        // Thay tất cả phần tử có giá trị cũ bằng giá trị mới, trả về số phần tử đã thay
        public int ThayGiaTri(int cu, int moi)
        {
            int dem = 0;
            for (int i = 0; i < ds.Count; i++)
            {
                if (ds[i] == cu) { ds[i] = moi; dem++; }
            }
            return dem;
        }

        public bool ThayViTri(int vt, int moi)
        {
            if (!HopLeViTri(vt)) return false;
            ds[vt] = moi;
            return true;
        }

        public override string ToString()
        {
            return string.Join(" ", ds);
        }
    }
}