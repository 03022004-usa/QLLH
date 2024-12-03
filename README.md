Hướng dẫn cài đặt
Để sử dụng hệ thống, cần đảm bảo các yêu cầu về môi trường và thư viện hỗ trợ:
•	Cài đặt môi trường chạy ứng dụng C#: Cần có Visual Studio 2022 (bản Community hoặc cao hơn).
•	Thư viện và công cụ bổ sung:
+ Microsoft .NET Framework 4.8 hoặc phiên bản mới hơn (thường được tích hợp sẵn trong Visual Studio).
+ SQL Server Management Studio (SSMS) hoặc công cụ tương tự để trực quan hóa cơ sở dữ liệu.
NuGet Packages: Một số thư viện hỗ trợ như System.Data.SqlClient, Dapper (tùy chọn nếu muốn tối ưu hóa truy vấn cơ sở dữ liệu).

	Đối tượng, phạm vi sử dụng
-  Đối tượng sử dụng:
•	Giáo viên, nhân viên quản lý trường học.
•	Học sinh cần xem lịch học và nhận thông báo.
-  Phạm vi sử dụng:
•	Hệ thống hỗ trợ quản lý và cập nhật lịch học, gửi thông báo đến học sinh tại các trường học, trung tâm đào tạo

Xác định các yêu cầu cài đặt
-  Phần mềm cần thiết:
•	Visual Studio 2022.
•	SQL Server (Express hoặc cao hơn).
•	Thư viện kết nối System.Data.SqlClient và các thư viện cần thiết khác (thêm thông qua NuGet).
-  Hệ điều hành:
•	Windows 10 hoặc cao hơn.
-  Yêu cầu phần cứng:
•	Bộ xử lý: Intel Core i3 hoặc tương đương.
•	RAM: 4GB (khuyến nghị 8GB).
•	Dung lượng ổ cứng: Ít nhất 500MB trống cho ứng dụng và cơ sở dữ liệu

Hướng dẫn chi tiết các bước cài đặt
-  Cài đặt Visual Studio 2022:
•	Tải và cài đặt Visual Studio 2022 từ trang chủ Microsoft Visual Studio.
•	Trong quá trình cài đặt, chọn "Phát triển ứng dụng trên Desktop với .NET" (Desktop Development with .NET).
-  Cài đặt SQL Server:
•	Tải SQL Server từ Microsoft SQL Server.
•	Sử dụng SQL Server Management Studio (SSMS) để quản lý cơ sở dữ liệu.
-  Tạo cơ sở dữ liệu:
•	Tạo một cơ sở dữ liệu mới (ví dụ: SchoolManagement) trong SQL Server.
•	Import file SQL mẫu trong thư mục database để tạo các bảng và dữ liệu ban đầu.
-  Thêm các thư viện bổ sung:
•	Trong Visual Studio, mở NuGet Package Manager (Tools > NuGet Package Manager > Manage NuGet Packages for Solution) và cài đặt các thư viện:
o	System.Data.SqlClient (kết nối cơ sở dữ liệu).
o	Dapper (tùy chọn để đơn giản hóa truy vấn SQL).
- Chạy ứng dụng:
•	Mở dự án trong Visual Studio 2022, build và chạy ứng dụng bằng cách nhấn Ctrl + F5

Hướng dẫn sử dụng phần mềm
- Phần mềm dùng để quản lý lịch học và gửi thông báo đến học sinh. Phần mềm có 4 chức năng chính là quản lý lịch học, quản lý thông báo, quản lý học sinh và quản lý giáo viên.
- Các chức năng quản lý lịch học, thông báo, học sinh và giáo viên đều bao gồm các chức năng con như thêm, sửa, xóa, và tìm kiếm thông tin. Riêng chức năng quản lý thông báo không có chức năng sửa để đảm bảo tính chính xác và toàn vẹn của thông tin đã gửi.
- Để sử dụng chức năng nào, người dùng chỉ cần nhấn trực tiếp vào chức năng đó trong giao diện chính và thực hiện các thao tác mong muốn.
