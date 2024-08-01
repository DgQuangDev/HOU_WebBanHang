using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebBanHang
{
    public partial class ThemVaoYT : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((string)Session["username"] != null)
            {
                List<Objects.products> productSell = (List<Objects.products>)Application["listSPThich"];
                List<Objects.products> products = (List<Objects.products>)Application["listProducts"]; ;

                foreach (Objects.products product in products)
                {
                    if (Request.QueryString["id"] == product.id)
                    {
                        productSell.Add(product);
                    }
                }

                Application["listSPThich"] = productSell;
                Response.Redirect("YeuThich.aspx");
            }
            else
            {
                Response.Redirect("DangNhap.aspx");
            }

        }
    }
}