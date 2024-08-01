using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebBanHang
{
  
    public partial class TrangChu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Kiểm tra xem session "username" có null hay không
            if ((string)Session["username"] == null)
            {
                // Nếu chưa đăng nhập, hiển thị các icon: yêu thích, giỏ hàng, đăng nhập
                var str = "<div class=\"icons\" id=\"icons\" runat=\"server\">\r\n  " +
                    "<a href=\"YeuThich.aspx\" class=\"fas fa-heart\"></a>\r\n  " +
                    " <a href=\"GioHang.aspx\" class=\"fas fa-shopping-cart\"></a>\r\n   " +
                    " <a href=\"DangNhap.aspx\" class=\"fas fa-user\"></a>\r\n";
                icons.InnerHtml = str;
            }
            else
            {
                // Nếu đã đăng nhập, hiển thị thêm username và icon đăng xuất
                var str = "<div class=\"icons\" id=\"icons\" runat=\"server\">\r\n  " +
                    "<a href=\"YeuThich.aspx\" class=\"fas fa-heart\"></a>\r\n  " +
                    "<a href=\"GioHang.aspx\" class=\"fas fa-shopping-cart\"></a>\r\n   " +
                    "<a href=\"\" class=\"fas fa-user\"></a>\r\n" +
                    "<a>" + (string)Session["username"] + "</a>" +
                    "<a href=\"DangXuat.aspx\" class=\"fas fa-sign-out\"></a>";
                icons.InnerHtml = str;
            }

            // Lấy danh sách sản phẩm từ Application
            List<Objects.products> products = (List<Objects.products>)Application["listProducts"];
            string html = "";

            // Tạo HTML cho mỗi sản phẩm trong danh sách
            foreach (Objects.products product in products)
            {
                html +=
                    " <div class=\"box\">" +
                        "<div class=\"image\">" +
                            "<a href='ChiTietSP.aspx?id=" + product.id + "'>" +
                            "<img src=\"" + product.image + "\" alt=\"\">" +
                            "</a>" +
                            "<div class=\"icons\">" +
                                "<a href='ThemVaoYT.aspx?id=" + product.id + "' class=\"fas fa-heart\"></a>" +
                                "<a href='ThemVaoGH.aspx?id=" + product.id + "' class=\"cart-btn\">add to cart</a>" +
                            "</div>" +
                        "</div>" +
                        "<div class=\"content\">" +
                            "<h3>" + product.name + "</h3>" +
                            "<div class=\"price\">$" + product.price + "</div>" +
                        "</div>" +
                    "</div>";
            }

            // Gán HTML vừa tạo vào innerHTML của listProducts
            listProducts.InnerHtml = html;
        }
    }
}
