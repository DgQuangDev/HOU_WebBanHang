﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GioHang.aspx.cs" Inherits="WebBanHang.GioHang" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.5.1/css/all.min.css">
    <link rel="stylesheet" href="CSS/GioHang.css">
    <title>Giỏ Hàng</title>
</head>
<body>
        <header>
        <input type="checkbox" name="" id="toggler">
        <label for="toggler" class="fas fa-bars"></label>
        
        <a href="TrangChu.aspx" class="logo">Classical art<span>.</span></a>

        <nav class="navbar">
            <a href="TrangChu.aspx">Home</a>
            <a href="TrangChu.aspx">About</a>
            <a href="TrangChu.aspx">Products</a>
            <a href="TrangChu.aspx">Review</a>
        </nav>

        <div class="icons" id="icons" runat="server">
            <a href="#YeuThich.aspx" class="fas fa-heart"></a>
            <a href="GioHang.aspx" class="fas fa-shopping-cart"></a>
            <a href="#" class="fas fa-user"></a>
        </div>
   </header> 

   <section>
    <div class="container">
        <div class="shoppingCart" id="shoppingCart" runat="server">
            <div class="product__title">
                <span class="product__title--name">Product</span>
                <span class="product__title--price">Price</span>
                <span class="product__title--quantity">Quantity</span>
                <span class="product__title--total">Total</span>
            </div>
    
            <div class="product" id="cartBlock" runat="server">
                <div class="shoppingCart__detail image">
                    <img src="Picture/image8.jpg" alt="">
                </div>
                <div class="shoppingCart__detail name">
                    <h3>Carnation</h3>
                </div>
                <div class="shoppingCart__detail price">
                    <span id="price">$12.89</span>
                </div>
                <div class="shoppingCart__detail quantity" >
                   <input type="number" min="1" value="1" id="quantity" onkeyup="changeTotal()" onchange="changeTotal()">
                </div>
                <div class="shoppingCart__detail total">
                    <span id="total">$38.67</span>
                </div>
                <div class="shoppingCart__detail remove">
                    <a href="#"><i class="fa-solid fa-xmark"></i></a>
                </div>
            </div>
    
            
        </div>
        
        <div class="order">
            <div class="checkout">
                <div class="checkout__subtotal">
                    <span>SUBTOTAL: </span>
                    <span id="subTotalBox" runat="server">$89.95</span>
                </div>
                <div class="checkout__extra">
                    Ships on or around April 20, 2024
                </div>
                <div class="btn">
                    <a href="BtnBuy.aspx">CHECK OUT</a>
                </div>
            </div>
        </div>
    </div>
   </section>

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

    <div class="credit"> created by <span> DuDuong</span></div>
</section>
    <script src="JavaScript/GioHang.js"></script>
</body>
</html>
