USE [master]
GO
/****** Object:  Database [Library]    Script Date: 1/6/2024 5:02:59 PM ******/
CREATE DATABASE [Library]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Library', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\Library.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Library_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\Library_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [Library] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Library].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Library] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Library] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Library] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Library] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Library] SET ARITHABORT OFF 
GO
ALTER DATABASE [Library] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Library] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Library] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Library] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Library] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Library] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Library] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Library] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Library] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Library] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Library] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Library] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Library] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Library] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Library] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Library] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Library] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Library] SET RECOVERY FULL 
GO
ALTER DATABASE [Library] SET  MULTI_USER 
GO
ALTER DATABASE [Library] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Library] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Library] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Library] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Library] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Library] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Library', N'ON'
GO
ALTER DATABASE [Library] SET QUERY_STORE = ON
GO
ALTER DATABASE [Library] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [Library]
GO
/****** Object:  Table [dbo].[ChiTietPhieuMuon]    Script Date: 1/6/2024 5:03:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietPhieuMuon](
	[MaCTPM] [int] IDENTITY(1,1) NOT NULL,
	[MaSach] [varchar](6) NOT NULL,
	[SoLuong] [int] NOT NULL,
	[MaPM] [int] NOT NULL,
	[TienDatCoc] [money] NOT NULL,
 CONSTRAINT [PK_ChiTietPhieuMuon] PRIMARY KEY CLUSTERED 
(
	[MaCTPM] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DocGia]    Script Date: 1/6/2024 5:03:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DocGia](
	[MaDocGia] [varchar](6) NOT NULL,
	[TenDocGia] [nvarchar](50) NOT NULL,
	[SDT] [varchar](10) NOT NULL,
	[NgaySinh] [date] NOT NULL,
 CONSTRAINT [PK_DocGia] PRIMARY KEY CLUSTERED 
(
	[MaDocGia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoaDonTraSach]    Script Date: 1/6/2024 5:03:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDonTraSach](
	[MaHD] [int] IDENTITY(1,1) NOT NULL,
	[NgayLapHD] [datetime] NOT NULL,
	[MaPM] [int] NOT NULL,
	[TienThanhToan] [money] NOT NULL,
 CONSTRAINT [PK_HoaDonTraSach] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhaCungCap]    Script Date: 1/6/2024 5:03:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhaCungCap](
	[MaNCC] [varchar](6) NOT NULL,
	[TenNCC] [nvarchar](50) NOT NULL,
	[SDT] [varchar](10) NOT NULL,
	[Email] [varchar](50) NOT NULL,
 CONSTRAINT [PK_NhaCungCap] PRIMARY KEY CLUSTERED 
(
	[MaNCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhieuMuon]    Script Date: 1/6/2024 5:03:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuMuon](
	[MaPM] [int] IDENTITY(1,1) NOT NULL,
	[NgayLapPhieu] [datetime] NOT NULL,
	[MaDocGia] [varchar](6) NOT NULL,
 CONSTRAINT [PK_PhieuMuon] PRIMARY KEY CLUSTERED 
(
	[MaPM] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sach]    Script Date: 1/6/2024 5:03:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sach](
	[MaSach] [varchar](6) NOT NULL,
	[TenSach] [nvarchar](max) NOT NULL,
	[TheLoai] [nvarchar](50) NOT NULL,
	[GiaNhap] [money] NOT NULL,
	[MaTacGia] [varchar](6) NOT NULL,
	[MaNCC] [varchar](6) NOT NULL,
	[SoLuong] [int] NOT NULL,
 CONSTRAINT [PK_Sach] PRIMARY KEY CLUSTERED 
(
	[MaSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TacGia]    Script Date: 1/6/2024 5:03:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TacGia](
	[MaTacGia] [varchar](6) NOT NULL,
	[TenTacGia] [nvarchar](50) NOT NULL,
	[SDT] [varchar](10) NULL,
	[Email] [varchar](50) NOT NULL,
 CONSTRAINT [PK_TacGia] PRIMARY KEY CLUSTERED 
(
	[MaTacGia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[ChiTietPhieuMuon] ON 

INSERT [dbo].[ChiTietPhieuMuon] ([MaCTPM], [MaSach], [SoLuong], [MaPM], [TienDatCoc]) VALUES (37, N'SA0042', 1, 23, 424000.0000)
INSERT [dbo].[ChiTietPhieuMuon] ([MaCTPM], [MaSach], [SoLuong], [MaPM], [TienDatCoc]) VALUES (39, N'SA0036', 1, 23, 984000.0000)
INSERT [dbo].[ChiTietPhieuMuon] ([MaCTPM], [MaSach], [SoLuong], [MaPM], [TienDatCoc]) VALUES (40, N'SA0041', 1, 23, 383000.0000)
INSERT [dbo].[ChiTietPhieuMuon] ([MaCTPM], [MaSach], [SoLuong], [MaPM], [TienDatCoc]) VALUES (41, N'SA0036', 1, 24, 984000.0000)
INSERT [dbo].[ChiTietPhieuMuon] ([MaCTPM], [MaSach], [SoLuong], [MaPM], [TienDatCoc]) VALUES (44, N'SA0037', 1, 25, 790000.0000)
INSERT [dbo].[ChiTietPhieuMuon] ([MaCTPM], [MaSach], [SoLuong], [MaPM], [TienDatCoc]) VALUES (45, N'SA0041', 1, 25, 383000.0000)
INSERT [dbo].[ChiTietPhieuMuon] ([MaCTPM], [MaSach], [SoLuong], [MaPM], [TienDatCoc]) VALUES (46, N'SA0020', 1, 26, 993000.0000)
INSERT [dbo].[ChiTietPhieuMuon] ([MaCTPM], [MaSach], [SoLuong], [MaPM], [TienDatCoc]) VALUES (48, N'SA0026', 1, 26, 192000.0000)
INSERT [dbo].[ChiTietPhieuMuon] ([MaCTPM], [MaSach], [SoLuong], [MaPM], [TienDatCoc]) VALUES (50, N'SA0001', 1, 27, 802000.0000)
INSERT [dbo].[ChiTietPhieuMuon] ([MaCTPM], [MaSach], [SoLuong], [MaPM], [TienDatCoc]) VALUES (51, N'SA0002', 1, 27, 866000.0000)
INSERT [dbo].[ChiTietPhieuMuon] ([MaCTPM], [MaSach], [SoLuong], [MaPM], [TienDatCoc]) VALUES (52, N'SA0044', 1, 27, 280000.0000)
INSERT [dbo].[ChiTietPhieuMuon] ([MaCTPM], [MaSach], [SoLuong], [MaPM], [TienDatCoc]) VALUES (53, N'SA0006', 1, 28, 128000.0000)
INSERT [dbo].[ChiTietPhieuMuon] ([MaCTPM], [MaSach], [SoLuong], [MaPM], [TienDatCoc]) VALUES (54, N'SA0013', 1, 28, 180000.0000)
INSERT [dbo].[ChiTietPhieuMuon] ([MaCTPM], [MaSach], [SoLuong], [MaPM], [TienDatCoc]) VALUES (55, N'SA0022', 1, 28, 255000.0000)
INSERT [dbo].[ChiTietPhieuMuon] ([MaCTPM], [MaSach], [SoLuong], [MaPM], [TienDatCoc]) VALUES (56, N'SA0020', 1, 28, 993000.0000)
INSERT [dbo].[ChiTietPhieuMuon] ([MaCTPM], [MaSach], [SoLuong], [MaPM], [TienDatCoc]) VALUES (57, N'SA0047', 1, 29, 500000.0000)
INSERT [dbo].[ChiTietPhieuMuon] ([MaCTPM], [MaSach], [SoLuong], [MaPM], [TienDatCoc]) VALUES (58, N'SA0044', 1, 29, 280000.0000)
INSERT [dbo].[ChiTietPhieuMuon] ([MaCTPM], [MaSach], [SoLuong], [MaPM], [TienDatCoc]) VALUES (59, N'SA0015', 1, 30, 890000.0000)
INSERT [dbo].[ChiTietPhieuMuon] ([MaCTPM], [MaSach], [SoLuong], [MaPM], [TienDatCoc]) VALUES (60, N'SA0026', 1, 30, 192000.0000)
INSERT [dbo].[ChiTietPhieuMuon] ([MaCTPM], [MaSach], [SoLuong], [MaPM], [TienDatCoc]) VALUES (61, N'SA0036', 1, 30, 984000.0000)
INSERT [dbo].[ChiTietPhieuMuon] ([MaCTPM], [MaSach], [SoLuong], [MaPM], [TienDatCoc]) VALUES (62, N'SA0042', 1, 30, 424000.0000)
INSERT [dbo].[ChiTietPhieuMuon] ([MaCTPM], [MaSach], [SoLuong], [MaPM], [TienDatCoc]) VALUES (64, N'SA0014', 1, 31, 913000.0000)
INSERT [dbo].[ChiTietPhieuMuon] ([MaCTPM], [MaSach], [SoLuong], [MaPM], [TienDatCoc]) VALUES (65, N'SA0006', 1, 31, 128000.0000)
INSERT [dbo].[ChiTietPhieuMuon] ([MaCTPM], [MaSach], [SoLuong], [MaPM], [TienDatCoc]) VALUES (66, N'SA0023', 1, 31, 683000.0000)
INSERT [dbo].[ChiTietPhieuMuon] ([MaCTPM], [MaSach], [SoLuong], [MaPM], [TienDatCoc]) VALUES (67, N'SA0008', 1, 31, 148000.0000)
INSERT [dbo].[ChiTietPhieuMuon] ([MaCTPM], [MaSach], [SoLuong], [MaPM], [TienDatCoc]) VALUES (68, N'SA0001', 1, 32, 802000.0000)
INSERT [dbo].[ChiTietPhieuMuon] ([MaCTPM], [MaSach], [SoLuong], [MaPM], [TienDatCoc]) VALUES (69, N'SA0020', 1, 32, 993000.0000)
INSERT [dbo].[ChiTietPhieuMuon] ([MaCTPM], [MaSach], [SoLuong], [MaPM], [TienDatCoc]) VALUES (70, N'SA0009', 1, 32, 430000.0000)
INSERT [dbo].[ChiTietPhieuMuon] ([MaCTPM], [MaSach], [SoLuong], [MaPM], [TienDatCoc]) VALUES (71, N'SA0041', 1, 32, 383000.0000)
INSERT [dbo].[ChiTietPhieuMuon] ([MaCTPM], [MaSach], [SoLuong], [MaPM], [TienDatCoc]) VALUES (72, N'SA0002', 1, 33, 866000.0000)
INSERT [dbo].[ChiTietPhieuMuon] ([MaCTPM], [MaSach], [SoLuong], [MaPM], [TienDatCoc]) VALUES (73, N'SA0022', 1, 33, 255000.0000)
INSERT [dbo].[ChiTietPhieuMuon] ([MaCTPM], [MaSach], [SoLuong], [MaPM], [TienDatCoc]) VALUES (74, N'SA0014', 1, 33, 913000.0000)
INSERT [dbo].[ChiTietPhieuMuon] ([MaCTPM], [MaSach], [SoLuong], [MaPM], [TienDatCoc]) VALUES (75, N'SA0013', 1, 34, 180000.0000)
INSERT [dbo].[ChiTietPhieuMuon] ([MaCTPM], [MaSach], [SoLuong], [MaPM], [TienDatCoc]) VALUES (76, N'SA0015', 1, 34, 890000.0000)
INSERT [dbo].[ChiTietPhieuMuon] ([MaCTPM], [MaSach], [SoLuong], [MaPM], [TienDatCoc]) VALUES (77, N'SA0026', 1, 34, 192000.0000)
INSERT [dbo].[ChiTietPhieuMuon] ([MaCTPM], [MaSach], [SoLuong], [MaPM], [TienDatCoc]) VALUES (78, N'SA0008', 1, 35, 148000.0000)
INSERT [dbo].[ChiTietPhieuMuon] ([MaCTPM], [MaSach], [SoLuong], [MaPM], [TienDatCoc]) VALUES (79, N'SA0022', 1, 35, 255000.0000)
INSERT [dbo].[ChiTietPhieuMuon] ([MaCTPM], [MaSach], [SoLuong], [MaPM], [TienDatCoc]) VALUES (80, N'SA0006', 1, 35, 128000.0000)
INSERT [dbo].[ChiTietPhieuMuon] ([MaCTPM], [MaSach], [SoLuong], [MaPM], [TienDatCoc]) VALUES (81, N'SA0013', 1, 35, 180000.0000)
SET IDENTITY_INSERT [dbo].[ChiTietPhieuMuon] OFF
GO
INSERT [dbo].[DocGia] ([MaDocGia], [TenDocGia], [SDT], [NgaySinh]) VALUES (N'DG0009', N'Gigi Matthew', N'1855550186', CAST(N'2009-01-09' AS Date))
INSERT [dbo].[DocGia] ([MaDocGia], [TenDocGia], [SDT], [NgaySinh]) VALUES (N'DG0010', N'Michael Raheem', N'3305552568', CAST(N'2009-04-26' AS Date))
INSERT [dbo].[DocGia] ([MaDocGia], [TenDocGia], [SDT], [NgaySinh]) VALUES (N'DG0012', N'Thierry D''Hers', N'1685550183', CAST(N'2007-12-04' AS Date))
INSERT [dbo].[DocGia] ([MaDocGia], [TenDocGia], [SDT], [NgaySinh]) VALUES (N'DG0014', N'Michael Sullivan', N'4655550156', CAST(N'2010-12-23' AS Date))
INSERT [dbo].[DocGia] ([MaDocGia], [TenDocGia], [SDT], [NgaySinh]) VALUES (N'DG0015', N'Sharon Salavaria', N'9705550138', CAST(N'2011-01-11' AS Date))
INSERT [dbo].[DocGia] ([MaDocGia], [TenDocGia], [SDT], [NgaySinh]) VALUES (N'DG0016', N'David Bradlez', N'9135599172', CAST(N'2007-12-13' AS Date))
INSERT [dbo].[DocGia] ([MaDocGia], [TenDocGia], [SDT], [NgaySinh]) VALUES (N'DG0017', N'Kevin Brown', N'1505550189', CAST(N'2007-01-19' AS Date))
INSERT [dbo].[DocGia] ([MaDocGia], [TenDocGia], [SDT], [NgaySinh]) VALUES (N'DG0018', N'John Wood', N'4865550150', CAST(N'2011-01-31' AS Date))
INSERT [dbo].[DocGia] ([MaDocGia], [TenDocGia], [SDT], [NgaySinh]) VALUES (N'DG0019', N'Mary Dempsey', N'1245550100', CAST(N'2011-02-07' AS Date))
INSERT [dbo].[DocGia] ([MaDocGia], [TenDocGia], [SDT], [NgaySinh]) VALUES (N'DG0020', N'Wanida Benshoof', N'7085550141', CAST(N'2010-12-31' AS Date))
INSERT [dbo].[DocGia] ([MaDocGia], [TenDocGia], [SDT], [NgaySinh]) VALUES (N'DG0021', N'Terry Eminhizerasass', N'1385550118', CAST(N'2009-02-23' AS Date))
INSERT [dbo].[DocGia] ([MaDocGia], [TenDocGia], [SDT], [NgaySinh]) VALUES (N'DG0022', N'Sariya Harnpadoungsataya', N'3995550109', CAST(N'2008-12-05' AS Date))
INSERT [dbo].[DocGia] ([MaDocGia], [TenDocGia], [SDT], [NgaySinh]) VALUES (N'DG0024', N'Jill Williams', N'5105550121', CAST(N'2009-01-11' AS Date))
INSERT [dbo].[DocGia] ([MaDocGia], [TenDocGia], [SDT], [NgaySinh]) VALUES (N'DG0026', N'Peter Krebs', N'9135550196', CAST(N'2008-11-24' AS Date))
INSERT [dbo].[DocGia] ([MaDocGia], [TenDocGia], [SDT], [NgaySinh]) VALUES (N'DG0027', N'Jo Brown', N'6325550129', CAST(N'2008-02-20' AS Date))
INSERT [dbo].[DocGia] ([MaDocGia], [TenDocGia], [SDT], [NgaySinh]) VALUES (N'DG0028', N'Guy Gilbert', N'3205550195', CAST(N'2006-06-23' AS Date))
INSERT [dbo].[DocGia] ([MaDocGia], [TenDocGia], [SDT], [NgaySinh]) VALUES (N'DG0030', N'Britta Simon', N'9555550169', CAST(N'2009-01-22' AS Date))
INSERT [dbo].[DocGia] ([MaDocGia], [TenDocGia], [SDT], [NgaySinh]) VALUES (N'DG0031', N'Margie Shoop', N'8185550128', CAST(N'2008-12-28' AS Date))
INSERT [dbo].[DocGia] ([MaDocGia], [TenDocGia], [SDT], [NgaySinh]) VALUES (N'DG0032', N'Rebecca Laszlo', N'3145550113', CAST(N'2008-12-22' AS Date))
INSERT [dbo].[DocGia] ([MaDocGia], [TenDocGia], [SDT], [NgaySinh]) VALUES (N'DG0033', N'Annik Stahl', N'4995550125', CAST(N'2008-12-10' AS Date))
INSERT [dbo].[DocGia] ([MaDocGia], [TenDocGia], [SDT], [NgaySinh]) VALUES (N'DG0034', N'Suchitra Mohan', N'7535550129', CAST(N'2009-02-09' AS Date))
INSERT [dbo].[DocGia] ([MaDocGia], [TenDocGia], [SDT], [NgaySinh]) VALUES (N'DG0035', N'Brandon Heidepriem', N'4295550137', CAST(N'2009-02-01' AS Date))
INSERT [dbo].[DocGia] ([MaDocGia], [TenDocGia], [SDT], [NgaySinh]) VALUES (N'DG0036', N'Jose Lugo', N'5875550115', CAST(N'2009-02-03' AS Date))
INSERT [dbo].[DocGia] ([MaDocGia], [TenDocGia], [SDT], [NgaySinh]) VALUES (N'DG0037', N'Chris Okelberry', N'3155550144', CAST(N'2009-02-28' AS Date))
INSERT [dbo].[DocGia] ([MaDocGia], [TenDocGia], [SDT], [NgaySinh]) VALUES (N'DG0038', N'Kim Abercrombie', N'2085550114', CAST(N'2010-01-09' AS Date))
INSERT [dbo].[DocGia] ([MaDocGia], [TenDocGia], [SDT], [NgaySinh]) VALUES (N'DG0039', N'Ed Dudenhoefer', N'9195550140', CAST(N'2010-01-29' AS Date))
INSERT [dbo].[DocGia] ([MaDocGia], [TenDocGia], [SDT], [NgaySinh]) VALUES (N'DG0040', N'JoLynn Dobney', N'9035550145', CAST(N'2007-12-19' AS Date))
INSERT [dbo].[DocGia] ([MaDocGia], [TenDocGia], [SDT], [NgaySinh]) VALUES (N'DG0041', N'Bryan Baker', N'7125550113', CAST(N'2009-01-14' AS Date))
INSERT [dbo].[DocGia] ([MaDocGia], [TenDocGia], [SDT], [NgaySinh]) VALUES (N'DG0042', N'James Kramer', N'1195550117', CAST(N'2008-12-20' AS Date))
INSERT [dbo].[DocGia] ([MaDocGia], [TenDocGia], [SDT], [NgaySinh]) VALUES (N'DG0043', N'Nancy Anderson', N'9705550118', CAST(N'2008-12-26' AS Date))
INSERT [dbo].[DocGia] ([MaDocGia], [TenDocGia], [SDT], [NgaySinh]) VALUES (N'DG0044', N'Simon Rapier', N'9635550134', CAST(N'2008-12-01' AS Date))
INSERT [dbo].[DocGia] ([MaDocGia], [TenDocGia], [SDT], [NgaySinh]) VALUES (N'DG0045', N'Thomas Michaels', N'2785550118', CAST(N'2009-02-19' AS Date))
INSERT [dbo].[DocGia] ([MaDocGia], [TenDocGia], [SDT], [NgaySinh]) VALUES (N'DG0046', N'Eugene Kogan', N'1735550179', CAST(N'2009-02-01' AS Date))
INSERT [dbo].[DocGia] ([MaDocGia], [TenDocGia], [SDT], [NgaySinh]) VALUES (N'DG0047', N'Andrew Hill', N'9085550159', CAST(N'2009-02-15' AS Date))
INSERT [dbo].[DocGia] ([MaDocGia], [TenDocGia], [SDT], [NgaySinh]) VALUES (N'DG0048', N'Ruth Ellerbrock', N'1455550130', CAST(N'2007-12-30' AS Date))
INSERT [dbo].[DocGia] ([MaDocGia], [TenDocGia], [SDT], [NgaySinh]) VALUES (N'DG0049', N'Barry Johnson', N'2065550180', CAST(N'2013-11-29' AS Date))
INSERT [dbo].[DocGia] ([MaDocGia], [TenDocGia], [SDT], [NgaySinh]) VALUES (N'DG0050', N'Sidney Higa', N'4245550189', CAST(N'2008-01-26' AS Date))
INSERT [dbo].[DocGia] ([MaDocGia], [TenDocGia], [SDT], [NgaySinh]) VALUES (N'DG0051', N'Jeffrey Ford', N'9845550185', CAST(N'2008-02-13' AS Date))
INSERT [dbo].[DocGia] ([MaDocGia], [TenDocGia], [SDT], [NgaySinh]) VALUES (N'DG0052', N'Doris Hartwig', N'3285550150', CAST(N'2014-01-31' AS Date))
INSERT [dbo].[DocGia] ([MaDocGia], [TenDocGia], [SDT], [NgaySinh]) VALUES (N'DG0053', N'Diane Glimp', N'2025550151', CAST(N'2008-03-21' AS Date))
INSERT [dbo].[DocGia] ([MaDocGia], [TenDocGia], [SDT], [NgaySinh]) VALUES (N'DG0054', N'Bonnie Kearney', N'2645550150', CAST(N'2009-12-25' AS Date))
INSERT [dbo].[DocGia] ([MaDocGia], [TenDocGia], [SDT], [NgaySinh]) VALUES (N'DG0055', N'Taylor Maxwell', N'5085550165', CAST(N'2013-12-31' AS Date))
INSERT [dbo].[DocGia] ([MaDocGia], [TenDocGia], [SDT], [NgaySinh]) VALUES (N'DG0056', N'Denise Smith', N'8695550119', CAST(N'2009-01-29' AS Date))
INSERT [dbo].[DocGia] ([MaDocGia], [TenDocGia], [SDT], [NgaySinh]) VALUES (N'DG0057', N'Frank Miller', N'1675550139', CAST(N'2009-02-16' AS Date))
INSERT [dbo].[DocGia] ([MaDocGia], [TenDocGia], [SDT], [NgaySinh]) VALUES (N'DG0058', N'Kendall Keil', N'1385550128', CAST(N'2008-11-28' AS Date))
INSERT [dbo].[DocGia] ([MaDocGia], [TenDocGia], [SDT], [NgaySinh]) VALUES (N'DG0059', N'Bob Hohman', N'6115550116', CAST(N'2008-12-17' AS Date))
INSERT [dbo].[DocGia] ([MaDocGia], [TenDocGia], [SDT], [NgaySinh]) VALUES (N'DG0060', N'Pete Male', N'7685550123', CAST(N'2009-01-04' AS Date))
INSERT [dbo].[DocGia] ([MaDocGia], [TenDocGia], [SDT], [NgaySinh]) VALUES (N'DG0061', N'Diane Tibbott', N'3615550180', CAST(N'2009-01-11' AS Date))
INSERT [dbo].[DocGia] ([MaDocGia], [TenDocGia], [SDT], [NgaySinh]) VALUES (N'DG0062', N'John Campbezz', N'4355550112', CAST(N'2014-02-07' AS Date))
INSERT [dbo].[DocGia] ([MaDocGia], [TenDocGia], [SDT], [NgaySinh]) VALUES (N'DG0063', N'Maciej Dusza', N'2375550128', CAST(N'2010-01-22' AS Date))
INSERT [dbo].[DocGia] ([MaDocGia], [TenDocGia], [SDT], [NgaySinh]) VALUES (N'DG0064', N'Michael Zwilling', N'5825550148', CAST(N'2010-02-16' AS Date))
INSERT [dbo].[DocGia] ([MaDocGia], [TenDocGia], [SDT], [NgaySinh]) VALUES (N'DG0065', N'Randy Reeves', N'9615550122', CAST(N'2010-02-16' AS Date))
INSERT [dbo].[DocGia] ([MaDocGia], [TenDocGia], [SDT], [NgaySinh]) VALUES (N'DG0066', N'Karan Khanna', N'4475550186', CAST(N'2009-12-15' AS Date))
INSERT [dbo].[DocGia] ([MaDocGia], [TenDocGia], [SDT], [NgaySinh]) VALUES (N'DG0067', N'Jay Adams', N'4075550165', CAST(N'2009-02-26' AS Date))
INSERT [dbo].[DocGia] ([MaDocGia], [TenDocGia], [SDT], [NgaySinh]) VALUES (N'DG0068', N'Charles Fitzgerald', N'9315550118', CAST(N'2009-11-26' AS Date))
INSERT [dbo].[DocGia] ([MaDocGia], [TenDocGia], [SDT], [NgaySinh]) VALUES (N'DG0069', N'Steve Masters', N'7125550170', CAST(N'2009-02-08' AS Date))
INSERT [dbo].[DocGia] ([MaDocGia], [TenDocGia], [SDT], [NgaySinh]) VALUES (N'DG0070', N'David Ortiz', N'7125550119', CAST(N'2008-12-08' AS Date))
INSERT [dbo].[DocGia] ([MaDocGia], [TenDocGia], [SDT], [NgaySinh]) VALUES (N'DG0071', N'Michael Ray', N'1565550199', CAST(N'2009-02-08' AS Date))
INSERT [dbo].[DocGia] ([MaDocGia], [TenDocGia], [SDT], [NgaySinh]) VALUES (N'DG0072', N'Steven Selikoff', N'9255550114', CAST(N'2008-11-24' AS Date))
INSERT [dbo].[DocGia] ([MaDocGia], [TenDocGia], [SDT], [NgaySinh]) VALUES (N'DG0073', N'Carole Poland', N'6885550192', CAST(N'2008-12-12' AS Date))
INSERT [dbo].[DocGia] ([MaDocGia], [TenDocGia], [SDT], [NgaySinh]) VALUES (N'DG0074', N'Bjorn Rettig', N'1995550117', CAST(N'2008-12-31' AS Date))
INSERT [dbo].[DocGia] ([MaDocGia], [TenDocGia], [SDT], [NgaySinh]) VALUES (N'DG0075', N'Michiko Osada', N'9845550148', CAST(N'2009-01-19' AS Date))
INSERT [dbo].[DocGia] ([MaDocGia], [TenDocGia], [SDT], [NgaySinh]) VALUES (N'DG0076', N'Carol Philips', N'6095550153', CAST(N'2009-02-05' AS Date))
INSERT [dbo].[DocGia] ([MaDocGia], [TenDocGia], [SDT], [NgaySinh]) VALUES (N'DG0077', N'Merav Netz', N'2245550187', CAST(N'2009-02-24' AS Date))
INSERT [dbo].[DocGia] ([MaDocGia], [TenDocGia], [SDT], [NgaySinh]) VALUES (N'DG0078', N'Reuben D ju sa', N'1915550112', CAST(N'2008-12-08' AS Date))
INSERT [dbo].[DocGia] ([MaDocGia], [TenDocGia], [SDT], [NgaySinh]) VALUES (N'DG0079', N'Eric Brown', N'6805550118', CAST(N'2010-01-17' AS Date))
INSERT [dbo].[DocGia] ([MaDocGia], [TenDocGia], [SDT], [NgaySinh]) VALUES (N'DG0080', N'Sandeep Kaliyath', N'1665550156', CAST(N'2010-01-10' AS Date))
INSERT [dbo].[DocGia] ([MaDocGia], [TenDocGia], [SDT], [NgaySinh]) VALUES (N'DG0081', N'Mihail Frintu', N'7335550128', CAST(N'2009-12-22' AS Date))
INSERT [dbo].[DocGia] ([MaDocGia], [TenDocGia], [SDT], [NgaySinh]) VALUES (N'DG0082', N'Jack Creasey', N'5215550113', CAST(N'2010-02-24' AS Date))
INSERT [dbo].[DocGia] ([MaDocGia], [TenDocGia], [SDT], [NgaySinh]) VALUES (N'DG0083', N'Patrick Cook', N'4255550117', CAST(N'2010-02-05' AS Date))
INSERT [dbo].[DocGia] ([MaDocGia], [TenDocGia], [SDT], [NgaySinh]) VALUES (N'DG0084', N'Frank Martinez', N'2035550196', CAST(N'2010-01-29' AS Date))
INSERT [dbo].[DocGia] ([MaDocGia], [TenDocGia], [SDT], [NgaySinh]) VALUES (N'DG0085', N'Brian Goldstein', N'7305550117', CAST(N'2009-12-04' AS Date))
INSERT [dbo].[DocGia] ([MaDocGia], [TenDocGia], [SDT], [NgaySinh]) VALUES (N'DG0086', N'Ryan Cornelsen', N'2085550114', CAST(N'2008-12-29' AS Date))
INSERT [dbo].[DocGia] ([MaDocGia], [TenDocGia], [SDT], [NgaySinh]) VALUES (N'DG0087', N'Cristian Petculescu', N'4345550133', CAST(N'2008-12-15' AS Date))
INSERT [dbo].[DocGia] ([MaDocGia], [TenDocGia], [SDT], [NgaySinh]) VALUES (N'DG0088', N'Betsy Stadick', N'4055550171', CAST(N'2009-12-11' AS Date))
INSERT [dbo].[DocGia] ([MaDocGia], [TenDocGia], [SDT], [NgaySinh]) VALUES (N'DG0089', N'Patrick Wedte', N'4135550198', CAST(N'2010-01-25' AS Date))
INSERT [dbo].[DocGia] ([MaDocGia], [TenDocGia], [SDT], [NgaySinh]) VALUES (N'DG0090', N'Danielle Tienv', N'5005550109', CAST(N'2004-06-15' AS Date))
INSERT [dbo].[DocGia] ([MaDocGia], [TenDocGia], [SDT], [NgaySinh]) VALUES (N'DG0091', N'Kimberly Zimermanz', N'1235550167', CAST(N'2010-01-05' AS Date))
INSERT [dbo].[DocGia] ([MaDocGia], [TenDocGia], [SDT], [NgaySinh]) VALUES (N'DG0092', N'Tom Vande Velde', N'2955550161', CAST(N'2010-03-03' AS Date))
INSERT [dbo].[DocGia] ([MaDocGia], [TenDocGia], [SDT], [NgaySinh]) VALUES (N'DG0093', N'Kok Ho Log', N'9995550109', CAST(N'2008-12-20' AS Date))
INSERT [dbo].[DocGia] ([MaDocGia], [TenDocGia], [SDT], [NgaySinh]) VALUES (N'DG0094', N'Russell Hunter', N'7865550144', CAST(N'2008-12-05' AS Date))
INSERT [dbo].[DocGia] ([MaDocGia], [TenDocGia], [SDT], [NgaySinh]) VALUES (N'DG0097', N'Mandar Samant', N'1405550132', CAST(N'2009-02-03' AS Date))
INSERT [dbo].[DocGia] ([MaDocGia], [TenDocGia], [SDT], [NgaySinh]) VALUES (N'DG0098', N'Sameer Tejani', N'9905550172', CAST(N'2009-02-04' AS Date))
INSERT [dbo].[DocGia] ([MaDocGia], [TenDocGia], [SDT], [NgaySinh]) VALUES (N'DG0099', N'Nuan Yu', N'9135550184', CAST(N'2008-12-30' AS Date))
INSERT [dbo].[DocGia] ([MaDocGia], [TenDocGia], [SDT], [NgaySinh]) VALUES (N'DG0100', N'Trần Văn Cương', N'0218256264', CAST(N'2004-06-22' AS Date))
INSERT [dbo].[DocGia] ([MaDocGia], [TenDocGia], [SDT], [NgaySinh]) VALUES (N'DG0101', N'Nguyễn Anh Quốc', N'0858038081', CAST(N'2001-11-15' AS Date))
INSERT [dbo].[DocGia] ([MaDocGia], [TenDocGia], [SDT], [NgaySinh]) VALUES (N'DG0102', N'Nguyễn Văn A', N'0874269336', CAST(N'2005-06-14' AS Date))
INSERT [dbo].[DocGia] ([MaDocGia], [TenDocGia], [SDT], [NgaySinh]) VALUES (N'DG0103', N'Nguyễn Thanh Hải', N'0551120', CAST(N'2015-07-16' AS Date))
INSERT [dbo].[DocGia] ([MaDocGia], [TenDocGia], [SDT], [NgaySinh]) VALUES (N'DG0104', N'Nguyễn Trung Hiếu', N'0874256398', CAST(N'2004-06-15' AS Date))
INSERT [dbo].[DocGia] ([MaDocGia], [TenDocGia], [SDT], [NgaySinh]) VALUES (N'DG0105', N'asdasd', N'312', CAST(N'2023-04-13' AS Date))
INSERT [dbo].[DocGia] ([MaDocGia], [TenDocGia], [SDT], [NgaySinh]) VALUES (N'DG0106', N'czsdssa', N'22', CAST(N'2023-04-26' AS Date))
INSERT [dbo].[DocGia] ([MaDocGia], [TenDocGia], [SDT], [NgaySinh]) VALUES (N'DG0108', N'Nguyễn Văn Hoàng Hải', N'0248369190', CAST(N'2002-03-27' AS Date))
INSERT [dbo].[DocGia] ([MaDocGia], [TenDocGia], [SDT], [NgaySinh]) VALUES (N'DG0111', N'Hà Thị Linh', N'0858035419', CAST(N'2023-04-26' AS Date))
INSERT [dbo].[DocGia] ([MaDocGia], [TenDocGia], [SDT], [NgaySinh]) VALUES (N'DG0112', N'Nguyễn Quốc', N'095849933', CAST(N'2003-05-05' AS Date))
GO
SET IDENTITY_INSERT [dbo].[HoaDonTraSach] ON 

INSERT [dbo].[HoaDonTraSach] ([MaHD], [NgayLapHD], [MaPM], [TienThanhToan]) VALUES (20, CAST(N'2023-04-23T23:49:10.390' AS DateTime), 27, 21230.0000)
INSERT [dbo].[HoaDonTraSach] ([MaHD], [NgayLapHD], [MaPM], [TienThanhToan]) VALUES (21, CAST(N'2023-04-23T23:56:49.167' AS DateTime), 24, 984000.0000)
INSERT [dbo].[HoaDonTraSach] ([MaHD], [NgayLapHD], [MaPM], [TienThanhToan]) VALUES (22, CAST(N'2023-04-23T23:57:22.910' AS DateTime), 23, 2091000.0000)
INSERT [dbo].[HoaDonTraSach] ([MaHD], [NgayLapHD], [MaPM], [TienThanhToan]) VALUES (23, CAST(N'2023-04-23T23:57:26.373' AS DateTime), 26, 1669000.0000)
INSERT [dbo].[HoaDonTraSach] ([MaHD], [NgayLapHD], [MaPM], [TienThanhToan]) VALUES (24, CAST(N'2023-04-23T23:57:31.093' AS DateTime), 25, 2373000.0000)
INSERT [dbo].[HoaDonTraSach] ([MaHD], [NgayLapHD], [MaPM], [TienThanhToan]) VALUES (25, CAST(N'2023-04-26T18:14:00.380' AS DateTime), 32, 2608000.0000)
INSERT [dbo].[HoaDonTraSach] ([MaHD], [NgayLapHD], [MaPM], [TienThanhToan]) VALUES (26, CAST(N'2023-04-26T18:14:08.833' AS DateTime), 30, 2491000.0000)
INSERT [dbo].[HoaDonTraSach] ([MaHD], [NgayLapHD], [MaPM], [TienThanhToan]) VALUES (27, CAST(N'2023-04-26T18:14:55.247' AS DateTime), 32, 2608000.0000)
INSERT [dbo].[HoaDonTraSach] ([MaHD], [NgayLapHD], [MaPM], [TienThanhToan]) VALUES (28, CAST(N'2023-05-08T21:59:19.163' AS DateTime), 33, 26442000.0000)
INSERT [dbo].[HoaDonTraSach] ([MaHD], [NgayLapHD], [MaPM], [TienThanhToan]) VALUES (29, CAST(N'2023-05-09T07:18:53.253' AS DateTime), 35, 711000.0000)
SET IDENTITY_INSERT [dbo].[HoaDonTraSach] OFF
GO
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [SDT], [Email]) VALUES (N'NCC001', N'Exotic Liquids', N'1715552222', N'CharlotteCooper@gmail.com')
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [SDT], [Email]) VALUES (N'NCC002', N'New Orleans Cajun Delights', N'1005554822', N'ShelleyBurke@gmail.com')
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [SDT], [Email]) VALUES (N'NCC003', N'Grandma Kelly''s Homestead', N'3135555735', N'ReginaMurphy@gmail.com')
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [SDT], [Email]) VALUES (N'NCC004', N'Tokyo Traders', N'0335555011', N'YoshiNagase@gmail.com')
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [SDT], [Email]) VALUES (N'NCC005', N'Cooperativa de Quesos ''Las Cabras''', N'985987654', N'AntoniodelValleSaavedra@gmail.com')
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [SDT], [Email]) VALUES (N'NCC007', N'Pavlova, Ltd.', N'034442343', N'IanDevling@gmail.com')
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [SDT], [Email]) VALUES (N'NCC008', N'Specialty Biscuits, Ltd.', N'1615554448', N'PeterWilson@gmail.com')
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [SDT], [Email]) VALUES (N'NCC009', N'PB Knäckebröd AB', N'0319876543', N'LarsPeterson@gmail.com')
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [SDT], [Email]) VALUES (N'NCC010', N'Refrescos Americanas LTDA', N'115554640', N'CarlosDiaz@gmail.com')
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [SDT], [Email]) VALUES (N'NCC011', N'Heli Süßwaren GmbH & Co. KG', N'0109984510', N'PetraWinkler@gmail.com')
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [SDT], [Email]) VALUES (N'NCC012', N'Plutzer Lebensmittelgroßmärkte AG', N'0699927325', N'MartinBein@gmail.com')
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [SDT], [Email]) VALUES (N'NCC013', N'Nord-Ost-Fisch Handelsgesellschaft mbH', N'047218713', N'SvenPetersen@gmail.com')
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [SDT], [Email]) VALUES (N'NCC014', N'Formaggi Fortini s.r.l.', N'054460323', N'ElioRossi@gmail.com')
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [SDT], [Email]) VALUES (N'NCC015', N'Norske Meierier', N'02953010', N'BeateVileid@gmail.com')
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [SDT], [Email]) VALUES (N'NCC016', N'Bigfoot Breweries', N'5035559931', N'CherylSaylor@gmail.com')
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [SDT], [Email]) VALUES (N'NCC017', N'Svensk Sjöföda AB', N'081234567', N'MichaelBjörn@gmail.com')
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [SDT], [Email]) VALUES (N'NCC019', N'New England Seafood Cannery', N'6175553267', N'RobbMerchant@gmail.com')
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [SDT], [Email]) VALUES (N'NCC020', N'Leka Tradinz', N'5558780', N'ChandraLeka@gmail.com')
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [SDT], [Email]) VALUES (N'NCC021', N'Lyngbysild', N'43844108', N'NielsPetersen@gmail.com')
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [SDT], [Email]) VALUES (N'NCC022', N'Zaanse Snoepfabriek', N'123451212', N'DirkLuchte@gmail.com')
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [SDT], [Email]) VALUES (N'NCC023', N'Karkki Oy', N'95310956', N'AnneHeikkonen@gmail.com')
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [SDT], [Email]) VALUES (N'NCC024', N'G''day, Mate', N'025555914', N'WendyMackenzie@gmail.com')
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [SDT], [Email]) VALUES (N'NCC025', N'Ma Maison', N'5145559022', N'Jean-GuyLauzon@gmail.com')
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [SDT], [Email]) VALUES (N'NCC026', N'Pasta Buttini s.r.l.', N'0896547665', N'GiovanniGiudici@gmail.com')
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [SDT], [Email]) VALUES (N'NCC029', N'Forêts d''érables', N'5145552955', N'ChantalGoulet@gmail.com')
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [SDT], [Email]) VALUES (N'NCC030', N'NXB Hồng Trà', N'025885117', N'anhquoc@gmail.com')
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [SDT], [Email]) VALUES (N'NCC031', N'asdas', N'9109230120', N'shasah@fm.com')
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [SDT], [Email]) VALUES (N'NCC032', N'zxzxcz', N'255', N'FG@GMAIL.COM')
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [SDT], [Email]) VALUES (N'NCC033', N'dsdsds', N'02215', N'dasdadsdsad')
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [SDT], [Email]) VALUES (N'NCC034', N'sdada', N'13123', N'aeadsas')
GO
SET IDENTITY_INSERT [dbo].[PhieuMuon] ON 

INSERT [dbo].[PhieuMuon] ([MaPM], [NgayLapPhieu], [MaDocGia]) VALUES (23, CAST(N'2023-04-23T23:48:04.703' AS DateTime), N'DG0021')
INSERT [dbo].[PhieuMuon] ([MaPM], [NgayLapPhieu], [MaDocGia]) VALUES (24, CAST(N'2023-04-23T23:48:11.773' AS DateTime), N'DG0021')
INSERT [dbo].[PhieuMuon] ([MaPM], [NgayLapPhieu], [MaDocGia]) VALUES (25, CAST(N'2023-04-23T23:48:19.580' AS DateTime), N'DG0017')
INSERT [dbo].[PhieuMuon] ([MaPM], [NgayLapPhieu], [MaDocGia]) VALUES (26, CAST(N'2023-04-23T23:48:27.870' AS DateTime), N'DG0033')
INSERT [dbo].[PhieuMuon] ([MaPM], [NgayLapPhieu], [MaDocGia]) VALUES (27, CAST(N'2023-04-23T23:48:40.637' AS DateTime), N'DG0059')
INSERT [dbo].[PhieuMuon] ([MaPM], [NgayLapPhieu], [MaDocGia]) VALUES (28, CAST(N'2023-04-26T13:52:44.807' AS DateTime), N'DG0012')
INSERT [dbo].[PhieuMuon] ([MaPM], [NgayLapPhieu], [MaDocGia]) VALUES (29, CAST(N'2023-04-26T13:53:50.680' AS DateTime), N'DG0100')
INSERT [dbo].[PhieuMuon] ([MaPM], [NgayLapPhieu], [MaDocGia]) VALUES (30, CAST(N'2023-04-26T16:24:13.350' AS DateTime), N'DG0036')
INSERT [dbo].[PhieuMuon] ([MaPM], [NgayLapPhieu], [MaDocGia]) VALUES (31, CAST(N'2023-04-26T16:24:51.350' AS DateTime), N'DG0051')
INSERT [dbo].[PhieuMuon] ([MaPM], [NgayLapPhieu], [MaDocGia]) VALUES (32, CAST(N'2023-04-26T18:12:00.467' AS DateTime), N'DG0012')
INSERT [dbo].[PhieuMuon] ([MaPM], [NgayLapPhieu], [MaDocGia]) VALUES (33, CAST(N'2023-04-26T18:12:45.757' AS DateTime), N'DG0014')
INSERT [dbo].[PhieuMuon] ([MaPM], [NgayLapPhieu], [MaDocGia]) VALUES (34, CAST(N'2023-05-08T21:59:12.900' AS DateTime), N'DG0012')
INSERT [dbo].[PhieuMuon] ([MaPM], [NgayLapPhieu], [MaDocGia]) VALUES (35, CAST(N'2023-05-09T07:16:06.293' AS DateTime), N'DG0010')
SET IDENTITY_INSERT [dbo].[PhieuMuon] OFF
GO
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TheLoai], [GiaNhap], [MaTacGia], [MaNCC], [SoLuong]) VALUES (N'SA0001', N'Harry Potter và Hòn đá phù thủy', N'Tiểu thuyết', 802000.0000, N'TG0001', N'NCC004', 14)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TheLoai], [GiaNhap], [MaTacGia], [MaNCC], [SoLuong]) VALUES (N'SA0002', N'Harry Potter và Phòng chứa bí mật', N'Tiểu thuyết', 866000.0000, N'TG0001', N'NCC020', 1)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TheLoai], [GiaNhap], [MaTacGia], [MaNCC], [SoLuong]) VALUES (N'SA0006', N'Tiếng anh giao tiếp cho người mới bắt đầu', N'Kỹ năng mềm', 128000.0000, N'TG0004', N'NCC022', 7)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TheLoai], [GiaNhap], [MaTacGia], [MaNCC], [SoLuong]) VALUES (N'SA0008', N'Nhà Giả Kim', N'Tiểu thuyết', 148000.0000, N'TG0006', N'NCC013', 15)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TheLoai], [GiaNhap], [MaTacGia], [MaNCC], [SoLuong]) VALUES (N'SA0009', N'Nghệ thuật sống thọ', N'Kiến thức phổ thông', 430000.0000, N'TG0007', N'NCC016', 16)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TheLoai], [GiaNhap], [MaTacGia], [MaNCC], [SoLuong]) VALUES (N'SA0013', N'Think and Grow Rich', N'Kiến thức phổ thông', 180000.0000, N'TG0010', N'NCC024', 11)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TheLoai], [GiaNhap], [MaTacGia], [MaNCC], [SoLuong]) VALUES (N'SA0014', N'Người giàu nhất thành Babylon', N'SA0014', 913000.0000, N'TG0016', N'NCC002', 8)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TheLoai], [GiaNhap], [MaTacGia], [MaNCC], [SoLuong]) VALUES (N'SA0015', N'Tiếng Anh cho người mới bắt đầu', N'Kỹ năng mềm', 890000.0000, N'TG0012', N'NCC019', 0)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TheLoai], [GiaNhap], [MaTacGia], [MaNCC], [SoLuong]) VALUES (N'SA0020', N'Làn sóng xanh', N'SA0020', 993000.0000, N'TG0015', N'NCC026', 19)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TheLoai], [GiaNhap], [MaTacGia], [MaNCC], [SoLuong]) VALUES (N'SA0022', N'Trên đường băng', N'Tiểu thuyết', 255000.0000, N'TG0016', N'NCC015', 14)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TheLoai], [GiaNhap], [MaTacGia], [MaNCC], [SoLuong]) VALUES (N'SA0023', N'Phong cách sống Hygge: Bí mật hạnh phúc người Đan Mạch', N'SA0023', 683000.0000, N'TG0017', N'NCC002', 1)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TheLoai], [GiaNhap], [MaTacGia], [MaNCC], [SoLuong]) VALUES (N'SA0026', N'Lập trình với Python', N'Kỹ năng mềm', 192000.0000, N'TG0020', N'NCC005', 8)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TheLoai], [GiaNhap], [MaTacGia], [MaNCC], [SoLuong]) VALUES (N'SA0027', N'Bóng ma trong nhà hát', N'Văn học nước ngoài', 412000.0000, N'TG0021', N'NCC012', 9)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TheLoai], [GiaNhap], [MaTacGia], [MaNCC], [SoLuong]) VALUES (N'SA0028', N'Bí quyết giữ chồng', N'SA0028', 300000.0000, N'TG0022', N'NCC014', 20)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TheLoai], [GiaNhap], [MaTacGia], [MaNCC], [SoLuong]) VALUES (N'SA0029', N'Phong cách lãnh đạo dành cho người phụ nữ', N'Kỹ năng mềm', 345000.0000, N'TG0023', N'NCC026', 12)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TheLoai], [GiaNhap], [MaTacGia], [MaNCC], [SoLuong]) VALUES (N'SA0030', N'Nhà Giả Kim (bản tiếng Anh)', N'Tiểu thuyết', 954000.0000, N'TG0006', N'NCC010', 8)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TheLoai], [GiaNhap], [MaTacGia], [MaNCC], [SoLuong]) VALUES (N'SA0031', N'Chuyện con mèo dạy hải âu bay', N'SA0031', 294000.0000, N'TG0003', N'NCC012', 9)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TheLoai], [GiaNhap], [MaTacGia], [MaNCC], [SoLuong]) VALUES (N'SA0032', N'Bán đảo Peninsula: Nơi hoang sơ nhất Việt Nam', N'Sách du lịch', 504000.0000, N'TG0024', N'NCC025', 17)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TheLoai], [GiaNhap], [MaTacGia], [MaNCC], [SoLuong]) VALUES (N'SA0033', N'Cẩm nang nuôi dạy con từ 0-10 tuổi', N'Kiến thức phổ thông', 941000.0000, N'TG0025', N'NCC011', 4)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TheLoai], [GiaNhap], [MaTacGia], [MaNCC], [SoLuong]) VALUES (N'SA0034', N'Tôi là Bá Chủ Cuộc Đời', N'SA0034', 369000.0000, N'TG0026', N'NCC019', 10)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TheLoai], [GiaNhap], [MaTacGia], [MaNCC], [SoLuong]) VALUES (N'SA0035', N'Tiếng Chim Hót Trong Bụi Mận Gai', N'SA0035', 727000.0000, N'TG0027', N'NCC026', 2)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TheLoai], [GiaNhap], [MaTacGia], [MaNCC], [SoLuong]) VALUES (N'SA0036', N'Tư duy tích cực', N'SA0036', 984000.0000, N'TG0012', N'NCC014', 20)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TheLoai], [GiaNhap], [MaTacGia], [MaNCC], [SoLuong]) VALUES (N'SA0037', N'Nghìn Lẻ Một Đêm', N'Văn học nước ngoài', 790000.0000, N'TG0029', N'NCC008', 1)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TheLoai], [GiaNhap], [MaTacGia], [MaNCC], [SoLuong]) VALUES (N'SA0038', N'Tôi Tài Giỏi - Bạn Cũng Thế', N'Kiến thức phổ thông', 265000.0000, N'TG0005', N'NCC010', 13)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TheLoai], [GiaNhap], [MaTacGia], [MaNCC], [SoLuong]) VALUES (N'SA0039', N'Những Người Khốn Khổ', N'SA0039', 125000.0000, N'TG0030', N'NCC015', 12)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TheLoai], [GiaNhap], [MaTacGia], [MaNCC], [SoLuong]) VALUES (N'SA0041', N'Người Nhện: Người đàn ông đầu tiên (tập 1)', N'Truyện tranh', 383000.0000, N'TG0032', N'NCC029', 16)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TheLoai], [GiaNhap], [MaTacGia], [MaNCC], [SoLuong]) VALUES (N'SA0042', N'Tôi Tài Giỏi, Bạn Cũng Thế (Tập 2)', N'Kiến thức phổ thông', 424000.0000, N'TG0005', N'NCC021', 12)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TheLoai], [GiaNhap], [MaTacGia], [MaNCC], [SoLuong]) VALUES (N'SA0044', N'Cho tôi một vé đi tuổi thơ', N'Tiểu thuyết', 280000.0000, N'TG0001', N'NCC001', 12)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TheLoai], [GiaNhap], [MaTacGia], [MaNCC], [SoLuong]) VALUES (N'SA0047', N'Harry Potter (Bản mới)', N'Truyện Tranh', 500000.0000, N'TG0026', N'NCC023', 19)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TheLoai], [GiaNhap], [MaTacGia], [MaNCC], [SoLuong]) VALUES (N'SA0048', N'Cách Nghĩ Để Thành Công (bản mới)', N'SA0048', 200000.0000, N'TG0018', N'NCC026', 8)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TheLoai], [GiaNhap], [MaTacGia], [MaNCC], [SoLuong]) VALUES (N'SA0050', N'Nhà Giả Kim (bản tiếng Pháp)', N'SA0050', 200000.0000, N'TG0031', N'NCC030', 20)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TheLoai], [GiaNhap], [MaTacGia], [MaNCC], [SoLuong]) VALUES (N'SA0052', N'gffgdgfd', N'dg', 1000.0000, N'TG0001', N'NCC001', 0)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TheLoai], [GiaNhap], [MaTacGia], [MaNCC], [SoLuong]) VALUES (N'SA0053', N'Nhà Giả Kim (bản làm lại)', N'Tiểu Thuyết', 100000.0000, N'TG0017', N'NCC015', 52)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TheLoai], [GiaNhap], [MaTacGia], [MaNCC], [SoLuong]) VALUES (N'SA0054', N'Bí kíp sống lâu', N'Cuộc Sống', 150000.0000, N'TG0019', N'NCC017', 25)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TheLoai], [GiaNhap], [MaTacGia], [MaNCC], [SoLuong]) VALUES (N'SA0055', N'Test 5', N'Kỹ Năng Mềm', 100000.0000, N'TG0001', N'NCC001', 90)
GO
INSERT [dbo].[TacGia] ([MaTacGia], [TenTacGia], [SDT], [Email]) VALUES (N'TG0001', N'J.K. Rowling', N'0203111254', N'Rowling@gmail.com')
INSERT [dbo].[TacGia] ([MaTacGia], [TenTacGia], [SDT], [Email]) VALUES (N'TG0002', N'Dale Carnegie', N'0396948886', N'Carnegie@gmail.com')
INSERT [dbo].[TacGia] ([MaTacGia], [TenTacGia], [SDT], [Email]) VALUES (N'TG0003', N'Nguyễn Nhật Ánh', N'0627068173', N'Anh@gmail.com')
INSERT [dbo].[TacGia] ([MaTacGia], [TenTacGia], [SDT], [Email]) VALUES (N'TG0004', N'Phạm Văn Toàn', N'0832005747', N'Van@gmail.com')
INSERT [dbo].[TacGia] ([MaTacGia], [TenTacGia], [SDT], [Email]) VALUES (N'TG0005', N'Adam Khoo', N'0173289648', N'Khoo@gmail.com')
INSERT [dbo].[TacGia] ([MaTacGia], [TenTacGia], [SDT], [Email]) VALUES (N'TG0006', N'Paulo Coelho', N'0557936236', N'Coelho@gmail.com')
INSERT [dbo].[TacGia] ([MaTacGia], [TenTacGia], [SDT], [Email]) VALUES (N'TG0007', N'Viktor E. Frankl', N'0305735283', N'Frankl@gmail.com')
INSERT [dbo].[TacGia] ([MaTacGia], [TenTacGia], [SDT], [Email]) VALUES (N'TG0008', N'Nhật Linhw', N'0365940500', N'Linh@gmail.com')
INSERT [dbo].[TacGia] ([MaTacGia], [TenTacGia], [SDT], [Email]) VALUES (N'TG0009', N'Nguyễn Hiền Lê', N'0658126990', N'Le@gmail.com')
INSERT [dbo].[TacGia] ([MaTacGia], [TenTacGia], [SDT], [Email]) VALUES (N'TG0010', N'Napoleon Hill', N'0241444825', N'Hill@gmail.com')
INSERT [dbo].[TacGia] ([MaTacGia], [TenTacGia], [SDT], [Email]) VALUES (N'TG0011', N'George S. Clason', N'0797024630', N'Clason@gmail.com')
INSERT [dbo].[TacGia] ([MaTacGia], [TenTacGia], [SDT], [Email]) VALUES (N'TG0012', N'Trần Văn Toàn', N'0184058714', N'Toàn@gmail.com')
INSERT [dbo].[TacGia] ([MaTacGia], [TenTacGia], [SDT], [Email]) VALUES (N'TG0013', N'Sigmund Freud', N'0435792618', N'Freud@gmail.com')
INSERT [dbo].[TacGia] ([MaTacGia], [TenTacGia], [SDT], [Email]) VALUES (N'TG0014', N'Phan Ðặng Nhật Nam', N'0978384508', N'Nam@gmail.com')
INSERT [dbo].[TacGia] ([MaTacGia], [TenTacGia], [SDT], [Email]) VALUES (N'TG0015', N'Trần Nhật Phong', N'0614133027', N'Phong@gmail.com')
INSERT [dbo].[TacGia] ([MaTacGia], [TenTacGia], [SDT], [Email]) VALUES (N'TG0016', N'Nguyễn Phan Quý Mai', N'0588251401', N'Mai@gmail.com')
INSERT [dbo].[TacGia] ([MaTacGia], [TenTacGia], [SDT], [Email]) VALUES (N'TG0017', N'Meik Wiking', N'0119355489', N'Wiking@gmail.com')
INSERT [dbo].[TacGia] ([MaTacGia], [TenTacGia], [SDT], [Email]) VALUES (N'TG0018', N'Kim Dung', N'0436505956', N'Dung@gmail.com')
INSERT [dbo].[TacGia] ([MaTacGia], [TenTacGia], [SDT], [Email]) VALUES (N'TG0019', N'J.R.R. Tolkien', N'0315959792', N'Tolkien@gmail.com')
INSERT [dbo].[TacGia] ([MaTacGia], [TenTacGia], [SDT], [Email]) VALUES (N'TG0020', N'Matt Rassett', N'0959792006', N'Rassett@gmail.com')
INSERT [dbo].[TacGia] ([MaTacGia], [TenTacGia], [SDT], [Email]) VALUES (N'TG0021', N'Gaston Leroux', N'0823711420', N'Leroux@gmail.com')
INSERT [dbo].[TacGia] ([MaTacGia], [TenTacGia], [SDT], [Email]) VALUES (N'TG0022', N'Michelle McKinney Hammond', N'0798341879', N'Hammond@gmail.com')
INSERT [dbo].[TacGia] ([MaTacGia], [TenTacGia], [SDT], [Email]) VALUES (N'TG0023', N'Nancy D. OReilly', N'0793330266', N'OReilly@gmail.com')
INSERT [dbo].[TacGia] ([MaTacGia], [TenTacGia], [SDT], [Email]) VALUES (N'TG0024', N'Phạm Trần', N'0367342199', N'Tran@gmail.com')
INSERT [dbo].[TacGia] ([MaTacGia], [TenTacGia], [SDT], [Email]) VALUES (N'TG0025', N'Trần Thị Thu Thuỷ', N'0175675131', N'Thuy@gmail.com')
INSERT [dbo].[TacGia] ([MaTacGia], [TenTacGia], [SDT], [Email]) VALUES (N'TG0026', N'Tony Robbins', N'0935259489', N'Robbins@gmail.com')
INSERT [dbo].[TacGia] ([MaTacGia], [TenTacGia], [SDT], [Email]) VALUES (N'TG0027', N'Colleen McCullough', N'0397063898', N'McCullough@gmail.com')
INSERT [dbo].[TacGia] ([MaTacGia], [TenTacGia], [SDT], [Email]) VALUES (N'TG0028', N'Norman Vincent Peale', N'095128009', N'Peale@gmail.com')
INSERT [dbo].[TacGia] ([MaTacGia], [TenTacGia], [SDT], [Email]) VALUES (N'TG0029', N'Tác giả không rõ', N'null', N'null')
INSERT [dbo].[TacGia] ([MaTacGia], [TenTacGia], [SDT], [Email]) VALUES (N'TG0030', N'Victor Hugo', N'0302774033', N'Hugo@gmail.com')
INSERT [dbo].[TacGia] ([MaTacGia], [TenTacGia], [SDT], [Email]) VALUES (N'TG0031', N'Wilhelm Grimm và Jacob Grimm', N'0768309881', N'Grimm@gmail.com')
INSERT [dbo].[TacGia] ([MaTacGia], [TenTacGia], [SDT], [Email]) VALUES (N'TG0032', N'Stan Lee và Steve Ditko', N'0619191086', N'Ditko@gmail.com')
INSERT [dbo].[TacGia] ([MaTacGia], [TenTacGia], [SDT], [Email]) VALUES (N'TG0034', N'Nguyễn Anh Quốc', N'0858038090', N'anhquoc885z@gmail.com')
INSERT [dbo].[TacGia] ([MaTacGia], [TenTacGia], [SDT], [Email]) VALUES (N'TG0036', N'Hồ thị x', N'01455', N'hcb@gmail.com')
INSERT [dbo].[TacGia] ([MaTacGia], [TenTacGia], [SDT], [Email]) VALUES (N'TG0037', N'dsadasdsazx', N'23121', N'dasda')
INSERT [dbo].[TacGia] ([MaTacGia], [TenTacGia], [SDT], [Email]) VALUES (N'TG0038', N'dsada', N'2321', N'sadxzxzxsds')
INSERT [dbo].[TacGia] ([MaTacGia], [TenTacGia], [SDT], [Email]) VALUES (N'TG0039', N'Lý Văn Bình', N'0258456324', N'binhlv@gmail.com')
INSERT [dbo].[TacGia] ([MaTacGia], [TenTacGia], [SDT], [Email]) VALUES (N'TG0040', N'sdzzszsfdsds', N'42342346', N'qaweasz')
INSERT [dbo].[TacGia] ([MaTacGia], [TenTacGia], [SDT], [Email]) VALUES (N'TG0041', N'Nguyễn B', N'0979878798', N'B@gmail.com')
GO
ALTER TABLE [dbo].[ChiTietPhieuMuon]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPhieuMuon_PhieuMuon] FOREIGN KEY([MaPM])
REFERENCES [dbo].[PhieuMuon] ([MaPM])
GO
ALTER TABLE [dbo].[ChiTietPhieuMuon] CHECK CONSTRAINT [FK_ChiTietPhieuMuon_PhieuMuon]
GO
ALTER TABLE [dbo].[ChiTietPhieuMuon]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPhieuMuon_Sach] FOREIGN KEY([MaSach])
REFERENCES [dbo].[Sach] ([MaSach])
GO
ALTER TABLE [dbo].[ChiTietPhieuMuon] CHECK CONSTRAINT [FK_ChiTietPhieuMuon_Sach]
GO
ALTER TABLE [dbo].[ChiTietPhieuMuon]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPhieuMuon_Sach_DELETE] FOREIGN KEY([MaSach])
REFERENCES [dbo].[Sach] ([MaSach])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ChiTietPhieuMuon] CHECK CONSTRAINT [FK_ChiTietPhieuMuon_Sach_DELETE]
GO
ALTER TABLE [dbo].[HoaDonTraSach]  WITH CHECK ADD  CONSTRAINT [FK_HoaDonTraSach_PhieuMuon] FOREIGN KEY([MaPM])
REFERENCES [dbo].[PhieuMuon] ([MaPM])
GO
ALTER TABLE [dbo].[HoaDonTraSach] CHECK CONSTRAINT [FK_HoaDonTraSach_PhieuMuon]
GO
ALTER TABLE [dbo].[HoaDonTraSach]  WITH CHECK ADD  CONSTRAINT [FK_HoaDonTraSach_PhieuMuon_DELETE] FOREIGN KEY([MaPM])
REFERENCES [dbo].[PhieuMuon] ([MaPM])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[HoaDonTraSach] CHECK CONSTRAINT [FK_HoaDonTraSach_PhieuMuon_DELETE]
GO
ALTER TABLE [dbo].[PhieuMuon]  WITH CHECK ADD  CONSTRAINT [FK_PhieuMuon_DocGia] FOREIGN KEY([MaDocGia])
REFERENCES [dbo].[DocGia] ([MaDocGia])
GO
ALTER TABLE [dbo].[PhieuMuon] CHECK CONSTRAINT [FK_PhieuMuon_DocGia]
GO
ALTER TABLE [dbo].[PhieuMuon]  WITH CHECK ADD  CONSTRAINT [FK_PhieuMuon_Sach_DELETE] FOREIGN KEY([MaDocGia])
REFERENCES [dbo].[DocGia] ([MaDocGia])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PhieuMuon] CHECK CONSTRAINT [FK_PhieuMuon_Sach_DELETE]
GO
ALTER TABLE [dbo].[Sach]  WITH CHECK ADD  CONSTRAINT [FK_Sach_NCC_DELETE] FOREIGN KEY([MaNCC])
REFERENCES [dbo].[NhaCungCap] ([MaNCC])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Sach] CHECK CONSTRAINT [FK_Sach_NCC_DELETE]
GO
ALTER TABLE [dbo].[Sach]  WITH CHECK ADD  CONSTRAINT [FK_Sach_NhaCungCap] FOREIGN KEY([MaNCC])
REFERENCES [dbo].[NhaCungCap] ([MaNCC])
GO
ALTER TABLE [dbo].[Sach] CHECK CONSTRAINT [FK_Sach_NhaCungCap]
GO
ALTER TABLE [dbo].[Sach]  WITH CHECK ADD  CONSTRAINT [FK_Sach_TacGia] FOREIGN KEY([MaTacGia])
REFERENCES [dbo].[TacGia] ([MaTacGia])
GO
ALTER TABLE [dbo].[Sach] CHECK CONSTRAINT [FK_Sach_TacGia]
GO
ALTER TABLE [dbo].[Sach]  WITH CHECK ADD  CONSTRAINT [FK_Sach_TacGia_DELETE] FOREIGN KEY([MaTacGia])
REFERENCES [dbo].[TacGia] ([MaTacGia])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Sach] CHECK CONSTRAINT [FK_Sach_TacGia_DELETE]
GO
USE [master]
GO
ALTER DATABASE [Library] SET  READ_WRITE 
GO
