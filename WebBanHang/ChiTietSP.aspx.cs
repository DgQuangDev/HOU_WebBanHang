using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace WebBanHang
{
    public partial class ChiTietSP : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((string)Session["username"] == null)
            {
                var str = "<div class=\"icons\" id=\"icons\" runat=\"server\">\r\n  " +
                    "<a href=\"#\" class=\"fas fa-heart\"></a>\r\n  " +
                    " <a href=\"GioHang.html\" class=\"fas fa-shopping-cart\"></a>\r\n   " +
                    " <a href=\"DangNhap.html\" class=\"fas fa-user\"></a>\r\n";
                icons.InnerHtml = str;

            }

            else
            {
                /*var str = "<a>" + (string)Session["username"] + "</a>";

                username.InnerHtml = str;*/

                var str = "<div class=\"icons\" id=\"icons\" runat=\"server\">\r\n  " +
                    "<a href=\"#\" class=\"fas fa-heart\"></a>\r\n  " +
                    "<a href=\"GioHang.html\" class=\"fas fa-shopping-cart\"></a>\r\n   " +
                    "<a href=\"\" class=\"fas fa-user\"></a>\r\n" +
                    "<a>" + (string)Session["username"] + "</a>" +
                    "<a href=\"DangXuat.html\" class=\"fas fa-sign-out\"></a>";
                icons.InnerHtml = str;
            }

            List<Objects.products> products = (List<Objects.products>)Application["listProducts"];
            string img = "";
            string name = "";
            string price = "";
            string id = "";

            foreach (Objects.products product in products)
            {
                if (Request.QueryString["id"] == product.id)
                {
                    img += "<img src='" + product.image + "' >";
                    name += "<h3>" + product.name + "</h3>";
                    price += "<div class='price'>$" + product.price + " </div>";
                    id += "<a href = 'ThemVaoGH.html?id=" + product.id + "' class=\"btn\"> add to cart </a>";
                    break;
                }
            }
            if (img != "")
            {
                imageBox.InnerHtml = img;
                nameBox.InnerHtml = name;
                priceBox.InnerHtml = price;
                addToCart.InnerHtml = id;
            }
        }
    }
}