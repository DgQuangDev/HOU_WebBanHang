using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace WebBanHang
{
    public partial class GioHang : System.Web.UI.Page
    {
        List<Objects.products> cart;
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((string)Session["username"] == null)
            {
                /*var str = "<div class=\"icons\" id=\"icons\" runat=\"server\">\r\n  " +
                    "<a href=\"#\" class=\"fas fa-heart\"></a>\r\n  " +
                    " <a href=\"GioHang.aspx\" class=\"fas fa-shopping-cart\"></a>\r\n   " +
                    " <a href=\"DangNhap.aspx\" class=\"fas fa-user\"></a>\r\n";
                icons.InnerHtml = str;*/
                Response.Redirect("DangNhap.aspx");

            }

            else
            {
                /*var str = "<a>" + (string)Session["username"] + "</a>";

                username.InnerHtml = str;*/

                var str = "<div class=\"icons\" id=\"icons\" runat=\"server\">\r\n  " +
                    "<a href=\"YeuThich.aspx\" class=\"fas fa-heart\"></a>\r\n  " +
                    "<a href=\"GioHang.aspx\" class=\"fas fa-shopping-cart\"></a>\r\n   " +
                    "<a href=\"\" class=\"fas fa-user\"></a>\r\n" +
                    "<a>" + (string)Session["username"] + "</a>" +
                    "<a href=\"DangXuat.aspx\" class=\"fas fa-sign-out\"></a>";
                icons.InnerHtml = str;


                cart = (List<Objects.products>)Application["listSPMua"];


                string html = "";
                double subTotal = 0;

                html +=
                    "<div class='product__title'>"
                        + "<span class='product__title--name'>Product</span>"
                        + "<span class='product__title--price'>Price</span>"
                        + "<span class='product__title--quantity'>Quantity</span>"
                        + "<span class='product__title--total'>Total</span>"
                    + "</div>";

                for (int i = 0; i < cart.Count; i++)
                {



                    double total = cart[i].price;
                    subTotal += total;

                    html +=
                    "<div class='product' id='cartBlock' runat='server'>"
                        + "<div class='shoppingCart__detail image'>"
                            + "<img src = '" + cart[i].image + "' alt=''>"
                        + "</div>"
                        + "<div class='shoppingCart__detail name'>"
                            + "<span>" + cart[i].name + "</span>"
                        + "</div>"

                        + "<div class='shoppingCart__detail price' >"
                            + "<span id='price'>$" + cart[i].price + " </span>"
                        + "</div>"
                        + "<div class='shoppingCart__detail quantity'>"
                            + "<input type = 'number' min='1' value='1' id='quantity' runat='server'onkeyup='changeTotal()' onchange='changeTotal()'>"
                        + "</div>"
                        + "<div class='shoppingCart__detail total'>"
                            + "<span id='total'>$" + total + "</span>"
                        + "</div>"
                        + "<div class='shoppingCart__detail remove'>"
                            + "<a href='XoaGioHang.aspx?idRemove=" + cart[i].id + "'><i class='fa-solid fa-xmark'></i></a>"
                        + "</div>"
                    + "</div>";

                }
                subTotalBox.InnerHtml = "$" + subTotal;
                shoppingCart.InnerHtml = html;
            }
        }
    }
}