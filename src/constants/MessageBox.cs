using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace project_winform.src.constants
{
    class MessageBoxText
    {
        public static string Warning = "Cảnh Báo";
        public static string RequiredInput = "Vui lòng nhập các trường dữ liệu bắt buộc.";

        public static string CaptionLogout = "Đăng Xuất";
        public static string Logout = "Bạn có muốn đăng xuất không?";

        public static string CaptionDuplicatedCodeNum = "Trùng Mã Số";
        public static string DuplicatedCodeNum = "Mã số không được trùng trong dữ liệu đã có.";

        public static string CaptionLoginIncorrect = "Đăng Nhập Thất Bại";
        public static string LoginIncorrect = "Tài khoản hoặc mật khẩu không chính xác.";

        public static string CaptionForgotPass= "Quên Mật Khẩu";
        public static string ForgotPass = "Vui lòng liên hệ quản trị viên để cấp lại mật khẩu.";

        public static string CaptionException = "Có Lỗi Xảy Ra";
        public static string Exception = "Có lỗi xảy ra không như ý muốn. Vui lòng thử lại sau.";
    }
}
