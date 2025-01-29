USE [QLTV_TAPSON]
GO
/****** Object:  Table [dbo].[DANHMUC]    Script Date: 01/06/2025 17:16:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DANHMUC](
	[MADANHMUC] [varchar](100) NOT NULL,
	[TENDANHMUC] [varchar](120) NULL,
	[MOTADANHMUC] [varchar](100) NULL,
 CONSTRAINT [PK_DANHMUC] PRIMARY KEY NONCLUSTERED 
(
	[MADANHMUC] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[DANHMUC] ([MADANHMUC], [TENDANHMUC], [MOTADANHMUC]) VALUES (N'KN', N'Sach ky nang', N'Sach ky nang mem')
INSERT [dbo].[DANHMUC] ([MADANHMUC], [TENDANHMUC], [MOTADANHMUC]) VALUES (N'TT', N'Truyen tranh', N'Truyen tranh')
INSERT [dbo].[DANHMUC] ([MADANHMUC], [TENDANHMUC], [MOTADANHMUC]) VALUES (N'TN', N'Truyen thieu nhi', N'Truyen thieu nhi')
/****** Object:  Table [dbo].[NGUOIDUNG]    Script Date: 01/06/2025 17:16:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NGUOIDUNG](
	[MANGUOIDUNG] [varchar](100) NOT NULL,
	[TENNGUOIDUNG] [varchar](120) NULL,
	[LOAINGUOIDUNG] [varchar](50) NULL,
	[SODIENTHOAI] [varchar](80) NULL,
	[EMAIL] [varchar](90) NULL,
	[DIACHI] [varchar](100) NULL,
	[THONGTINBOSUNG] [varchar](100) NULL,
 CONSTRAINT [PK_NGUOIDUNG] PRIMARY KEY NONCLUSTERED 
(
	[MANGUOIDUNG] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[NGUOIDUNG] ([MANGUOIDUNG], [TENNGUOIDUNG], [LOAINGUOIDUNG], [SODIENTHOAI], [EMAIL], [DIACHI], [THONGTINBOSUNG]) VALUES (N'U03', N'Khoi Nguyen', N'Nhan vien', N'0987727281', N'khoinguyen@gmail.com', N'Phuoc Hung, Tra Cu, Tra Vinh', N'Admin')
INSERT [dbo].[NGUOIDUNG] ([MANGUOIDUNG], [TENNGUOIDUNG], [LOAINGUOIDUNG], [SODIENTHOAI], [EMAIL], [DIACHI], [THONGTINBOSUNG]) VALUES (N'U02', N'Nguyen Van Nam', N'Giao vien', N'0987727321', N'vannam@tvu.edu.vn', N'Tra Vinh', N'Khong co')
INSERT [dbo].[NGUOIDUNG] ([MANGUOIDUNG], [TENNGUOIDUNG], [LOAINGUOIDUNG], [SODIENTHOAI], [EMAIL], [DIACHI], [THONGTINBOSUNG]) VALUES (N'U04', N'Nguyen Nhi', N'Giao vien', N'0986627282', N'nhi@gmail.com', N'Tra Vinh', N'Khong co')
/****** Object:  Table [dbo].[TACGIA]    Script Date: 01/06/2025 17:16:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TACGIA](
	[MATACGIA] [varchar](100) NOT NULL,
	[TENTACGIA] [varchar](120) NULL,
 CONSTRAINT [PK_TACGIA] PRIMARY KEY NONCLUSTERED 
(
	[MATACGIA] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[TACGIA] ([MATACGIA], [TENTACGIA]) VALUES (N'TG04', N'Tran Thi A')
INSERT [dbo].[TACGIA] ([MATACGIA], [TENTACGIA]) VALUES (N'TG02', N'Nguyen VanB')
INSERT [dbo].[TACGIA] ([MATACGIA], [TENTACGIA]) VALUES (N'TG03', N'Nguyen Van b')
/****** Object:  Table [dbo].[SACH]    Script Date: 01/06/2025 17:16:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SACH](
	[MASACH] [varchar](80) NOT NULL,
	[MADANHMUC] [varchar](100) NOT NULL,
	[MATACGIA] [varchar](100) NOT NULL,
	[TENSACH] [varchar](100) NULL,
	[NAMXUATBAN] [int] NULL,
	[ISBN] [varchar](70) NULL,
	[SOLUONG] [int] NULL,
	[SOLUONGCONLAI] [int] NULL,
	[MOTASACH] [varchar](100) NULL,
 CONSTRAINT [PK_SACH] PRIMARY KEY NONCLUSTERED 
(
	[MASACH] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[SACH] ([MASACH], [MADANHMUC], [MATACGIA], [TENSACH], [NAMXUATBAN], [ISBN], [SOLUONG], [SOLUONGCONLAI], [MOTASACH]) VALUES (N'S03', N'KN', N'TG02', N'Sach ky nang abc', 2004, N'OK2OKOKD', 2, 1, N'Sach ky nang abc')
INSERT [dbo].[SACH] ([MASACH], [MADANHMUC], [MATACGIA], [TENSACH], [NAMXUATBAN], [ISBN], [SOLUONG], [SOLUONGCONLAI], [MOTASACH]) VALUES (N'S02', N'KN', N'TG03', N'Sach ky nang quan ly tai chinh', 2017, N'SADAUSHD', 3, 2, N'Sach ky nang quan ly tai chinh')
INSERT [dbo].[SACH] ([MASACH], [MADANHMUC], [MATACGIA], [TENSACH], [NAMXUATBAN], [ISBN], [SOLUONG], [SOLUONGCONLAI], [MOTASACH]) VALUES (N'S04', N'TN', N'TG04', N'Co be quang khan do', 2001, N'SDFAS2ASD', 7, 7, N'Co be quang khan do')
INSERT [dbo].[SACH] ([MASACH], [MADANHMUC], [MATACGIA], [TENSACH], [NAMXUATBAN], [ISBN], [SOLUONG], [SOLUONGCONLAI], [MOTASACH]) VALUES (N'S05', N'TT', N'TG02', N'Truyen tranh Doraemon', 2011, N'SDANVISD', 4, 4, N'Truyen tranh Doraemon')
/****** Object:  Table [dbo].[PHIEUMUON]    Script Date: 01/06/2025 17:16:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PHIEUMUON](
	[MAPHIEUMUON] [varchar](100) NOT NULL,
	[MANGUOIDUNG] [varchar](100) NOT NULL,
	[MASACH] [varchar](80) NOT NULL,
	[NGAYMUON] [date] NULL,
	[SOLUONGSACH] [int] NULL,
	[NGAYTRADUKIEN] [date] NULL,
 CONSTRAINT [PK_PHIEUMUON] PRIMARY KEY NONCLUSTERED 
(
	[MAPHIEUMUON] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[PHIEUMUON] ([MAPHIEUMUON], [MANGUOIDUNG], [MASACH], [NGAYMUON], [SOLUONGSACH], [NGAYTRADUKIEN]) VALUES (N'PM01', N'U02', N'S02', CAST(0xB7470B00 AS Date), 2, CAST(0xBA470B00 AS Date))
INSERT [dbo].[PHIEUMUON] ([MAPHIEUMUON], [MANGUOIDUNG], [MASACH], [NGAYMUON], [SOLUONGSACH], [NGAYTRADUKIEN]) VALUES (N'PM02', N'U04', N'S02', CAST(0xB7470B00 AS Date), 1, CAST(0xBD470B00 AS Date))
INSERT [dbo].[PHIEUMUON] ([MAPHIEUMUON], [MANGUOIDUNG], [MASACH], [NGAYMUON], [SOLUONGSACH], [NGAYTRADUKIEN]) VALUES (N'PM03', N'U02', N'S02', CAST(0xB8470B00 AS Date), 1, CAST(0xBA470B00 AS Date))
INSERT [dbo].[PHIEUMUON] ([MAPHIEUMUON], [MANGUOIDUNG], [MASACH], [NGAYMUON], [SOLUONGSACH], [NGAYTRADUKIEN]) VALUES (N'PM04', N'U03', N'S03', CAST(0xB8470B00 AS Date), 1, CAST(0xBB470B00 AS Date))
INSERT [dbo].[PHIEUMUON] ([MAPHIEUMUON], [MANGUOIDUNG], [MASACH], [NGAYMUON], [SOLUONGSACH], [NGAYTRADUKIEN]) VALUES (N'PM05', N'U02', N'S05', CAST(0xB8470B00 AS Date), 2, CAST(0xBD470B00 AS Date))
INSERT [dbo].[PHIEUMUON] ([MAPHIEUMUON], [MANGUOIDUNG], [MASACH], [NGAYMUON], [SOLUONGSACH], [NGAYTRADUKIEN]) VALUES (N'PM06', N'U03', N'S03', CAST(0xB8470B00 AS Date), 1, CAST(0xB8470B00 AS Date))
/****** Object:  Table [dbo].[HOADONTRASACH]    Script Date: 01/06/2025 17:16:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HOADONTRASACH](
	[MAHOADON] [varchar](100) NOT NULL,
	[MAPHIEUMUON] [varchar](100) NOT NULL,
	[NGAYTRA] [date] NULL,
	[TONGPHIPHAT] [int] NULL,
 CONSTRAINT [PK_HOADONTRASACH] PRIMARY KEY NONCLUSTERED 
(
	[MAHOADON] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[HOADONTRASACH] ([MAHOADON], [MAPHIEUMUON], [NGAYTRA], [TONGPHIPHAT]) VALUES (N'HD1', N'PM03', CAST(0xBB470B00 AS Date), 20000)
INSERT [dbo].[HOADONTRASACH] ([MAHOADON], [MAPHIEUMUON], [NGAYTRA], [TONGPHIPHAT]) VALUES (N'HD2', N'PM04', CAST(0xBC470B00 AS Date), 20000)
INSERT [dbo].[HOADONTRASACH] ([MAHOADON], [MAPHIEUMUON], [NGAYTRA], [TONGPHIPHAT]) VALUES (N'HD3', N'PM05', CAST(0xBD470B00 AS Date), 0)
/****** Object:  Table [dbo].[CHITIET]    Script Date: 01/06/2025 17:16:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CHITIET](
	[MASACH] [varchar](80) NOT NULL,
	[MAHOADON] [varchar](100) NOT NULL,
	[SONGAYSUDUNG] [int] NULL,
	[TINHTRANGSACH] [varchar](100) NULL,
 CONSTRAINT [PK_CHITIET] PRIMARY KEY NONCLUSTERED 
(
	[MASACH] ASC,
	[MAHOADON] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[CHITIET] ([MASACH], [MAHOADON], [SONGAYSUDUNG], [TINHTRANGSACH]) VALUES (N'S02', N'HD1', 3, N'Binh thuong')
INSERT [dbo].[CHITIET] ([MASACH], [MAHOADON], [SONGAYSUDUNG], [TINHTRANGSACH]) VALUES (N'S03', N'HD2', 4, N'Binh thuong')
INSERT [dbo].[CHITIET] ([MASACH], [MAHOADON], [SONGAYSUDUNG], [TINHTRANGSACH]) VALUES (N'S05', N'HD3', 5, N'Binh thuong')
/****** Object:  ForeignKey [FK_CHITIET_CHITIET_HOADONTR]    Script Date: 01/06/2025 17:16:20 ******/
ALTER TABLE [dbo].[CHITIET]  WITH CHECK ADD  CONSTRAINT [FK_CHITIET_CHITIET_HOADONTR] FOREIGN KEY([MAHOADON])
REFERENCES [dbo].[HOADONTRASACH] ([MAHOADON])
GO
ALTER TABLE [dbo].[CHITIET] CHECK CONSTRAINT [FK_CHITIET_CHITIET_HOADONTR]
GO
/****** Object:  ForeignKey [FK_CHITIET_CHITIET2_SACH]    Script Date: 01/06/2025 17:16:20 ******/
ALTER TABLE [dbo].[CHITIET]  WITH CHECK ADD  CONSTRAINT [FK_CHITIET_CHITIET2_SACH] FOREIGN KEY([MASACH])
REFERENCES [dbo].[SACH] ([MASACH])
GO
ALTER TABLE [dbo].[CHITIET] CHECK CONSTRAINT [FK_CHITIET_CHITIET2_SACH]
GO
/****** Object:  ForeignKey [FK_HOADONTR_LIENKET_PHIEUMUO]    Script Date: 01/06/2025 17:16:20 ******/
ALTER TABLE [dbo].[HOADONTRASACH]  WITH CHECK ADD  CONSTRAINT [FK_HOADONTR_LIENKET_PHIEUMUO] FOREIGN KEY([MAPHIEUMUON])
REFERENCES [dbo].[PHIEUMUON] ([MAPHIEUMUON])
GO
ALTER TABLE [dbo].[HOADONTRASACH] CHECK CONSTRAINT [FK_HOADONTR_LIENKET_PHIEUMUO]
GO
/****** Object:  ForeignKey [FK_PHIEUMUO_DANGKY_NGUOIDUN]    Script Date: 01/06/2025 17:16:20 ******/
ALTER TABLE [dbo].[PHIEUMUON]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUMUO_DANGKY_NGUOIDUN] FOREIGN KEY([MANGUOIDUNG])
REFERENCES [dbo].[NGUOIDUNG] ([MANGUOIDUNG])
GO
ALTER TABLE [dbo].[PHIEUMUON] CHECK CONSTRAINT [FK_PHIEUMUO_DANGKY_NGUOIDUN]
GO
/****** Object:  ForeignKey [FK_PHIEUMUO_MUON_SACH]    Script Date: 01/06/2025 17:16:20 ******/
ALTER TABLE [dbo].[PHIEUMUON]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUMUO_MUON_SACH] FOREIGN KEY([MASACH])
REFERENCES [dbo].[SACH] ([MASACH])
GO
ALTER TABLE [dbo].[PHIEUMUON] CHECK CONSTRAINT [FK_PHIEUMUO_MUON_SACH]
GO
/****** Object:  ForeignKey [FK_SACH_CONHIEU_TACGIA]    Script Date: 01/06/2025 17:16:20 ******/
ALTER TABLE [dbo].[SACH]  WITH CHECK ADD  CONSTRAINT [FK_SACH_CONHIEU_TACGIA] FOREIGN KEY([MATACGIA])
REFERENCES [dbo].[TACGIA] ([MATACGIA])
GO
ALTER TABLE [dbo].[SACH] CHECK CONSTRAINT [FK_SACH_CONHIEU_TACGIA]
GO
/****** Object:  ForeignKey [FK_SACH_THUOC_DANHMUC]    Script Date: 01/06/2025 17:16:20 ******/
ALTER TABLE [dbo].[SACH]  WITH CHECK ADD  CONSTRAINT [FK_SACH_THUOC_DANHMUC] FOREIGN KEY([MADANHMUC])
REFERENCES [dbo].[DANHMUC] ([MADANHMUC])
GO
ALTER TABLE [dbo].[SACH] CHECK CONSTRAINT [FK_SACH_THUOC_DANHMUC]
GO
