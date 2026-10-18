using System.Data.SqlClient;

namespace ThucHanh06b
{
    public static class DbCH
    {
        public const string ConnStr =
            "Data Source=localhost,1433;Initial Catalog=QLCuaHang;" +
            "User ID=sa;Password=Matkhau@123;TrustServerCertificate=True;Connect Timeout=5";

        public static string DichLoi(SqlException ex)
        {
            if (ex.Number == 4060)
                return "Không mở được CSDL QLCuaHang. Hãy chạy script tạo CSDL trước.";
            return Db.DichLoi(ex);
        }
    }
}