USE [master]
GO
/****** Object:  Database [QuanLyBanVeMayBay]    Script Date: 5/11/2023 12:07:26 AM ******/
CREATE DATABASE [QuanLyBanVeMayBay]

GO
USE [QuanLyBanVeMayBay]
GO
/****** Object:  Table [dbo].[CHITIETCHUYENBAY]    Script Date: 5/11/2023 12:07:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHITIETCHUYENBAY](
	[MaChiTietChuyenBay] [nvarchar](50) NOT NULL,
	[MaChuyenBay] [nvarchar](50) NULL,
	[SanBayTrungGian] [nvarchar](50) NULL,
	[ThoiGianDung] [float] NULL,
 CONSTRAINT [pk_chitietchuyenbay] PRIMARY KEY CLUSTERED 
(
	[MaChiTietChuyenBay] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CHUYENBAY]    Script Date: 5/11/2023 12:07:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHUYENBAY](
	[MaChuyenBay] [nvarchar](50) NOT NULL,
	[MaTuyenBay] [nvarchar](50) NULL,
	[NgayGio] [datetime] NULL,
	[ThoiGianBay] [float] NULL,
	[SoLuongGheHang1] [int] NULL,
	[MAMAYBAY] [nchar](10) NULL,
	[SoLuongGheHang2] [int] NULL,
 CONSTRAINT [pk_chuyenbay] PRIMARY KEY CLUSTERED 
(
	[MaChuyenBay] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CTDOANHTHUTHANG]    Script Date: 5/11/2023 12:07:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTDOANHTHUTHANG](
	[MaCTDoanhThuThang] [nvarchar](50) NOT NULL,
	[MaDoanhThuThang] [nvarchar](50) NULL,
	[MaChuyenBay] [nvarchar](50) NULL,
	[SoVe] [int] NULL,
	[TyLe] [float] NULL,
	[DoanhThu] [float] NULL,
 CONSTRAINT [pk_ctdoanhthuthang] PRIMARY KEY CLUSTERED 
(
	[MaCTDoanhThuThang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DOANHTHUNAM]    Script Date: 5/11/2023 12:07:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DOANHTHUNAM](
	[MaDoanhThuNam] [nvarchar](50) NOT NULL,
	[Nam] [int] NULL,
	[TongDoanhThuNam] [float] NULL,
 CONSTRAINT [pk_doanhthunam] PRIMARY KEY CLUSTERED 
(
	[MaDoanhThuNam] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DOANHTHUTHANG]    Script Date: 5/11/2023 12:07:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DOANHTHUTHANG](
	[MaDoanhThuThang] [nvarchar](50) NOT NULL,
	[Thang] [int] NULL,
	[MaDoanhThuNam] [nvarchar](50) NULL,
	[SoChuyenBay] [int] NULL,
	[TyLe] [float] NULL,
	[TongDoanhThuThang] [float] NULL,
 CONSTRAINT [pk_doanhthuthang] PRIMARY KEY CLUSTERED 
(
	[MaDoanhThuThang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DONGIA]    Script Date: 5/11/2023 12:07:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DONGIA](
	[MaDonGia] [int] IDENTITY(1,1) NOT NULL,
	[MaChuyenBay] [nvarchar](50) NOT NULL,
	[MaHangVe] [nvarchar](50) NULL,
	[DonGia] [float] NULL,
 CONSTRAINT [pk_dongia] PRIMARY KEY CLUSTERED 
(
	[MaDonGia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HANGVE]    Script Date: 5/11/2023 12:07:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HANGVE](
	[MaHangVe] [nvarchar](50) NOT NULL,
	[TenHangVe] [nvarchar](50) NULL,
 CONSTRAINT [pk_hangve] PRIMARY KEY CLUSTERED 
(
	[MaHangVe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KHACHHANG]    Script Date: 5/11/2023 12:07:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHACHHANG](
	[MaHanhKhach] [int] IDENTITY(1,1) NOT NULL,
	[TenKH] [nvarchar](50) NULL,
	[CMND] [nvarchar](50) NULL,
	[DienThoai] [nvarchar](50) NULL,
 CONSTRAINT [pk_hanhkhach] PRIMARY KEY CLUSTERED 
(
	[MaHanhKhach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MAYBAY]    Script Date: 5/11/2023 12:07:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MAYBAY](
	[MAMAYBAY] [nchar](10) NOT NULL,
	[TENMAYBAY] [nchar](10) NOT NULL,
	[THONGTIN] [nchar](10) NOT NULL,
 CONSTRAINT [PK_MABAY] PRIMARY KEY CLUSTERED 
(
	[MAMAYBAY] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PHIEUDATCHO]    Script Date: 5/11/2023 12:07:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEUDATCHO](
	[MaPhieuDat] [int] IDENTITY(1,1) NOT NULL,
	[MaChuyenBay] [nvarchar](50) NULL,
	[MaHanhKhach] [int] NULL,
	[MaHangVe] [nvarchar](50) NULL,
	[GiaTien] [float] NULL,
	[SOGHEDAT] [int] NULL,
	[NgayDat] [datetime] NULL,
	[CMND] [int] NULL,
 CONSTRAINT [pk_phieudatcho] PRIMARY KEY CLUSTERED 
(
	[MaPhieuDat] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SANBAY]    Script Date: 5/11/2023 12:07:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SANBAY](
	[MaSanBay] [nvarchar](50) NOT NULL,
	[TenSanBay] [nvarchar](50) NULL,
 CONSTRAINT [pk_sanbay] PRIMARY KEY CLUSTERED 
(
	[MaSanBay] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[THAMSO]    Script Date: 5/11/2023 12:07:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[THAMSO](
	[ThoiGianBayToiThieu] [float] NULL,
	[SoSanBayTrungGianToiDa] [float] NULL,
	[ThoiGianDungToiThieu] [float] NULL,
	[ThoiGianDungToiDa] [float] NULL,
	[ThoiGianChamNhatDatVe] [float] NULL,
	[ThoiGianChamNhatHuyVe] [float] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TINHTRANGVE]    Script Date: 5/11/2023 12:07:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TINHTRANGVE](
	[MaTinhTrangVe] [nvarchar](50) NOT NULL,
	[MaChuyenBay] [nvarchar](50) NULL,
	[MaHangVe] [nvarchar](50) NULL,
	[SoGheTrong] [int] NULL,
	[SoGheDat] [int] NULL,
 CONSTRAINT [pk_tinhtrangve] PRIMARY KEY CLUSTERED 
(
	[MaTinhTrangVe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TUYENBAY]    Script Date: 5/11/2023 12:07:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TUYENBAY](
	[MaTuyenBay] [nvarchar](50) NOT NULL,
	[MaSanBayDi] [nvarchar](50) NULL,
	[MaSanBayDen] [nvarchar](50) NULL,
 CONSTRAINT [pk_tuyenbay] PRIMARY KEY CLUSTERED 
(
	[MaTuyenBay] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VECHUYENBAY]    Script Date: 5/11/2023 12:07:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VECHUYENBAY](
	[MaVe] [nvarchar](50) NOT NULL,
	[MaChuyenBay] [nvarchar](50) NULL,
	[MaHangVe] [nvarchar](50) NULL,
	[MaHanhKhach] [int] NULL,
	[GiaTien] [float] NULL,
 CONSTRAINT [pk_vechuyenbay] PRIMARY KEY CLUSTERED 
(
	[MaVe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[CHUYENBAY] ([MaChuyenBay], [MaTuyenBay], [NgayGio], [ThoiGianBay], [SoLuongGheHang1], [MAMAYBAY], [SoLuongGheHang2]) VALUES (N'rrrr', N'n1-e1', CAST(N'2015-05-05T00:00:00.000' AS DateTime), 1, 11, N'we        ', 1)
INSERT [dbo].[CHUYENBAY] ([MaChuyenBay], [MaTuyenBay], [NgayGio], [ThoiGianBay], [SoLuongGheHang1], [MAMAYBAY], [SoLuongGheHang2]) VALUES (N'ssss', N'm1-e1', CAST(N'2015-05-14T00:00:00.000' AS DateTime), 10, 1, N'we        ', 1)
GO
SET IDENTITY_INSERT [dbo].[DONGIA] ON 

INSERT [dbo].[DONGIA] ([MaDonGia], [MaChuyenBay], [MaHangVe], [DonGia]) VALUES (12, N'ssss', N'r', 2222)
INSERT [dbo].[DONGIA] ([MaDonGia], [MaChuyenBay], [MaHangVe], [DonGia]) VALUES (13, N'ssss', N'u', 332)
SET IDENTITY_INSERT [dbo].[DONGIA] OFF
GO
INSERT [dbo].[HANGVE] ([MaHangVe], [TenHangVe]) VALUES (N'r', N'rr12')
INSERT [dbo].[HANGVE] ([MaHangVe], [TenHangVe]) VALUES (N'r32', N'rr12221')
INSERT [dbo].[HANGVE] ([MaHangVe], [TenHangVe]) VALUES (N'rrr', N'rr')
INSERT [dbo].[HANGVE] ([MaHangVe], [TenHangVe]) VALUES (N'u', N'uuu')
GO
SET IDENTITY_INSERT [dbo].[KHACHHANG] ON 

INSERT [dbo].[KHACHHANG] ([MaHanhKhach], [TenKH], [CMND], [DienThoai]) VALUES (2, N'www', N'9', N'1')
INSERT [dbo].[KHACHHANG] ([MaHanhKhach], [TenKH], [CMND], [DienThoai]) VALUES (3, N'rt', N'3', N'3')
SET IDENTITY_INSERT [dbo].[KHACHHANG] OFF
GO
INSERT [dbo].[MAYBAY] ([MAMAYBAY], [TENMAYBAY], [THONGTIN]) VALUES (N'we        ', N'wr        ', N'wp        ')
INSERT [dbo].[MAYBAY] ([MAMAYBAY], [TENMAYBAY], [THONGTIN]) VALUES (N'ww        ', N'w         ', N'w         ')
GO
SET IDENTITY_INSERT [dbo].[PHIEUDATCHO] ON 

INSERT [dbo].[PHIEUDATCHO] ([MaPhieuDat], [MaChuyenBay], [MaHanhKhach], [MaHangVe], [GiaTien], [SOGHEDAT], [NgayDat], [CMND]) VALUES (9, N'ssss', 3, N'u', 332, 1, CAST(N'2023-05-10T11:25:44.000' AS DateTime), 3)
SET IDENTITY_INSERT [dbo].[PHIEUDATCHO] OFF
GO
INSERT [dbo].[SANBAY] ([MaSanBay], [TenSanBay]) VALUES (N'e1', N'San Bay Long An')
INSERT [dbo].[SANBAY] ([MaSanBay], [TenSanBay]) VALUES (N'm1', N'Tan Son Nhat')
INSERT [dbo].[SANBAY] ([MaSanBay], [TenSanBay]) VALUES (N'n1', N'San Bay Ha Noi')
INSERT [dbo].[SANBAY] ([MaSanBay], [TenSanBay]) VALUES (N'r1', N'ca mau')
GO
INSERT [dbo].[TUYENBAY] ([MaTuyenBay], [MaSanBayDi], [MaSanBayDen]) VALUES (N'm1-e1', N'm1', N'e1')
INSERT [dbo].[TUYENBAY] ([MaTuyenBay], [MaSanBayDi], [MaSanBayDen]) VALUES (N'n1-e1', N'n1', N'e1')
INSERT [dbo].[TUYENBAY] ([MaTuyenBay], [MaSanBayDi], [MaSanBayDen]) VALUES (N'n1-m1', N'n1', N'm1')
GO
ALTER TABLE [dbo].[CHITIETCHUYENBAY]  WITH CHECK ADD  CONSTRAINT [fk_chitiettuyenbay_chuyenbay] FOREIGN KEY([MaChuyenBay])
REFERENCES [dbo].[CHUYENBAY] ([MaChuyenBay])
GO
ALTER TABLE [dbo].[CHITIETCHUYENBAY] CHECK CONSTRAINT [fk_chitiettuyenbay_chuyenbay]
GO
ALTER TABLE [dbo].[CHITIETCHUYENBAY]  WITH CHECK ADD  CONSTRAINT [fk_chitiettuyenbay_sanbay] FOREIGN KEY([SanBayTrungGian])
REFERENCES [dbo].[SANBAY] ([MaSanBay])
GO
ALTER TABLE [dbo].[CHITIETCHUYENBAY] CHECK CONSTRAINT [fk_chitiettuyenbay_sanbay]
GO
ALTER TABLE [dbo].[CHUYENBAY]  WITH CHECK ADD  CONSTRAINT [FK_CHUYENBAY_MABAY] FOREIGN KEY([MAMAYBAY])
REFERENCES [dbo].[MAYBAY] ([MAMAYBAY])
GO
ALTER TABLE [dbo].[CHUYENBAY] CHECK CONSTRAINT [FK_CHUYENBAY_MABAY]
GO
ALTER TABLE [dbo].[CHUYENBAY]  WITH CHECK ADD  CONSTRAINT [fk_chuyenbay_tuyenbay] FOREIGN KEY([MaTuyenBay])
REFERENCES [dbo].[TUYENBAY] ([MaTuyenBay])
GO
ALTER TABLE [dbo].[CHUYENBAY] CHECK CONSTRAINT [fk_chuyenbay_tuyenbay]
GO
ALTER TABLE [dbo].[CTDOANHTHUTHANG]  WITH CHECK ADD  CONSTRAINT [fk_ctdoanhthuthang_chuyenbay] FOREIGN KEY([MaChuyenBay])
REFERENCES [dbo].[CHUYENBAY] ([MaChuyenBay])
GO
ALTER TABLE [dbo].[CTDOANHTHUTHANG] CHECK CONSTRAINT [fk_ctdoanhthuthang_chuyenbay]
GO
ALTER TABLE [dbo].[CTDOANHTHUTHANG]  WITH CHECK ADD  CONSTRAINT [fk_ctdoanhthuthang_doanhthuthang] FOREIGN KEY([MaDoanhThuThang])
REFERENCES [dbo].[DOANHTHUTHANG] ([MaDoanhThuThang])
GO
ALTER TABLE [dbo].[CTDOANHTHUTHANG] CHECK CONSTRAINT [fk_ctdoanhthuthang_doanhthuthang]
GO
ALTER TABLE [dbo].[DOANHTHUTHANG]  WITH CHECK ADD  CONSTRAINT [fk_doanhthuthang_doanhthunam] FOREIGN KEY([MaDoanhThuNam])
REFERENCES [dbo].[DOANHTHUNAM] ([MaDoanhThuNam])
GO
ALTER TABLE [dbo].[DOANHTHUTHANG] CHECK CONSTRAINT [fk_doanhthuthang_doanhthunam]
GO
ALTER TABLE [dbo].[DONGIA]  WITH CHECK ADD  CONSTRAINT [FK_DONGIA_CHUYENBAY] FOREIGN KEY([MaChuyenBay])
REFERENCES [dbo].[CHUYENBAY] ([MaChuyenBay])
GO
ALTER TABLE [dbo].[DONGIA] CHECK CONSTRAINT [FK_DONGIA_CHUYENBAY]
GO
ALTER TABLE [dbo].[DONGIA]  WITH CHECK ADD  CONSTRAINT [fk_dongia_hangve] FOREIGN KEY([MaHangVe])
REFERENCES [dbo].[HANGVE] ([MaHangVe])
GO
ALTER TABLE [dbo].[DONGIA] CHECK CONSTRAINT [fk_dongia_hangve]
GO
ALTER TABLE [dbo].[PHIEUDATCHO]  WITH CHECK ADD  CONSTRAINT [fk__phieudatcho_hangve] FOREIGN KEY([MaHangVe])
REFERENCES [dbo].[HANGVE] ([MaHangVe])
GO
ALTER TABLE [dbo].[PHIEUDATCHO] CHECK CONSTRAINT [fk__phieudatcho_hangve]
GO
ALTER TABLE [dbo].[PHIEUDATCHO]  WITH CHECK ADD  CONSTRAINT [fk_phieudatcho_chuyenbay] FOREIGN KEY([MaChuyenBay])
REFERENCES [dbo].[CHUYENBAY] ([MaChuyenBay])
GO
ALTER TABLE [dbo].[PHIEUDATCHO] CHECK CONSTRAINT [fk_phieudatcho_chuyenbay]
GO
ALTER TABLE [dbo].[PHIEUDATCHO]  WITH CHECK ADD  CONSTRAINT [fk_phieudatcho_hanhkhach] FOREIGN KEY([MaHanhKhach])
REFERENCES [dbo].[KHACHHANG] ([MaHanhKhach])
GO
ALTER TABLE [dbo].[PHIEUDATCHO] CHECK CONSTRAINT [fk_phieudatcho_hanhkhach]
GO
ALTER TABLE [dbo].[TINHTRANGVE]  WITH CHECK ADD  CONSTRAINT [fk_tinhtrangve_chuyenbay] FOREIGN KEY([MaChuyenBay])
REFERENCES [dbo].[CHUYENBAY] ([MaChuyenBay])
GO
ALTER TABLE [dbo].[TINHTRANGVE] CHECK CONSTRAINT [fk_tinhtrangve_chuyenbay]
GO
ALTER TABLE [dbo].[TINHTRANGVE]  WITH CHECK ADD  CONSTRAINT [fk_tinhtrangve_hangve] FOREIGN KEY([MaHangVe])
REFERENCES [dbo].[HANGVE] ([MaHangVe])
GO
ALTER TABLE [dbo].[TINHTRANGVE] CHECK CONSTRAINT [fk_tinhtrangve_hangve]
GO
ALTER TABLE [dbo].[TUYENBAY]  WITH CHECK ADD  CONSTRAINT [fk_tuyenbay_sanbayden] FOREIGN KEY([MaSanBayDen])
REFERENCES [dbo].[SANBAY] ([MaSanBay])
GO
ALTER TABLE [dbo].[TUYENBAY] CHECK CONSTRAINT [fk_tuyenbay_sanbayden]
GO
ALTER TABLE [dbo].[TUYENBAY]  WITH CHECK ADD  CONSTRAINT [fk_tuyenbay_sanbaydi] FOREIGN KEY([MaSanBayDi])
REFERENCES [dbo].[SANBAY] ([MaSanBay])
GO
ALTER TABLE [dbo].[TUYENBAY] CHECK CONSTRAINT [fk_tuyenbay_sanbaydi]
GO
ALTER TABLE [dbo].[VECHUYENBAY]  WITH CHECK ADD  CONSTRAINT [fk_vechuyenbay_chuyenbay] FOREIGN KEY([MaChuyenBay])
REFERENCES [dbo].[CHUYENBAY] ([MaChuyenBay])
GO
ALTER TABLE [dbo].[VECHUYENBAY] CHECK CONSTRAINT [fk_vechuyenbay_chuyenbay]
GO
ALTER TABLE [dbo].[VECHUYENBAY]  WITH CHECK ADD  CONSTRAINT [fk_vechuyenbay_hangve] FOREIGN KEY([MaHangVe])
REFERENCES [dbo].[HANGVE] ([MaHangVe])
GO
ALTER TABLE [dbo].[VECHUYENBAY] CHECK CONSTRAINT [fk_vechuyenbay_hangve]
GO
ALTER TABLE [dbo].[VECHUYENBAY]  WITH CHECK ADD  CONSTRAINT [fk_vechuyenbay_hanhkhach] FOREIGN KEY([MaHanhKhach])
REFERENCES [dbo].[KHACHHANG] ([MaHanhKhach])
GO
ALTER TABLE [dbo].[VECHUYENBAY] CHECK CONSTRAINT [fk_vechuyenbay_hanhkhach]
GO
USE [master]
GO
ALTER DATABASE [QuanLyBanVeMayBay] SET  READ_WRITE 
GO
