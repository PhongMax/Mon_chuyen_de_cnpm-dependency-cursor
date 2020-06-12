# CHỨNG KHOÁN | SQL DEPENDENCY CURSOR

Đồ án kết thúc môn Chuyên đề Công Nghệ Phần mềm D16CQCP01-N 

# Demo
<a href="#">xxx</a>

## Thành viên
| Họ & Tên  | MSSV| Lớp|
| ------------- | ------------- |----------|
| Nguyễn Thanh Phong    | N16DCCN116  |D16CQCP01|
| Vũ Đăng Khoa   | N16DCCN078  |D16CQCP01|
-----------------------------------------------
### Giảng viên hướng dẫn
>>**Thầy Lưu Nguyễn Kỳ Thư**
-----------------------------------------------
### Sử dụng: 
 - .Net Framework version 4.5.2
 -  SQL Server (Trigger, Sql agent Job, Cursor, Dependency SQL, )
-----------------------------------------------

### Yêu cầu 
Cho cơ sở dữ liệu CHUNGKHOAN có các tables:

a/ LENHDAT: chứa các lệnh đặt mua/bán cổ phiếu của các nhà đầu tư
![1](https://user-images.githubusercontent.com/34712060/84478911-49310580-acbc-11ea-8fbb-049c03061218.PNG)
 
b/LENHKHOP: chứa các lệnh khớp khi thỏa qui tắc khớp lệnh

![2](https://user-images.githubusercontent.com/34712060/84478923-4cc48c80-acbc-11ea-9f32-1131aef45654.PNG)
		 
Yêu cầu:
 - Tạo Form cho phép nhà đầu tư nhập lệnh đặt mua / bán cổ phiếu. Viết SP tính số lượng cổ phiếu khớp theo thuật toán khớp lệnh liên tục khi có 1 lệnh mua hoặc bán được gởi đến bảng LENHDAT.   
 - Sử dụng dịch vụ SQL Broker, class SQL Dependency để trả về Bảng giá trực tuyến từ CSDL chuyển về các máy của các nhà đầu tư tức thời khi có sự thay đổi . 
Bảng giá trực tuyến có dạng sau:
![3](https://user-images.githubusercontent.com/34712060/84478927-4df5b980-acbc-11ea-9a73-a5c5384ea566.PNG)

Trong cột Dư mua : sẽ 	lưu tổng khối lượng của 2 giá mua tốt nhất
Cột khớp lệnh : thể hiện giá khớp, khối lượng khớp mới nhất(thèn nào mớ bỏ vào lênh khớp là thèn đó mới nhất thôi, khỏi cần sắp xếp )
Trong cột Dư bán : sẽ lưu tổng khối lượng của 2 giá bán tốt nhất.
(chú ý : bảng giá trực tuyến tự động reset data theo ngày)


-----------------------------------------------
## Giao diện
![4](https://user-images.githubusercontent.com/34712060/84478934-4fbf7d00-acbc-11ea-946b-7d3c323e95e5.PNG)
