using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace WebBanHang
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            List<Objects.products> listProducts = new List<Objects.products>();
            listProducts.Add(new Objects.products("1", "Picture/image1.jpg", "Rosetta Stone", 1200));
            listProducts.Add(new Objects.products("2", "Picture/image2.jpg", "Terracotta Army", 1300));
            listProducts.Add(new Objects.products("3", "Picture/image3.jpg", "Violet", 2100));
            listProducts.Add(new Objects.products("4", "Picture/image4.jpg", "Dead Sea Scrolls", 1500));
            listProducts.Add(new Objects.products("5", "Picture/image5.jpg", "Antikythera Mechanism", 1600));
            listProducts.Add(new Objects.products("6", "Picture/image6.jpg", "Ming Dynasty Porcelain", 1500));
            listProducts.Add(new Objects.products("7", "Picture/image7.jpg", "Sutton Hoo Helmet", 1200));
            listProducts.Add(new Objects.products("8", "Picture/image8.jpg", "Lascaux Cave Paintings", 1200));
            listProducts.Add(new Objects.products("9", "Picture/image9.jpg", "Ming Dynasty Vase", 140000));
            listProducts.Add(new Objects.products("10", "Picture/image10.jpg", "Benin Bronzes", 180000));
            Application["listProducts"] = listProducts;



            List<Objects.User> listUser = new List<Objects.User>();
            listUser.Add(new Objects.User("0987654321", "Duong", "123456789"));
            listUser.Add(new Objects.User("0123456789", "Du", "123456789"));
            listUser.Add(new Objects.User("1", "Du Duong", "1"));
            Application["listUser"] = listUser;

            List<Objects.products> listSPMua = new List<Objects.products>();
            Application["listSPMua"] = listSPMua;

            List<Objects.products> listSPThich = new List<Objects.products>();
            Application["listSPThich"] = listSPThich;
        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}