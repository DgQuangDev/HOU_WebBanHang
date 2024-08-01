using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebBanHang
{
    public partial class XoaYeuThich : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Lấy danh sách các sản phẩm trong giỏ hàng từ biến ứng dụng "listSPMua" và gán nó cho biến 'cart'.
            List<Objects.products> cart = (List<Objects.products>)Application["listSPThich"];

            // Lấy giá trị tham số truy vấn "idRemove" từ URL và gán nó cho biến 'idCart'.
            string idCart = Request.QueryString["idRemove"];

            // Duyệt qua từng sản phẩm trong danh sách giỏ hàng 'cart' (tạo một bản sao của danh sách để tránh sửa đổi khi duyệt).
            foreach (Objects.products i in cart.ToList())
            {
                // Nếu id của sản phẩm trùng với 'idCart' cần xóa.
                if (idCart == i.id)
                {
                    // Xóa sản phẩm đó khỏi danh sách giỏ hàng 'cart'.
                    cart.Remove(i);
                }
            }

            // Cập nhật lại biến ứng dụng "listSPMua" với danh sách giỏ hàng đã thay đổi.
            Application["listSPThich"] = cart;

            // Chuyển hướng người dùng đến trang "GioHang.aspx".
            Response.Redirect("YeuThich.aspx");
        }
    }
}