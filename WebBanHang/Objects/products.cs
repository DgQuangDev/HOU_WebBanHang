using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebBanHang.Objects
{
    public class products
    {
        public string id { get; set; }

        public string image { get; set; }

        public string name { get; set; }
        public double price { get; set; }

        public products(string id, string image, string name, double price)
        {
            this.id = id;
            this.image = image;
            this.name = name;
            this.price = price;

        } 
    }
}