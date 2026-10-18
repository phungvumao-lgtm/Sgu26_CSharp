using System.Data.SqlClient;

namespace ThucHanh06b
{
    public static class Db
    {
        // Kết nối SQL Server chạy trong Docker
        public const string ConnStr =
            "Data Source=localhost,1433;Initial Catalog=QLSinhVien;" +
            "User ID=sa;Password=Matkhau@123;TrustServerCertificate=True;Connect Timeout=5";

        // Đổi lỗi SQL sang câu tiếng Việt dễ hiểu
        public static string DichLoi(SqlException ex)
        {
            switch (ex.Number)
            {
                case 2627:
                case 2601:
                    return "Mã đã tồn tại!";
                case 547:
                    return "Dữ liệu không hợp lệ hoặc đang được dùng ở bảng khác!";
                case -1:
                case 2:
                case 53:
                case 40:
                case 10061:
                    return "Không kết nối được SQL Server!\n" +
                           "Hãy mở Docker Desktop và chạy: docker start sqlserver\n" +
                           "(chờ 20-30 giây rồi thử lại).";
                case 4060:
                    return "Không mở được CSDL QLSinhVien. Hãy kiểm tra đã tạo CSDL chưa.";
                case 18456:
                    return "Sai tài khoản hoặc mật khẩu SQL Server (user sa).";
                default:
                    return "Thất bại: " + ex.Message;
            }
        }
    }
}