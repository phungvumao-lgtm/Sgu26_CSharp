using System;
using System.Windows.Forms;
using ThucHanh06a;

namespace ThucHanh06a
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new QLMonHoc());
            //Application.Run(new QLSinhVien());
            //Application.Run(new QLDiem());
            Application.Run(new QLLop());
        }
    }
}