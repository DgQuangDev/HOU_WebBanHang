function changeTotal() {
    // Lấy phần tử kích hoạt sự kiện (ô nhập số lượng) và gán nó cho biến Quantity
    let Quantity = event.target;

    // Lấy phần tử chứa tổng tiền của sản phẩm bằng cách lấy anh em kế tiếp của phần tử cha của Quantity
    let sTotal = event.target.parentElement.nextSibling;

    // Lấy giá của sản phẩm bằng cách lấy giá trị văn bản của phần tử anh em trước của phần tử cha của Quantity
    let sPrice = event.target.parentElement.previousElementSibling.innerText;

    // Lấy phần tử chứa tổng tiền tất cả các sản phẩm
    let ssubTotal = document.getElementById("subTotalBox");

    // Tách giá trị tổng tiền hiện tại (của tất cả sản phẩm) thành mảng bằng ký tự '$'
    let SubTotal = ssubTotal.innerHTML.split("$");

    // Tách giá trị tổng tiền hiện tại của sản phẩm thành mảng bằng ký tự '$'
    let Total = sTotal.innerText.split("$");

    // Tách giá trị giá của sản phẩm thành mảng bằng ký tự '$'
    let Price = sPrice.split("$");

    // Tính tổng tiền mới của sản phẩm bằng cách nhân số lượng mới với giá sản phẩm và chuyển đổi thành số thực
    let output = parseFloat(parseFloat(Quantity.value) * parseFloat(Price[1]));

    // Tính tổng tiền mới của tất cả sản phẩm bằng cách thêm sự thay đổi trong tổng tiền của sản phẩm hiện tại vào tổng tiền hiện tại
    let NewSubTotal = parseFloat(SubTotal[1]) + (output - parseFloat(Total[1]));

    // Cập nhật giá trị tổng tiền mới của sản phẩm trong DOM
    sTotal.innerHTML = "$" + output;

    // Cập nhật giá trị tổng tiền mới của tất cả sản phẩm trong DOM
    ssubTotal.innerHTML = "$" + NewSubTotal;
}
