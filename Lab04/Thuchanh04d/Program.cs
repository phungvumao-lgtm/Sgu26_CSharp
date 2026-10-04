using System;
using System.Windows.Forms;
using ThucHanh04d;

namespace ThucHanh04c
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new GiaiPhuongTrinh());
            Application.Run(new MangSo());

        }
    }
}