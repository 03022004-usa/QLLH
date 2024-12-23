USE [QL_LichHoc]
GO
/****** Object:  Table [dbo].[BAITAP]    Script Date: 11/29/2024 12:33:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BAITAP](
	[MaBaiTap] [nvarchar](50) NOT NULL,
	[TenBT] [nvarchar](255) NULL,
	[NgayDuocGiao] [datetime] NULL,
	[HanNop] [datetime] NULL,
	[TrangThai] [nvarchar](50) NULL,
	[MaGV] [nvarchar](50) NULL,
	[MoTa] [nvarchar](255) NULL,
 CONSTRAINT [PK__BAITAP__3AF6A9151B64CCF8] PRIMARY KEY CLUSTERED 
(
	[MaBaiTap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GIAOVIEN]    Script Date: 11/29/2024 12:33:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GIAOVIEN](
	[MaGV] [nvarchar](50) NOT NULL,
	[HoTen] [nvarchar](100) NULL,
	[Email] [nvarchar](100) NULL,
	[PhongBan] [nvarchar](100) NULL,
 CONSTRAINT [PK__GIAOVIEN__2725AEF3FF92FF99] PRIMARY KEY CLUSTERED 
(
	[MaGV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HOC]    Script Date: 11/29/2024 12:33:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HOC](
	[MaHS] [nvarchar](50) NOT NULL,
	[MaLichHoc] [int] NOT NULL,
 CONSTRAINT [PK__HOC__B480147567D52C87] PRIMARY KEY CLUSTERED 
(
	[MaHS] ASC,
	[MaLichHoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HOCSINH]    Script Date: 11/29/2024 12:33:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HOCSINH](
	[MaHS] [nvarchar](50) NOT NULL,
	[HoTen] [nvarchar](100) NULL,
	[GioiTinh] [nvarchar](10) NULL,
	[NoiSinh] [nvarchar](100) NULL,
	[TrangThai] [nvarchar](50) NULL,
	[Nghi] [nvarchar](50) NULL,
	[Email] [nvarchar](100) NULL,
	[Lop] [nvarchar](50) NULL,
 CONSTRAINT [PK__HOCSINH__2725A6EF97048183] PRIMARY KEY CLUSTERED 
(
	[MaHS] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LAMVANOPBAITAP]    Script Date: 11/29/2024 12:33:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LAMVANOPBAITAP](
	[MaHS] [nvarchar](50) NOT NULL,
	[MaBaiTap] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK__LAMVANOP__648ACC7E6B182CC5] PRIMARY KEY CLUSTERED 
(
	[MaHS] ASC,
	[MaBaiTap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LICHHOC]    Script Date: 11/29/2024 12:33:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LICHHOC](
	[MaLichHoc] [nvarchar](50) NOT NULL,
	[TuanHoc] [nvarchar](50) NULL,
	[NamHoc] [nvarchar](50) NULL,
	[ThoiGianBatDau] [datetime] NULL,
	[ThoiGianKetThuc] [datetime] NULL,
	[PhongHoc] [nvarchar](100) NULL,
	[Mon] [nvarchar](max) NULL,
 CONSTRAINT [PK__LICHHOC__150EBC2164A85502] PRIMARY KEY CLUSTERED 
(
	[MaLichHoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LOPHOC]    Script Date: 11/29/2024 12:33:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOPHOC](
	[MaLop] [nvarchar](50) NOT NULL,
	[TenLop] [nvarchar](100) NULL,
	[PhongHoc] [nvarchar](100) NULL,
 CONSTRAINT [PK__LOPHOC__3B98D273003F135F] PRIMARY KEY CLUSTERED 
(
	[MaLop] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MONHOC]    Script Date: 11/29/2024 12:33:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MONHOC](
	[MaMon] [int] NOT NULL,
	[TenMon] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaMon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NHAN]    Script Date: 11/29/2024 12:33:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHAN](
	[MaHS] [nvarchar](50) NOT NULL,
	[MaThongBao] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK__NHAN__D7684DBBCD87484A] PRIMARY KEY CLUSTERED 
(
	[MaHS] ASC,
	[MaThongBao] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PHUTRACH]    Script Date: 11/29/2024 12:33:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHUTRACH](
	[MaGV] [nvarchar](50) NOT NULL,
	[MaMon] [int] NOT NULL,
 CONSTRAINT [PK__PHUTRACH__B4801C695107B5E7] PRIMARY KEY CLUSTERED 
(
	[MaGV] ASC,
	[MaMon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[THONGBAO]    Script Date: 11/29/2024 12:33:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[THONGBAO](
	[MaThongBao] [nvarchar](50) NOT NULL,
	[NoiDung] [nvarchar](255) NULL,
	[NgayGui] [datetime] NULL,
	[LoaiThongBao] [nvarchar](50) NULL,
	[MaGV] [nvarchar](50) NULL,
 CONSTRAINT [PK__THONGBAO__04DEB54E9A1B4F15] PRIMARY KEY CLUSTERED 
(
	[MaThongBao] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[THUOC]    Script Date: 11/29/2024 12:33:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[THUOC](
	[MaMon] [nvarchar](50) NOT NULL,
	[MaLichHoc] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaMon] ASC,
	[MaLichHoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 11/29/2024 12:33:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[TenDangNhap] [varchar](50) NOT NULL,
	[MK] [varchar](50) NOT NULL,
	[VaiTro] [varchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[XEM]    Script Date: 11/29/2024 12:33:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[XEM](
	[MaHS] [nvarchar](50) NOT NULL,
	[MaLichHoc] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK__XEM__26754D2D74E18408] PRIMARY KEY CLUSTERED 
(
	[MaHS] ASC,
	[MaLichHoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[BAITAP] ([MaBaiTap], [TenBT], [NgayDuocGiao], [HanNop], [TrangThai], [MaGV], [MoTa]) VALUES (N'1', N'TD', CAST(N'2024-10-30T19:21:46.000' AS DateTime), CAST(N'2024-11-29T19:21:46.000' AS DateTime), N'Ðã hoàn thành', NULL, N'da')
INSERT [dbo].[BAITAP] ([MaBaiTap], [TenBT], [NgayDuocGiao], [HanNop], [TrangThai], [MaGV], [MoTa]) VALUES (N'2', N'toan', CAST(N'2024-11-21T09:50:18.000' AS DateTime), CAST(N'2024-11-28T09:50:18.850' AS DateTime), N'Ðã hoàn thành', NULL, N'tinh')
INSERT [dbo].[BAITAP] ([MaBaiTap], [TenBT], [NgayDuocGiao], [HanNop], [TrangThai], [MaGV], [MoTa]) VALUES (N'3', N'tin', CAST(N'2024-11-20T09:50:18.000' AS DateTime), CAST(N'2024-11-28T09:50:18.850' AS DateTime), N'Chưa hoàn thành', NULL, N'tinh')
INSERT [dbo].[BAITAP] ([MaBaiTap], [TenBT], [NgayDuocGiao], [HanNop], [TrangThai], [MaGV], [MoTa]) VALUES (N'4', N'Anh', CAST(N'2024-11-27T20:25:25.280' AS DateTime), CAST(N'2024-11-27T20:25:25.270' AS DateTime), N'Chưa hoàn thành', NULL, N'Doc')
INSERT [dbo].[BAITAP] ([MaBaiTap], [TenBT], [NgayDuocGiao], [HanNop], [TrangThai], [MaGV], [MoTa]) VALUES (N'5', N'Van', CAST(N'2024-11-28T11:17:54.160' AS DateTime), CAST(N'2024-11-28T11:17:54.160' AS DateTime), N'Chưa hoàn thành', NULL, N'ta')
INSERT [dbo].[BAITAP] ([MaBaiTap], [TenBT], [NgayDuocGiao], [HanNop], [TrangThai], [MaGV], [MoTa]) VALUES (N'6', N'cd', CAST(N'2024-10-02T08:29:59.000' AS DateTime), CAST(N'2024-11-29T08:29:59.990' AS DateTime), N'Chưa hoàn thành', NULL, N'dv')
GO
INSERT [dbo].[GIAOVIEN] ([MaGV], [HoTen], [Email], [PhongBan]) VALUES (N'1', N'Nguyen Van A', N'nguyenvana@school.com', N'Toan')
INSERT [dbo].[GIAOVIEN] ([MaGV], [HoTen], [Email], [PhongBan]) VALUES (N'2', N'Tran Thi B', N'tranthib@school.com', N'Ly')
INSERT [dbo].[GIAOVIEN] ([MaGV], [HoTen], [Email], [PhongBan]) VALUES (N'3', N'Le Van C', N'levanc@school.com', N'Hoa')
INSERT [dbo].[GIAOVIEN] ([MaGV], [HoTen], [Email], [PhongBan]) VALUES (N'GV001', N'Nguyen Van A', N'nguyenvana@school.com', N'Toan')
INSERT [dbo].[GIAOVIEN] ([MaGV], [HoTen], [Email], [PhongBan]) VALUES (N'GV002', N'Tran Thi B', N'tranthib@school.com', N'Ly')
INSERT [dbo].[GIAOVIEN] ([MaGV], [HoTen], [Email], [PhongBan]) VALUES (N'GV003', N'Le Van C', N'levanc@school.com', N'Hoa')
GO
INSERT [dbo].[HOC] ([MaHS], [MaLichHoc]) VALUES (N'1', 1)
INSERT [dbo].[HOC] ([MaHS], [MaLichHoc]) VALUES (N'3', 1)
GO
INSERT [dbo].[HOCSINH] ([MaHS], [HoTen], [GioiTinh], [NoiSinh], [TrangThai], [Nghi], [Email], [Lop]) VALUES (N'1', N'T', N'Na', N'È', N'CON', N'5', N'T@gmail.com', N'12')
INSERT [dbo].[HOCSINH] ([MaHS], [HoTen], [GioiTinh], [NoiSinh], [TrangThai], [Nghi], [Email], [Lop]) VALUES (N'2', N'A', N'sag', N'sag', N'á', N'0', N'A@gmail.com', N'8')
INSERT [dbo].[HOCSINH] ([MaHS], [HoTen], [GioiTinh], [NoiSinh], [TrangThai], [Nghi], [Email], [Lop]) VALUES (N'3', N'B', N'SF', N'SDF', N'DS', N'4', N'B@gmail.com', N'11')
INSERT [dbo].[HOCSINH] ([MaHS], [HoTen], [GioiTinh], [NoiSinh], [TrangThai], [Nghi], [Email], [Lop]) VALUES (N'4', N'C', N'đ', N'gd', N'ds', N'5', N'C@gmail.com', N'9')
INSERT [dbo].[HOCSINH] ([MaHS], [HoTen], [GioiTinh], [NoiSinh], [TrangThai], [Nghi], [Email], [Lop]) VALUES (N'5', N'Trương Minh Sang', N'Nam', N'TpHCM', N'Còn học', N'0', N'Sang@gmail.com', N'12')
GO
INSERT [dbo].[LAMVANOPBAITAP] ([MaHS], [MaBaiTap]) VALUES (N'1', N'1')
INSERT [dbo].[LAMVANOPBAITAP] ([MaHS], [MaBaiTap]) VALUES (N'1', N'2')
INSERT [dbo].[LAMVANOPBAITAP] ([MaHS], [MaBaiTap]) VALUES (N'1', N'3')
INSERT [dbo].[LAMVANOPBAITAP] ([MaHS], [MaBaiTap]) VALUES (N'2', N'4')
GO
INSERT [dbo].[LICHHOC] ([MaLichHoc], [TuanHoc], [NamHoc], [ThoiGianBatDau], [ThoiGianKetThuc], [PhongHoc], [Mon]) VALUES (N'1', N'1', N'1', CAST(N'2024-11-28T19:37:19.367' AS DateTime), CAST(N'2024-11-28T19:37:19.360' AS DateTime), N'1', N'TD')
INSERT [dbo].[LICHHOC] ([MaLichHoc], [TuanHoc], [NamHoc], [ThoiGianBatDau], [ThoiGianKetThuc], [PhongHoc], [Mon]) VALUES (N'2', N'4', N'3', CAST(N'2024-11-25T12:09:06.737' AS DateTime), CAST(N'2024-11-25T12:09:06.730' AS DateTime), N'3', N'Toán')
INSERT [dbo].[LICHHOC] ([MaLichHoc], [TuanHoc], [NamHoc], [ThoiGianBatDau], [ThoiGianKetThuc], [PhongHoc], [Mon]) VALUES (N'3', N'2', N'2', CAST(N'2024-11-20T08:27:37.000' AS DateTime), CAST(N'2024-11-29T08:27:37.850' AS DateTime), N'2', N'Văn')
INSERT [dbo].[LICHHOC] ([MaLichHoc], [TuanHoc], [NamHoc], [ThoiGianBatDau], [ThoiGianKetThuc], [PhongHoc], [Mon]) VALUES (N'4', N'1', N'1', CAST(N'2024-10-29T08:27:37.000' AS DateTime), CAST(N'2024-11-29T08:27:37.850' AS DateTime), N'1', N'Tin')
GO
INSERT [dbo].[LOPHOC] ([MaLop], [TenLop], [PhongHoc]) VALUES (N'', N'', N'')
INSERT [dbo].[LOPHOC] ([MaLop], [TenLop], [PhongHoc]) VALUES (N'10', N'10', N'10')
INSERT [dbo].[LOPHOC] ([MaLop], [TenLop], [PhongHoc]) VALUES (N'10A1', N'Lop 10A1', N'1')
INSERT [dbo].[LOPHOC] ([MaLop], [TenLop], [PhongHoc]) VALUES (N'11', N'11', N'11')
INSERT [dbo].[LOPHOC] ([MaLop], [TenLop], [PhongHoc]) VALUES (N'12', N'12', N'12')
INSERT [dbo].[LOPHOC] ([MaLop], [TenLop], [PhongHoc]) VALUES (N'12A1', N'Lop 12A1', N'2')
INSERT [dbo].[LOPHOC] ([MaLop], [TenLop], [PhongHoc]) VALUES (N'12A3', N' 12A3', N'2')
INSERT [dbo].[LOPHOC] ([MaLop], [TenLop], [PhongHoc]) VALUES (N'12A4', N' 12A4', N'12A4')
INSERT [dbo].[LOPHOC] ([MaLop], [TenLop], [PhongHoc]) VALUES (N'5', N'5', N'5')
INSERT [dbo].[LOPHOC] ([MaLop], [TenLop], [PhongHoc]) VALUES (N'8', N'8', N'8')
INSERT [dbo].[LOPHOC] ([MaLop], [TenLop], [PhongHoc]) VALUES (N'9', N'9', N'9')
GO
INSERT [dbo].[MONHOC] ([MaMon], [TenMon]) VALUES (1, N'Toán')
INSERT [dbo].[MONHOC] ([MaMon], [TenMon]) VALUES (2, N'Van')
INSERT [dbo].[MONHOC] ([MaMon], [TenMon]) VALUES (3, N'Anh')
INSERT [dbo].[MONHOC] ([MaMon], [TenMon]) VALUES (4, N'Hóa')
INSERT [dbo].[MONHOC] ([MaMon], [TenMon]) VALUES (5, N'Lý')
INSERT [dbo].[MONHOC] ([MaMon], [TenMon]) VALUES (6, N'Sinh')
INSERT [dbo].[MONHOC] ([MaMon], [TenMon]) VALUES (7, N'Ðia')
INSERT [dbo].[MONHOC] ([MaMon], [TenMon]) VALUES (8, N'Su')
INSERT [dbo].[MONHOC] ([MaMon], [TenMon]) VALUES (9, N'GDCD')
INSERT [dbo].[MONHOC] ([MaMon], [TenMon]) VALUES (10, N'CN')
INSERT [dbo].[MONHOC] ([MaMon], [TenMon]) VALUES (11, N'TD')
INSERT [dbo].[MONHOC] ([MaMon], [TenMon]) VALUES (12, N'Tin')
GO
INSERT [dbo].[THONGBAO] ([MaThongBao], [NoiDung], [NgayGui], [LoaiThongBao], [MaGV]) VALUES (N'337599e7-ca29-4c8c-93cc-a6d8c6244736', N'EG', CAST(N'2024-11-24T20:48:30.440' AS DateTime), NULL, N'1')
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([UserID], [TenDangNhap], [MK], [VaiTro]) VALUES (2, N'teacher', N'456', N'Teacher')
INSERT [dbo].[Users] ([UserID], [TenDangNhap], [MK], [VaiTro]) VALUES (3, N'admin', N'789', N'Admin')
INSERT [dbo].[Users] ([UserID], [TenDangNhap], [MK], [VaiTro]) VALUES (9, N'T@gmail.com', N'123', N'Student')
INSERT [dbo].[Users] ([UserID], [TenDangNhap], [MK], [VaiTro]) VALUES (11, N'B@gmail.com', N'123', N'Student')
INSERT [dbo].[Users] ([UserID], [TenDangNhap], [MK], [VaiTro]) VALUES (12, N'C@gmail.com', N'123', N'Student')
INSERT [dbo].[Users] ([UserID], [TenDangNhap], [MK], [VaiTro]) VALUES (14, N'A@gmail.com', N'123', N'Student')
INSERT [dbo].[Users] ([UserID], [TenDangNhap], [MK], [VaiTro]) VALUES (16, N'Sang@gmail.com', N'123', N'Student')
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Users__55F68FC04A06401E]    Script Date: 11/29/2024 12:33:34 PM ******/
ALTER TABLE [dbo].[Users] ADD UNIQUE NONCLUSTERED 
(
	[TenDangNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[BAITAP]  WITH CHECK ADD  CONSTRAINT [FK_BAITAP_GIAOVIEN] FOREIGN KEY([MaGV])
REFERENCES [dbo].[GIAOVIEN] ([MaGV])
GO
ALTER TABLE [dbo].[BAITAP] CHECK CONSTRAINT [FK_BAITAP_GIAOVIEN]
GO
ALTER TABLE [dbo].[HOC]  WITH CHECK ADD  CONSTRAINT [FK__HOC__MaHS__44FF419A] FOREIGN KEY([MaHS])
REFERENCES [dbo].[HOCSINH] ([MaHS])
GO
ALTER TABLE [dbo].[HOC] CHECK CONSTRAINT [FK__HOC__MaHS__44FF419A]
GO
ALTER TABLE [dbo].[HOC]  WITH CHECK ADD  CONSTRAINT [FK__HOC__MaMon__45F365D3] FOREIGN KEY([MaLichHoc])
REFERENCES [dbo].[MONHOC] ([MaMon])
GO
ALTER TABLE [dbo].[HOC] CHECK CONSTRAINT [FK__HOC__MaMon__45F365D3]
GO
ALTER TABLE [dbo].[HOCSINH]  WITH CHECK ADD  CONSTRAINT [FK_HOCSINH_LOPHOC] FOREIGN KEY([Lop])
REFERENCES [dbo].[LOPHOC] ([MaLop])
GO
ALTER TABLE [dbo].[HOCSINH] CHECK CONSTRAINT [FK_HOCSINH_LOPHOC]
GO
ALTER TABLE [dbo].[LAMVANOPBAITAP]  WITH CHECK ADD  CONSTRAINT [FK__LAMVANOPB__MaBai__49C3F6B7] FOREIGN KEY([MaBaiTap])
REFERENCES [dbo].[BAITAP] ([MaBaiTap])
GO
ALTER TABLE [dbo].[LAMVANOPBAITAP] CHECK CONSTRAINT [FK__LAMVANOPB__MaBai__49C3F6B7]
GO
ALTER TABLE [dbo].[LAMVANOPBAITAP]  WITH CHECK ADD  CONSTRAINT [FK__LAMVANOPBA__MaHS__48CFD27E] FOREIGN KEY([MaHS])
REFERENCES [dbo].[HOCSINH] ([MaHS])
GO
ALTER TABLE [dbo].[LAMVANOPBAITAP] CHECK CONSTRAINT [FK__LAMVANOPBA__MaHS__48CFD27E]
GO
ALTER TABLE [dbo].[NHAN]  WITH CHECK ADD  CONSTRAINT [FK__NHAN__MaHS__5070F446] FOREIGN KEY([MaHS])
REFERENCES [dbo].[HOCSINH] ([MaHS])
GO
ALTER TABLE [dbo].[NHAN] CHECK CONSTRAINT [FK__NHAN__MaHS__5070F446]
GO
ALTER TABLE [dbo].[NHAN]  WITH CHECK ADD  CONSTRAINT [FK__NHAN__MaThongBao__5165187F] FOREIGN KEY([MaThongBao])
REFERENCES [dbo].[THONGBAO] ([MaThongBao])
GO
ALTER TABLE [dbo].[NHAN] CHECK CONSTRAINT [FK__NHAN__MaThongBao__5165187F]
GO
ALTER TABLE [dbo].[PHUTRACH]  WITH CHECK ADD  CONSTRAINT [FK__PHUTRACH__MaGV__5441852A] FOREIGN KEY([MaGV])
REFERENCES [dbo].[GIAOVIEN] ([MaGV])
GO
ALTER TABLE [dbo].[PHUTRACH] CHECK CONSTRAINT [FK__PHUTRACH__MaGV__5441852A]
GO
ALTER TABLE [dbo].[PHUTRACH]  WITH CHECK ADD  CONSTRAINT [FK__PHUTRACH__MaMon__5535A963] FOREIGN KEY([MaMon])
REFERENCES [dbo].[MONHOC] ([MaMon])
GO
ALTER TABLE [dbo].[PHUTRACH] CHECK CONSTRAINT [FK__PHUTRACH__MaMon__5535A963]
GO
ALTER TABLE [dbo].[THONGBAO]  WITH CHECK ADD  CONSTRAINT [FK_THONGBAO_GIAOVIEN] FOREIGN KEY([MaGV])
REFERENCES [dbo].[GIAOVIEN] ([MaGV])
GO
ALTER TABLE [dbo].[THONGBAO] CHECK CONSTRAINT [FK_THONGBAO_GIAOVIEN]
GO
ALTER TABLE [dbo].[THUOC]  WITH CHECK ADD FOREIGN KEY([MaLichHoc])
REFERENCES [dbo].[LICHHOC] ([MaLichHoc])
GO
ALTER TABLE [dbo].[THUOC]  WITH CHECK ADD FOREIGN KEY([MaLichHoc])
REFERENCES [dbo].[LICHHOC] ([MaLichHoc])
GO
ALTER TABLE [dbo].[XEM]  WITH CHECK ADD  CONSTRAINT [FK__XEM__MaHS__4CA06362] FOREIGN KEY([MaHS])
REFERENCES [dbo].[HOCSINH] ([MaHS])
GO
ALTER TABLE [dbo].[XEM] CHECK CONSTRAINT [FK__XEM__MaHS__4CA06362]
GO
ALTER TABLE [dbo].[XEM]  WITH CHECK ADD  CONSTRAINT [FK__XEM__MaLichHoc__4D94879B] FOREIGN KEY([MaLichHoc])
REFERENCES [dbo].[LICHHOC] ([MaLichHoc])
GO
ALTER TABLE [dbo].[XEM] CHECK CONSTRAINT [FK__XEM__MaLichHoc__4D94879B]
GO
