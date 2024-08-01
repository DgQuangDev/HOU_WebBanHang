<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DangKy.aspx.cs" Inherits="WebBanHang.DangKy" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.5.1/css/all.min.css" />
    <link rel="stylesheet" href="CSS/TrangChu.css" />
    <link rel="stylesheet" href="CSS/DangKy.css" />
    <title>Đăng Ký</title>
</head>
<body runat="server">
    <section class="body" id="">
    <div class="container">
        <form id="RegisterForm" method="post" runat="server" onsubmit="return btnSignUp();">
            <div class="form-contents">
                <div class="signup-form">
                    <div class="title">Sign Up</div>
                    <div class="input-boxes">
                        <div class="input-box">
                            <i class="fas fa-user"></i>
                            <input id="txtName" name="txtName" type="text" placeholder="Enter your name" runat="server" />
                        </div>
                        <div id="err-name" style="font-size: 1.5rem; color: red;"></div>
                        <div class="input-box">
                            <i class="fas fa-phone"></i>
                            <input id="txtnumber" name="txtnumber" type="text" placeholder="Enter your number" runat="server" />
                        </div>
                        <div id="err-number" style="font-size: 1.5rem; color: red;"></div>
                        <div class="input-box">
                            <i class="fas fa-lock"></i>
                            <input id="txtpassword" name="txtpassword" type="password" placeholder="Enter your password" runat="server" />
                        </div>
                        <div id="err-password" style="font-size: 1.5rem; color: red;"></div>

                        <div id="error" style="font-size: 1.5rem; color: red;" runat="server"></div>
                        <div class="button input-box">
                            <asp:Button id="btn" runat="server" Text="SIGN UP" OnClick="btnRegister_onClick" />
                        </div>
                        <div class="text">Already have an account?<a href="DangNhap.aspx"> LogIn Now </a></div>
                    </div>
                </div>
            </div>
        </form>
    </div>
</section>
    <script src="JavaScript/DangKy.js"></script>
</body>
</html>
