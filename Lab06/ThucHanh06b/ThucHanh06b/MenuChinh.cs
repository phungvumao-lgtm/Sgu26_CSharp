//using System;
//using System.Drawing;
//using System.Security.Policy;
//using System.Windows.Forms;

//namespace ThucHanh06b
//{
//    public class MenuChinh : Form
//    {
//        public MenuChinh()
//        {
//            Text = "Thực hành 06b";
//            ClientSize = new Size(280, 190);
//            StartPosition = FormStartPosition.CenterScreen;
//            FormBorderStyle = FormBorderStyle.FixedSingle;
//            MaximizeBox = false;

//            string[] ten = { "Quản lý sinh viên (ComboBox)", "Danh sách Lớp (ListView)", "Danh sách điểm (ListView)" };
//            Func<Form>[] tao = {
//                () => new SinhVienCombo(),
//                () => new DanhSachLop(),
//                () => new DanhSachDiem()
//            };

//            for (int i = 0; i < ten.Length; i++)
//            {
//                int k = i;
//                Button b = new Button();
//                b.Text = ten[i];
//                b.Left = 30;
//                b.Top = 20 + i * 50;
//                b.Width = 220;
//                b.Height = 36;
//                b.Click += (s, e) => tao[k]().Show();
//                Controls.Add(b);
//            }
//        }
//    }
//}