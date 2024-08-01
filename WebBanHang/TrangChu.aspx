<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TrangChu.aspx.cs" Inherits="WebBanHang.TrangChu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Classical art Shop</title>
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.5.1/css/all.min.css">
    <link rel="stylesheet" href="CSS/TrangChu.css">
</head>
<body runat="server">
    <header>
        
        <input type="checkbox" name="" id="toggler">
        <label for="toggler" class="fas fa-bars"></label>

        <a href="#" class="logo">Classical art<span>.</span></a>

        <nav class="navbar">
            <a href="#home">Home</a>
            <a href="#about">About</a>
            <a href="#products">Products</a>
            <a href="#review">Review</a>
        </nav>

        <div class="icons" id="icons" runat="server">
            <a href="YeuThich.aspx" class="fas fa-heart"></a>
            <a href="GioHang.aspx" class="fas fa-shopping-cart"></a>
            <a href="#" class="fas fa-user"></a>
            
        </div>
    </header>
    <!-- home section -->
    <section class="home" id="home">
        <div class="content">
            <h3>30% Save</h3>
            <span>Special Ancient Art </span>
            <br>
            <a href="#products" class="btn">Shop now</a>
        </div>
    </section>

    <!-- about section -->
    <section class="about" id="about">
        <h1 class="heading"><span>about</span> us </h1>

        <div class="row">
            <div class="video-container">
                <video src="/Picture/6722179-uhd_3840_2160_25fps.mp4" loop autoplay muted></video>

            </div>
            <div class="content">
                <h3>why choose us?</h3>
                <p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Quas adipisci facere recusandae quis voluptas, sed autem at placeat voluptatum, repellendus, fuga aperiam corporis reprehenderit optio. Labore debitis nihil modi sint.</p>
                <p>Lorem ipsum dolor sit amet consectetur, adipisicing elit. Harum inventore nobis ipsum? Necessitatibus, fuga quasi reprehenderit, vero possimus est, alias quis quo eveniet quaerat harum eos quibusdam dolorum facilis dolore.</p>
                <a href="#" class="btn">learn more</a>
            </div>
        </div>
    </section>

    <!-- products section -->
    <section class="products" id="products">
        <h1 class="heading">lastest <span>products</span></h1>
        <div class="box-container" id="listProducts" runat="server">

            <%--<div class="box">
                <div class="image">
                    <a href='ChiTietSP.aspx?id=2'></a>
                    <img src="/Picture/image1.jpg" alt=""/>
                    <div class="icons">
                        <a href="#" class="fas fa-heart"></a>
                        <a href="#" class="cart-btn">add to cart</a>
                        <a href="#" class="fas fa-share"></a>
                    </div>
                </div>
                <div class="content">
                    <h3>flower pot</h3>
                    <div class="price">$12.99</div>
                </div>
            </div>--%>

        </div>
    </section>

    <!-- review section starts -->
    <section class="review" id="review">
        <h1 class="heading">customer's <span>review</span></h1>
        <div class="box-container">
            <div class="box">
                <div class="stars">
                    <i class="fas fa-star"></i>
                    <i class="fas fa-star"></i>
                    <i class="fas fa-star"></i>
                    <i class="fas fa-star"></i>
                    <i class="fas fa-star"></i>
                </div>
                <p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Cum natus ipsum dicta vero! Ipsa voluptatem commodi libero quos tempore animi voluptates magni optio officiis laboriosam amet, sed nesciunt laborum doloremque.</p>
                <div class="user">
                    <img src="/Picture/review1.jpg" alt="" width="100px">
                    <div class="user-info">
                        <h3>kellie</h3>
                        <span>happy customer</span>
                    </div>
                </div>
                <span class="fas fa-quote-right"></span>
            </div>
            <div class="box">
                <div class="stars">
                    <i class="fas fa-star"></i>
                    <i class="fas fa-star"></i>
                    <i class="fas fa-star"></i>
                    <i class="fas fa-star"></i>
                    <i class="fas fa-star"></i>
                </div>
                <p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Cum natus ipsum dicta vero! Ipsa voluptatem commodi libero quos tempore animi voluptates magni optio officiis laboriosam amet, sed nesciunt laborum doloremque.</p>
                <div class="user">
                    <img src="/Picture/review2.jpg" alt="" width="100px">
                    <div class="user-info">
                        <h3>kellie</h3>
                        <span>happy customer</span>
                    </div>
                </div>
                <span class="fas fa-quote-right"></span>
            </div>
            <div class="box">
                <div class="stars">
                    <i class="fas fa-star"></i>
                    <i class="fas fa-star"></i>
                    <i class="fas fa-star"></i>
                    <i class="fas fa-star"></i>
                    <i class="fas fa-star"></i>
                </div>
                <p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Cum natus ipsum dicta vero! Ipsa voluptatem commodi libero quos tempore animi voluptates magni optio officiis laboriosam amet, sed nesciunt laborum doloremque.</p>
                <div class="user">
                    <img src="/Picture/review3.jpg" alt="" width="100px">
                    <div class="user-info">
                        <h3>kellie</h3>
                        <span>happy customer</span>
                    </div>
                </div>
                <span class="fas fa-quote-right"></span>
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

