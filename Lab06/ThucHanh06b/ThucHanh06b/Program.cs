using System;
using System.Windows.Forms;

namespace ThucHanh06b
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new SinhVienCombo());
            //Application.Run(new DanhSachLop());
            //Application.Run(new DanhSachDiem());
            Application.Run(new FormCuaHang());
        }
    }
}