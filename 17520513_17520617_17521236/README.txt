- Lớp: SE100.K11
- Giảng viên hướng dẫn:  Th.S Huỳnh Nguyễn Khắc Huy
- Đồ án Quản lý học sinh THPT
- Thông tin nhóm: 
	+Nguyễn Lê Việt Hoàng 17520513
	+Nguyễn Quang Khang 17520617
	+Nguyễn Mạnh Tùng 17521236
	
- Cách cài đặt chương trình: <có trong thư mục Setup>
	Bước 1: Cài đặt phần mềm
	+ Chạy file CaiDat_QLHS.msi để cài đặt phần mềm

	Bước 2: Kết nối Database
	+ Truy cập vào thư mục vừa cài đặt, sau đó copy đường dẫn của file QLHS.sql
	
	Ví dụ: C:\Program Files (x86)\PhanMemQuanLyHocSinh\QLHS.sql
	
	+ Mở cmd của máy, chạy dòng lệnh:
	
	 sqlcmd -E -S (local) -i "<đường dẫn file QLHS.sql của bạn>"
	 
	 Ví dụ: sqlcmd -E -S (local) -i "C:\Program Files (x86)\PhanMemQuanLyHocSinh\QLHS.sql"

	- Chú ý: đường dẫn file phải đặt trong ngoặc kép: "<đường dẫn file sql>"

	Bước 3: Chạy phần mềm
	+ Truy cập vào thư mục vừa cài đặt, chạy file NMCNPM_QLHS.exe với 
		Tài khoản: admin  
        Mật khẩu: admin


