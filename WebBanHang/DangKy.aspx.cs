using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace WebBanHang
{
    public partial class DangKy : System.Web.UI.Page
    {
        // Danh sách người dùng (List<User>)
        List<Objects.User> listUser;

        protected void Page_Load(object sender, EventArgs e)
        {
            // Lấy danh sách người dùng từ Application và gán vào listUser
            listUser = (List<Objects.User>)Application["listUser"];
        }

        // Phương thức xử lý sự kiện khi người dùng nhấn nút đăng ký
        protected void btnRegister_onClick(object sender, EventArgs e)
        {
            // Lấy giá trị từ các trường nhập liệu và loại bỏ khoảng trắng ở đầu và cuối
            string name = Request.Form["txtName"].Trim();
            string number = Request.Form["txtnumber"].Trim();
            string password = Request.Form["txtpassword"].Trim();

            // Biến kiểm tra tính hợp lệ của đăng ký
            bool check = true;

            // Kiểm tra xem số điện thoại đã tồn tại trong danh sách người dùng hay chưa
            foreach (Objects.User user in listUser)
            {
                if (user.number == number)
                {
                    // Nếu số điện thoại đã tồn tại, hiển thị lỗi và đặt check thành false
                    error.InnerHtml = "ERROR: Đã tồn tại số điện thoại này!";
                    check = false;
                    break;
                }
                else
                {
                    // Nếu không tồn tại, xóa thông báo lỗi
                    error.InnerHtml = "";
                }
            }

            // Nếu check vẫn là true (tức là số điện thoại chưa tồn tại)
            if (check)
            {
                // Tạo người dùng mới và thêm vào danh sách người dùng
                Objects.User newUser = new Objects.User(number, password, name);
                listUser.Add(newUser);

                // Cập nhật lại danh sách người dùng trong Application
                Application["listUser"] = listUser;

                // Chuyển hướng người dùng đến trang đăng nhập
                Response.Redirect("DangNhap.aspx");
            }
        }
    }
}
