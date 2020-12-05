using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace project_winform.src.constants
{
    class MessageBoxText
    {
        public static string CaptionError = "Lỗi";
        public static string CaptionWarning = "Cảnh Báo";
        public static string CaptionInformation = "Thông Báo";
        public static string CaptionSuccess = "Thành Công";

        public static string RequiredInput = "Vui lòng nhập các trường dữ liệu bắt buộc.";
        public static string DatabaseConnectFalse = "Không thể kết nối được với dữ liệu, vui lòng thử lại.";
        public static string DatabaseConnectTrue = "Kết nối với cơ sở dữ liệu thành công.";
        public static string Logout = "Bạn có muốn đăng xuất không?";
        public static string DuplicatedCodeNum = "Mã số không được trùng trong dữ liệu đã có.";
        public static string LoginIncorrect = "Tài khoản hoặc mật khẩu không chính xác.";
        public static string ForgotPass = "Vui lòng liên hệ quản trị viên để cấp lại mật khẩu.";
        public static string Exception = "Có lỗi xảy ra không như ý muốn. Vui lòng thử lại sau.";
        public static string NotSelectListView = "Vui lòng chọn ít nhất 1 mục để thực hiện hành động.";
        public static string ExportSuccess = "Bạn đã xuất dữ liệu thành công. Số Dòng: ";
        public static string ImportSuccess = "Bạn đã nhập dữ liệu thành công. Số Dòng: ";
        public static string ConfigDelete = "Bạn có chắc chắn muốn xóa dữ liệu được chọn không?";
        public static string GeneratorPassword = "Đây là mật khẩu hệ thống tạo cho bạn.\nVui lòng sao chép và ghi nhớ nó.";
        public static string PassWordNotMatch = "Nhập lại mật khẩu không giống, vui lòng nhập lại.";
        public static string PassWordIncorrect = "Mật khẩu cũ không chính xác, vui lòng nhập lại.";
        public static string ChangePassWordSuccess = "Bạn đã thay đổi mật khẩu thành công.";
        public static string ReloadDataSuccess = "Tải lại dữ liệu thành công!";
        public static string SaveFileSuccess = "Lưu dữ liệu thành công, vui lòng khởi động lại ứng dụng.";
        public static string QuestionConfigDatabase = "Kết nối dữ liệu không thành công.\nBạn có muốn kết nối cơ sở dữ liệu khác không?";
    }
}
