using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace WebBanHang
{
    public partial class DangNhap : System.Web.UI.Page
    {
        // Khai báo biến thành viên để lưu danh sách người dùng
        List<Objects.User> listUser;

        protected void Page_Load(object sender, EventArgs e)
        {
            // Lấy danh sách người dùng từ biến ứng dụng Application và gán cho listUser
            listUser = (List<Objects.User>)Application["listUser"];
        }

        protected void btnLogin_onclick(object sender, EventArgs e)
        {
            // Lấy giá trị của số điện thoại từ form
            string number = Request.Form["txtnumber"];
            // Lấy giá trị của mật khẩu từ form
            string password = Request.Form["txtpassword"];
            // Khởi tạo biến userName để lưu tên người dùng
            string userName = "";

            // Kiểm tra xem trang có được tải lại sau khi gửi form hay không
            if (IsPostBack)
            {
                // Lặp qua danh sách người dùng
                foreach (Objects.User user in listUser)
                {
                    if (user.number == number && user.password == password)
                    {
                        // Nếu đúng, gán tên người dùng cho userName
                        userName = user.username;
                    }

                    // Nếu tìm thấy người dùng hợp lệ
                    if (userName != "")
                    {
                        // Lưu số điện thoại vào Session
                        Session["number"] = number;
                        // Lưu tên người dùng vào Session
                        Session["username"] = userName;
                        // Chuyển hướng đến trang chủ
                        Response.Redirect("TrangChu.html");
                    }
                    else
                    {
                        // Nếu không tìm thấy người dùng hợp lệ, hiển thị thông báo lỗi
                        error.InnerHtml = "ERROR: Wrong phone number or password!";
                    }
                }
            }
        }
    }
}
