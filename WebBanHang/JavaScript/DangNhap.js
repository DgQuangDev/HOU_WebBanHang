function btnLogin() {
    // Lấy giá trị từ các trường nhập liệu và loại bỏ khoảng trắng
    var phone = document.getElementById("txtnumber").value.trim();
    var pass = document.getElementById("txtpassword").value.trim();

    // Lấy các phần tử HTML hiển thị lỗi
    var errornumber = document.getElementById("err-number");
    var errorpassword = document.getElementById("err-password");

    // Khởi tạo biến kiểm tra
    var check = true;
    var registerButton = document.getElementById("btnSignIn");

    // Kiểm tra nếu cả số điện thoại và mật khẩu đều trống
    if (phone == "" && pass == "") {
        errornumber.innerHTML = "Fill your phone number!";
        errorpassword.innerHTML = "Fill your password!";
        document.getElementById("txtnumber").focus();
        check = false;
    }

    // Kiểm tra nếu số điện thoại trống
    if (phone == "") {
        errornumber.innerHTML = "Fill your phone number!";
        document.getElementById("txtnumber").focus();
        check = false;
    } else if (phone.length < 6) {
        // Nếu định dạng sai, hiển thị thông báo lỗi và đặt biến check thành false
        errnumber.innerHTML = "Phone toi thieu 6 chu so";
        check = false;
        // Đặt con trỏ chuột vào trường nhập liệu số điện thoại và xóa giá trị
        document.getElementById("txtnumber").focus();
        document.getElementById("txtnumber").value = null;
        registerButton.style.display = "none";
    } else {
        // Nếu số điện thoại hợp lệ, xóa thông báo lỗi
        errnumber.innerHTML = "";
    }

    // Kiểm tra nếu mật khẩu trống
    if (pass == "") {
        errorpassword.innerHTML = "Fill your password!";
        document.getElementById("txtpassword").focus();
        check = false;
    } else {
        errorpassword.innerHTML = ""; // Xóa thông báo lỗi nếu có
    }

    // Trả về giá trị kiểm tra tính hợp lệ
    return check;
}
