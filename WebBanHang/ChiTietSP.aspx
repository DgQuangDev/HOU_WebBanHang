<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ChiTietSP.aspx.cs" Inherits="WebBanHang.ChiTietSP" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.5.1/css/all.min.css">
    <link rel="stylesheet" href="CSS/ChiTiet.css">
    <title>Chi Tiết Sản Phẩm</title>
</head>
<body runat="server">
    <header>
        <input type="checkbox" name="" id="toggler">
        <label for="toggler" class="fas fa-bars"></label>

        <a href="TrangChu.aspx" class="logo">Classical art<span>.</span></a>

        <nav class="navbar">
            <a href="TrangChu.aspx">Home</a>
            <a href="TrangChu.aspx#about">About</a>
            <a href="TrangChu.aspx#products">Products</a>
            <a href="TrangChu.aspx#review">Review</a>
        </nav>

        <div class="icons" id="icons" runat="server">
            <a href="#" class="fas fa-heart"></a>
            <a href="GioHang.aspx" class="fas fa-shopping-cart"></a>
            <a href="#" class="fas fa-user"></a>
            
        </div>
    </header>

    <section class="details">
        <div class="box-container" id="idProduct" runat="server">
            <div class="box">
                <div class="image" runat="server" id="imageBox">
                    <img src="/Picture/image2.jpg" alt="">
                </div>
                <div class="content">
                    <div runat="server" id="nameBox">
                        <h3>flower pot</h3>
                    </div>
                    <div class="stars">
                        <i class="fas fa-star"></i>
                        <i class="fas fa-star"></i>
                        <i class="fas fa-star"></i>
                        <i class="fas fa-star"></i>
                        <i class="fas fa-star"></i>
                    </div>
                    <div runat="server" id="priceBox">
                        <div class="price">$12.99</div>
                    </div>
                    <div class="description">
                        erect flowers with long, broad, parallel-veined leaves and a cup-shaped<br />
                        single or double flower at the tip of the stem
                    </div>
                    <div id="addToCart" runat="server">
                        <a href="" class="btn">add to cart</a>
                    </div>
                    <p>Shipped within 2-3 days from placing order </p>
                </div>
            </div>
        </div>

    </section>
    <!-- footer section -->
    <section class="footer">
        <div class="box-container">
            <div class="box">
                <h3>quick links</h3>
                <a href="#">Home</a>
                <a href="#">about</a>
                <a href="#">products</a>
                <a href="#">review</a>
            </div>

            <div class="box">
                <h3>extra links</h3>
                <a href="#">my account</a>
                <a href="#">my order</a>
                <a href="#">my favorite</a>
            </div>

            <div class="box">
                <h3>locations </h3>
                <a href="#">Vietnam</a>
                <a href="#">USA</a>
                <a href="#">Germany</a>
            </div>

            <div class="box">
                <h3>contact info</h3>
                <a href="#">+74 123-321-345</a>
                <a href="#">Classical art@gmail.com</a>
                <a href="#">Hanoi, Vietnam - 12312</a>
            </div>
        </div>

        <div class="credit">created by <span>Du Duong</span></div>
    </section>
</body>
</html>
