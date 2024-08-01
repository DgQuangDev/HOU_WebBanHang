function btnSignUp() {
    var name = document.getElementById("txtName").value.trim();
    var number = document.getElementById("txtnumber").value.trim();
    var password = document.getElementById("txtpassword").value.trim();

    var errname = document.getElementById("err-name");
    var errnumber = document.getElementById("err-number");
    var errpassword = document.getElementById("err-password");

    // Biến check để kiểm tra xem tất cả các trường hợp nhập liệu có hợp lệ hay không
    var check = true;
    var registerButton = document.getElementById("btn");
    // Kiểm tra trường tên
    if (name == "") {
        // Nếu tên rỗng, hiển thị thông báo lỗi và đặt biến check thành false
        errname.innerHTML = "Fill your username!";
        check = false;
        // Đặt con trỏ chuột vào trường nhập liệu tên
        document.getElementById("txtName").focus();
    } else {
        // Nếu tên không rỗng, xóa thông báo lỗi
        errname.innerHTML = "";
    }

    // Kiểm tra trường số điện thoại
    if (number.length < 6) {
        // Nếu số điện thoại rỗng, hiển thị thông báo lỗi và đặt biến check thành false
        errnumber.innerHTML = "phone toi thieu 6 ky tu";
        check = false;
        registerButton.style.display = "none";
        // Đặt con trỏ chuột vào trường nhập liệu số điện thoại
        document.getElementById("txtnumber").focus();
    } else {
        // Nếu số điện thoại hợp lệ, xóa thông báo lỗi
        errnumber.innerHTML = "";
    }

    // Kiểm tra trường mật khẩu
    if (password == "") {
        // Nếu mật khẩu rỗng, hiển thị thông báo lỗi và đặt biến check thành false
        errpassword.innerHTML = "Fill your password!";
        check = false;
        // Đặt con trỏ chuột vào trường nhập liệu mật khẩu
        document.getElementById("txtpassword").focus();
    }
    // Kiểm tra độ dài mật khẩu (ít nhất 6 ký tự)
    else if (password.length < 6) {
        // Nếu mật khẩu quá ngắn, hiển thị thông báo lỗi và đặt biến check thành false
        errpassword.innerHTML = "Password must be longer than 6 characters";
        check = false;
        // Đặt con trỏ chuột vào trường nhập liệu mật khẩu và xóa giá trị
        document.getElementById("txtpassword").focus();
        document.getElementById("txtpassword").value = null;
    } else {
        // Nếu mật khẩu hợp lệ, xóa thông báo lỗi
        errpassword.innerHTML = "";
    }

    // Kiểm tra lần cuối xem có bất kỳ lỗi nào không
    if (errnumber.innerHTML === "" && errname.innerHTML === "" && errpassword.innerHTML === "") {
        // Nếu không có lỗi, đặt biến check thành true
        check = true;
    } else {
        // Nếu có lỗi, đặt biến check thành false
        check = false;
    }

    // Trả về giá trị của biến check (true nếu tất cả các trường hợp nhập liệu hợp lệ, ngược lại false)
    return check;
}

//kiểm tra nut dang nhap
//Them 1 truong du lieu them chinh sua cac chuc nang
    //theo bao cao 