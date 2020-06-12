# CHỨNG KHOÁN | SQL DEPENDENCY CURSOR

Đồ án kết thúc môn Chuyên đề Công Nghệ Phần mềm D16CQCP01-N 

# Demo
<a href="https://www.youtube.com/watch?v=816nt2xopvM">Xem video tại đây!!!</a>

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
FieldName	Type	Description
ID	int	Mã số lệnh đặt
MACP	char(7)	Mã cổ phiếu
NGAYDAT	datetime	Unchecked
LOAIGD	nchar(1)	Loại giao dịch : 
	M : lệnh mua
	B  : lệnh bán
LOAILENH	nchar(10)	Loại lệnh : 
	LO : khớp lệnh liên tục
	ATO, ATC : khớp lệnh định kỳ 
SOLUONG	int	Số lượng đặt
GIADAT	float	Giá đặt
TRANGTHAILENH	nvarchar(30)	Trạng thái lệnh :
	Chờ khớp
	Khớp lệnh 1 phần
	Khớp hết
	Đã hủy
	Chưa khớp
		 
 
b/LENHKHOP: chứa các lệnh khớp khi thỏa qui tắc khớp lệnh

FieldName	Type	Description
IDKHOP	int	Mã số lệnh khớp
NGAYKHOP	datetime	
SOLUONGKHOP	int	
GIAKHOP	float	
IDLENHDAT	int	Mã số lệnh đặt
		 
3.1. Tạo Form cho phép nhà đầu tư nhập lệnh đặt mua / bán cổ phiếu. Viết SP tính số lượng cổ phiếu khớp theo thuật toán khớp lệnh liên tục khi có 1 lệnh mua hoặc bán được gởi đến bảng LENHDAT.   

3.2. Sử dụng dịch vụ SQL Broker, class SQL Dependency để trả về Bảng giá trực tuyến từ CSDL chuyển về các máy của các nhà đầu tư tức thời khi có sự thay đổi . 
Bảng giá trực tuyến có dạng sau:
 
MACP	DƯ MUA		KHỚP LỆNH	DƯ BÁN
	Giá 2	KL 2	Giá 1	KL 1	Giá khớp	KL khớp	Giá 1	KL 1	Giá 2	KL 2

Trong cột Dư mua : sẽ 	lưu tổng khối lượng của 2 giá mua tốt nhất
Cột khớp lệnh : thể hiện giá khớp, khối lượng khớp mới nhất(thèn nào mớ bỏ vào lênh khớp là thèn đó mới nhất thôi, khỏi cần sắp xếp )
Trong cột Dư bán : sẽ lưu tổng khối lượng của 2 giá bán tốt nhất.
