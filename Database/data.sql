USE [master]
GO
/****** Object:  Database [QLRAUMAMIXX]    Script Date: 1/3/2022 8:03:44 PM ******/
CREATE DATABASE [QLRAUMAMIXX]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QLRAUMAMIXX', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\QLRAUMAMIXX.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QLRAUMAMIXX_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\QLRAUMAMIXX_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [QLRAUMAMIXX] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLRAUMAMIXX].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLRAUMAMIXX] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLRAUMAMIXX] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLRAUMAMIXX] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLRAUMAMIXX] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLRAUMAMIXX] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLRAUMAMIXX] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [QLRAUMAMIXX] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLRAUMAMIXX] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLRAUMAMIXX] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLRAUMAMIXX] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLRAUMAMIXX] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLRAUMAMIXX] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLRAUMAMIXX] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLRAUMAMIXX] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLRAUMAMIXX] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QLRAUMAMIXX] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLRAUMAMIXX] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLRAUMAMIXX] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLRAUMAMIXX] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLRAUMAMIXX] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLRAUMAMIXX] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLRAUMAMIXX] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLRAUMAMIXX] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QLRAUMAMIXX] SET  MULTI_USER 
GO
ALTER DATABASE [QLRAUMAMIXX] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLRAUMAMIXX] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLRAUMAMIXX] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLRAUMAMIXX] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QLRAUMAMIXX] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QLRAUMAMIXX] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [QLRAUMAMIXX] SET QUERY_STORE = OFF
GO
USE [QLRAUMAMIXX]
GO
/****** Object:  UserDefinedFunction [dbo].[fuConvertToUnsign1]    Script Date: 1/3/2022 8:03:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create FUNCTION [dbo].[fuConvertToUnsign1] ( @strInput NVARCHAR(4000) ) RETURNS NVARCHAR(4000) AS BEGIN IF @strInput IS NULL RETURN @strInput IF @strInput = '' RETURN @strInput DECLARE @RT NVARCHAR(4000) DECLARE @SIGN_CHARS NCHAR(136) DECLARE @UNSIGN_CHARS NCHAR (136) SET @SIGN_CHARS = N'ăâđêôơưàảãạáằẳẵặắầẩẫậấèẻẽẹéềểễệế ìỉĩịíòỏõọóồổỗộốờởỡợớùủũụúừửữựứỳỷỹỵý ĂÂĐÊÔƠƯÀẢÃẠÁẰẲẴẶẮẦẨẪẬẤÈẺẼẸÉỀỂỄỆẾÌỈĨỊÍ ÒỎÕỌÓỒỔỖỘỐỜỞỠỢỚÙỦŨỤÚỪỬỮỰỨỲỶỸỴÝ' +NCHAR(272)+ NCHAR(208) SET @UNSIGN_CHARS = N'aadeoouaaaaaaaaaaaaaaaeeeeeeeeee iiiiiooooooooooooooouuuuuuuuuuyyyyy AADEOOUAAAAAAAAAAAAAAAEEEEEEEEEEIIIII OOOOOOOOOOOOOOOUUUUUUUUUUYYYYYDD' DECLARE @COUNTER int DECLARE @COUNTER1 int SET @COUNTER = 1 WHILE (@COUNTER <=LEN(@strInput)) BEGIN SET @COUNTER1 = 1 WHILE (@COUNTER1 <=LEN(@SIGN_CHARS)+1) BEGIN IF UNICODE(SUBSTRING(@SIGN_CHARS, @COUNTER1,1)) = UNICODE(SUBSTRING(@strInput,@COUNTER ,1) ) BEGIN IF @COUNTER=1 SET @strInput = SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)-1) ELSE SET @strInput = SUBSTRING(@strInput, 1, @COUNTER-1) +SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)- @COUNTER) BREAK END SET @COUNTER1 = @COUNTER1 +1 END SET @COUNTER = @COUNTER +1 END SET @strInput = replace(@strInput,' ','-') RETURN @strInput END
GO
/****** Object:  Table [dbo].[Account]    Script Date: 1/3/2022 8:03:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[DisplayName] [nvarchar](100) NOT NULL,
	[UserName] [nvarchar](100) NOT NULL,
	[PassWord] [nvarchar](1000) NOT NULL,
	[Type] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Bill]    Script Date: 1/3/2022 8:03:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bill](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[DateCheckIn] [date] NOT NULL,
	[DateCheckOut] [date] NULL,
	[idTable] [int] NOT NULL,
	[status] [int] NOT NULL,
	[discount] [int] NULL,
	[totalPrice] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BillInfo]    Script Date: 1/3/2022 8:03:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BillInfo](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idBill] [int] NOT NULL,
	[idFood] [int] NOT NULL,
	[count] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Food]    Script Date: 1/3/2022 8:03:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Food](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](100) NOT NULL,
	[idCategory] [int] NOT NULL,
	[price] [float] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FoodCategory]    Script Date: 1/3/2022 8:03:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FoodCategory](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 1/3/2022 8:03:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[idKh] [int] IDENTITY(1,1) NOT NULL,
	[TenKh] [nvarchar](100) NOT NULL,
	[GioiTinh] [nvarchar](10) NOT NULL,
	[Diachi] [nvarchar](100) NOT NULL,
	[SDT] [nvarchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idKh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TableFood]    Script Date: 1/3/2022 8:03:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TableFood](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](100) NOT NULL,
	[status] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Account] ON 

INSERT [dbo].[Account] ([id], [DisplayName], [UserName], [PassWord], [Type]) VALUES (1, N'Huynh Hong Ngan', N'HuynhNgan', N'123', 1)
INSERT [dbo].[Account] ([id], [DisplayName], [UserName], [PassWord], [Type]) VALUES (2, N'staff', N'staff', N'1', 0)
SET IDENTITY_INSERT [dbo].[Account] OFF
GO
SET IDENTITY_INSERT [dbo].[Bill] ON 

INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [totalPrice]) VALUES (2, CAST(N'2022-01-02' AS Date), CAST(N'2022-01-03' AS Date), 2, 1, 1, 79.2)
INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [totalPrice]) VALUES (3, CAST(N'2022-01-02' AS Date), CAST(N'2022-01-02' AS Date), 3, 1, NULL, NULL)
INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [totalPrice]) VALUES (4, CAST(N'2022-01-02' AS Date), CAST(N'2022-01-02' AS Date), 4, 1, NULL, NULL)
INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [totalPrice]) VALUES (5, CAST(N'2022-01-02' AS Date), CAST(N'2022-01-03' AS Date), 5, 1, 1, 67.32)
INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [totalPrice]) VALUES (6, CAST(N'2022-01-02' AS Date), CAST(N'2022-01-02' AS Date), 6, 1, NULL, NULL)
INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [totalPrice]) VALUES (7, CAST(N'2022-01-03' AS Date), CAST(N'2022-01-03' AS Date), 8, 1, 1, 67.32)
INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [totalPrice]) VALUES (8, CAST(N'2022-01-03' AS Date), CAST(N'2022-01-03' AS Date), 1, 1, 1, 39.6)
INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [totalPrice]) VALUES (9, CAST(N'2022-01-03' AS Date), CAST(N'2022-01-03' AS Date), 2, 1, 1, 21.78)
INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [totalPrice]) VALUES (10, CAST(N'2022-01-03' AS Date), CAST(N'2022-01-03' AS Date), 4, 1, 1, 66.33)
INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [totalPrice]) VALUES (11, CAST(N'2022-01-03' AS Date), CAST(N'2022-01-03' AS Date), 1, 1, 1, 27.72)
INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [totalPrice]) VALUES (12, CAST(N'2022-01-03' AS Date), CAST(N'2022-01-03' AS Date), 1, 1, 1, 27.72)
INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [totalPrice]) VALUES (13, CAST(N'2022-01-03' AS Date), CAST(N'2022-01-03' AS Date), 2, 1, 1, 59.4)
SET IDENTITY_INSERT [dbo].[Bill] OFF
GO
SET IDENTITY_INSERT [dbo].[BillInfo] ON 

INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (2, 2, 2, 2)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (3, 7, 6, 2)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (7, 10, 5, 1)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (8, 8, 8, 2)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (9, 10, 15, 2)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (10, 11, 1, 1)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (11, 9, 3, 1)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (12, 12, 1, 1)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (13, 13, 10, 1)
INSERT [dbo].[BillInfo] ([id], [idBill], [idFood], [count]) VALUES (14, 13, 16, 1)
SET IDENTITY_INSERT [dbo].[BillInfo] OFF
GO
SET IDENTITY_INSERT [dbo].[Food] ON 

INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (1, N'Rau má đậu xanh mix Macchiato', 1, 28000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (2, N'Rau má mix Macchiato', 1, 26000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (3, N'Rau Má Mix Sầu Riêng Sữa Dừa (MỚI)', 1, 22000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (4, N'Rau má nguyên chất', 1, 12000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (5, N'Rau má sữa dừa', 1, 15000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (6, N'Rau má mix đậu xanh sữa dừa', 1, 20000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (7, N'Rau má mix khoai môn sữa dừa', 1, 20000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (8, N'Đậu xanh sữa dừa', 1, 20000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (9, N'Khoai môn sữa dừa', 1, 20000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (10, N'(Combo 2) Rau má mix đậu xanh sữa dừa + Thạch nha đam + Thạch lá dứa + Trân châu tuyết trắng', 2, 30000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (11, N'(Combo 7) Rau má mix sầu riêng sữa dừa + Thạch nha đam + Sương sáo hạt chia + Thạch lá dứa', 2, 32000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (12, N'(Combo 8) Rau má mix sầu riêng sữa dữa + thạch củ năng + thạch lá dứa + trân châu tuyết trắng', 2, 32000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (13, N'(Combo 6) Khoai môn sữa dừa + Sương sáo hạt chia + Thạch lá dứa + Trân châu tuyết trắng', 2, 30000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (14, N'(Combo 5) Đậu xanh sữa dừa + Trân châu lá dứa + Thạch củ năng + Thạch lá dứa', 2, 30000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (15, N'(Combo 4) Rau má sữa dừa + Thạch củ năng + Sương sáo hạt chia + Trân châu tuyết trắng', 2, 26000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (16, N'(Combo 3) Rau má Mix Khoai Môn Sữa Dừa + Thạch lá dứa + Thạch củ năng + Sương sáo hạt chia', 2, 30000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (17, N'(Combo 1) Rau má mix đậu xanh sữa dừa + Trân châu lá dứa + Thạch củ năng + Sương sáo hạt chia', 2, 30000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (18, N'Bánh Tráng Mix Tôm Hành', 3, 18000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (19, N'Bánh Tráng Mix Khô Bò', 3, 18000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (20, N'Bánh Tráng Mix Phô Mai', 3, 18000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (21, N'Bánh Tráng Mix Khô Gà Lá Chanh', 3, 18000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (22, N'Bánh tráng trộn', 3, 20000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (23, N'Sương Sáo Hạt Chia', 4, 7000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (24, N'Thạch củ năng', 4, 7000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (25, N'Thạch lá dứa', 4, 5000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (26, N'Trân châu lá dứa', 4, 5000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (27, N'Trân châu tuyết trắng', 4, 5000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (28, N'Khoai Tây Chiên', 5, 20000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (29, N'Bánh Plan', 5, 10000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (30, N'7 Up', 6, 16000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (31, N'STing', 6, 16000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (32, N'CoCa', 6, 16000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (33, N'Khăn lạnh', 6, 3000)
SET IDENTITY_INSERT [dbo].[Food] OFF
GO
SET IDENTITY_INSERT [dbo].[FoodCategory] ON 

INSERT [dbo].[FoodCategory] ([id], [name]) VALUES (1, N'RAU MÁ MIX ')
INSERT [dbo].[FoodCategory] ([id], [name]) VALUES (2, N'COMBO RAU MÁ MIX')
INSERT [dbo].[FoodCategory] ([id], [name]) VALUES (3, N'BÁNH TRÁNG MIX')
INSERT [dbo].[FoodCategory] ([id], [name]) VALUES (4, N'TOPPING')
INSERT [dbo].[FoodCategory] ([id], [name]) VALUES (5, N'ĂN VẶT')
INSERT [dbo].[FoodCategory] ([id], [name]) VALUES (6, N'CÁC LOẠI NƯỚC KHÁC')
INSERT [dbo].[FoodCategory] ([id], [name]) VALUES (7, N'RAU MÁ MIX ')
SET IDENTITY_INSERT [dbo].[FoodCategory] OFF
GO
SET IDENTITY_INSERT [dbo].[KhachHang] ON 

INSERT [dbo].[KhachHang] ([idKh], [TenKh], [GioiTinh], [Diachi], [SDT]) VALUES (1, N'Nguyễn Văn B', N'Nam', N'xã Mỹ Long Nam-CN-TVinh', N'0987654321')
INSERT [dbo].[KhachHang] ([idKh], [TenKh], [GioiTinh], [Diachi], [SDT]) VALUES (2, N'Nguyễn Thị Bông', N'Nu', N'xã Mỹ Long Bắc-CN-TVinh', N'0987654345')
INSERT [dbo].[KhachHang] ([idKh], [TenKh], [GioiTinh], [Diachi], [SDT]) VALUES (3, N'Lê Văn La', N'Nam', N'xã Log Hữu-Duyên Hải-TVinh', N'0988654322')
INSERT [dbo].[KhachHang] ([idKh], [TenKh], [GioiTinh], [Diachi], [SDT]) VALUES (4, N'Trần Thị Trầm', N'Nu', N'xã Mỹ Long Nam-CN-TVinh', N'0989614526')
SET IDENTITY_INSERT [dbo].[KhachHang] OFF
GO
SET IDENTITY_INSERT [dbo].[TableFood] ON 

INSERT [dbo].[TableFood] ([id], [name], [status]) VALUES (1, N'Bàn 1', N'Trống')
INSERT [dbo].[TableFood] ([id], [name], [status]) VALUES (2, N'Bàn 2', N'Trống')
INSERT [dbo].[TableFood] ([id], [name], [status]) VALUES (3, N'Bàn 3', N'Trống')
INSERT [dbo].[TableFood] ([id], [name], [status]) VALUES (4, N'Bàn 4', N'Trống')
INSERT [dbo].[TableFood] ([id], [name], [status]) VALUES (5, N'Bàn 5', N'Trống')
INSERT [dbo].[TableFood] ([id], [name], [status]) VALUES (6, N'Bàn 6', N'Trống')
INSERT [dbo].[TableFood] ([id], [name], [status]) VALUES (7, N'Bàn 7', N'Trống')
INSERT [dbo].[TableFood] ([id], [name], [status]) VALUES (8, N'Bàn 8', N'Trống')
INSERT [dbo].[TableFood] ([id], [name], [status]) VALUES (9, N'Bàn 9', N'Trống')
INSERT [dbo].[TableFood] ([id], [name], [status]) VALUES (10, N'Bàn 10', N'Trống')
SET IDENTITY_INSERT [dbo].[TableFood] OFF
GO
ALTER TABLE [dbo].[Account] ADD  DEFAULT (N'Admin') FOR [DisplayName]
GO
ALTER TABLE [dbo].[Account] ADD  DEFAULT ((0)) FOR [UserName]
GO
ALTER TABLE [dbo].[Account] ADD  DEFAULT ((0)) FOR [PassWord]
GO
ALTER TABLE [dbo].[Account] ADD  DEFAULT ((0)) FOR [Type]
GO
ALTER TABLE [dbo].[Bill] ADD  DEFAULT (getdate()) FOR [DateCheckIn]
GO
ALTER TABLE [dbo].[BillInfo] ADD  DEFAULT ((0)) FOR [count]
GO
ALTER TABLE [dbo].[Food] ADD  DEFAULT ((0)) FOR [price]
GO
ALTER TABLE [dbo].[FoodCategory] ADD  DEFAULT (N'Chưa đặt tên') FOR [name]
GO
ALTER TABLE [dbo].[TableFood] ADD  DEFAULT (N'Bàn chưa đặt tên') FOR [name]
GO
ALTER TABLE [dbo].[TableFood] ADD  DEFAULT (N'Trống') FOR [status]
GO
ALTER TABLE [dbo].[Bill]  WITH CHECK ADD  CONSTRAINT [fk_Bill_TableFood] FOREIGN KEY([idTable])
REFERENCES [dbo].[TableFood] ([id])
GO
ALTER TABLE [dbo].[Bill] CHECK CONSTRAINT [fk_Bill_TableFood]
GO
ALTER TABLE [dbo].[BillInfo]  WITH CHECK ADD  CONSTRAINT [fk_BillInfo_Bill] FOREIGN KEY([idBill])
REFERENCES [dbo].[Bill] ([id])
GO
ALTER TABLE [dbo].[BillInfo] CHECK CONSTRAINT [fk_BillInfo_Bill]
GO
ALTER TABLE [dbo].[BillInfo]  WITH CHECK ADD  CONSTRAINT [fk_BillInfo_Food] FOREIGN KEY([idFood])
REFERENCES [dbo].[Food] ([id])
GO
ALTER TABLE [dbo].[BillInfo] CHECK CONSTRAINT [fk_BillInfo_Food]
GO
ALTER TABLE [dbo].[Food]  WITH CHECK ADD  CONSTRAINT [fk_Food_FoodCategory] FOREIGN KEY([idCategory])
REFERENCES [dbo].[FoodCategory] ([id])
GO
ALTER TABLE [dbo].[Food] CHECK CONSTRAINT [fk_Food_FoodCategory]
GO
/****** Object:  StoredProcedure [dbo].[_bill]    Script Date: 1/3/2022 8:03:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[_bill]
@idTable int
as
begin
select b.idTable,f.name,bi.count,f.price,((f.price* bi.count)-((f.price*bi.count/100)*b.discount)) as totalPrice 
from dbo.Bill as b, dbo.BillInfo as bi,dbo.Food as f 
where bi.idBill = b.id and bi.idFood = f.id and b.status= 0 and b.idTable =@idTable
end 
GO
/****** Object:  StoredProcedure [dbo].[P_ThanhToan]    Script Date: 1/3/2022 8:03:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---trigger để xóa TableFood
create proc [dbo].[P_ThanhToan]
(@idTable int)
as
begin
select TableFood.id, Food.Name, Food.Price, BillInfo.count,((Food.Price*BillInfo.count)-((Food.Price*BillInfo.count/100)*Bill.discount)) as Total
from [TableFood]
join Bill on TableFood.id=Bill.idTable
join BillInfo on Bill.id=BillInfo.idBill
join Food on Food.id=BillInfo.idFood
where Bill.id=BillInfo.idBill and BillInfo.id=TableFood.id and TableFood.id=@idTable
end
GO
/****** Object:  StoredProcedure [dbo].[USP_GetAccountByUserName]    Script Date: 1/3/2022 8:03:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROC [dbo].[USP_GetAccountByUserName]
@userName nvarchar(100) 
as 
begin 
  select * from dbo.Account Where UserName=@userName
end
GO
/****** Object:  StoredProcedure [dbo].[USP_GetListBillByDate]    Script Date: 1/3/2022 8:03:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[USP_GetListBillByDate]
@checkIn date, @checkOut date
as
begin
SELECT t.name as [Tên bàn],b.totalPrice as [Tổng tiền],DateCheckIn as [Ngày vào],DateCheckOut as [Ngày ra],discount as [Giảm giá]
 FROM dbo.Bill as b,dbo.TableFood as t ,dbo.BillInfo as bi,dbo.Food as f
 WHERE DateCheckIn>= @checkIn  and DateCheckOut<= @checkOut  and b.status=1
  and t.id= b.idTable and bi.idBill=b.id and bi.idFood=f.id
end
GO
/****** Object:  StoredProcedure [dbo].[USP_GetListBillByDateAndPage]    Script Date: 1/3/2022 8:03:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[USP_GetListBillByDateAndPage]
@checkIn date, @checkOut date, @page int
as
begin
	declare @pageRows int = 10
	declare @selectRows int = @pageRows 
	declare @exceptRows int =(@page-1) * @pageRows

	;WITH ShowBill as (select b.id, t.name as [Tên bàn], b.totalPrice as [Tổng tiền], DateCheckIn as [Ngày vào], DateCheckOut as [Ngày ra],discount as [Giảm giá]
	FROM dbo.Bill as b,dbo.TableFood as t ,dbo.BillInfo as bi,dbo.Food as f
	WHERE DateCheckIn>= @checkIn  and DateCheckOut<= @checkOut  and b.status=1
	and t.id= b.idTable and bi.idBill=b.id and bi.idFood=f.id)
	
	select top (@selectRows) * from ShowBill where id not in (select top (@exceptRows) id from ShowBill)

	
end
GO
/****** Object:  StoredProcedure [dbo].[USP_GetListBillByDateForReport]    Script Date: 1/3/2022 8:03:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[USP_GetListBillByDateForReport]
@checkIn date, @checkOut date
as
begin
SELECT t.name ,b.totalPrice ,DateCheckIn ,DateCheckOut ,discount 
 FROM dbo.Bill as b,dbo.TableFood as t ,dbo.BillInfo as bi,dbo.Food as f
 WHERE DateCheckIn>= @checkIn  and DateCheckOut<= @checkOut  and b.status=1
  and t.id= b.idTable and bi.idBill=b.id and bi.idFood=f.id
end
GO
/****** Object:  StoredProcedure [dbo].[USP_GetNumBillByDate]    Script Date: 1/3/2022 8:03:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[USP_GetNumBillByDate]
@checkIn date, @checkOut date
as
begin
	
	select count(*)
	FROM dbo.Bill as b,dbo.TableFood as t ,dbo.BillInfo as bi,dbo.Food as f
	WHERE DateCheckIn>= @checkIn  and DateCheckOut<= @checkOut  and b.status=1
	and t.id= b.idTable and bi.idBill=b.id and bi.idFood=f.id

end
GO
/****** Object:  StoredProcedure [dbo].[USP_GetTableList]    Script Date: 1/3/2022 8:03:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[USP_GetTableList]
 as select * from dbo.TableFood
GO
/****** Object:  StoredProcedure [dbo].[USP_InsertBill]    Script Date: 1/3/2022 8:03:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[USP_InsertBill]
@idTable int
as
begin

INSERT dbo.Bill(DateCheckIn,DateCheckOut,idTable,status,discount,totalPrice)
	VALUES (GETDATE(),--DATECHECKIN - DATE
		NULL,--DATECHECKOUT - DATE,
		@idTable,
		0	,0,0.0	)
end
GO
/****** Object:  StoredProcedure [dbo].[USP_InsertBillInfo]    Script Date: 1/3/2022 8:03:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[USP_InsertBillInfo]
@idBill INT, @idFood INT, @count INT
AS
BEGIN

	DECLARE @isExitsBillInfo INT
	DECLARE @foodCount INT = 1
	
	SELECT @isExitsBillInfo = id, @foodCount = b.count 
	FROM dbo.BillInfo AS b 
	WHERE idBill = @idBill AND idFood = @idFood

	IF (@isExitsBillInfo > 0)
	BEGIN
		DECLARE @newCount INT = @foodCount + @count
		IF (@newCount > 0)
			UPDATE dbo.BillInfo	SET count = @foodCount + @count WHERE idFood = @idFood
		ELSE
			DELETE dbo.BillInfo WHERE idBill = @idBill AND idFood = @idFood
	END
	ELSE
	BEGIN
		INSERT	dbo.BillInfo
        ( idBill, idFood, count )
		VALUES  ( @idBill, -- idBill - int
          @idFood, -- idFood - int
          @count  -- count - int
          )
	END
END
GO
/****** Object:  StoredProcedure [dbo].[USP_Login]    Script Date: 1/3/2022 8:03:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[USP_Login]	
@userName nvarchar(100), @password nvarchar(100)
as
begin
 select * from dbo.ACCOUNT where UserName=@userName and Password=@password
end
GO
/****** Object:  StoredProcedure [dbo].[USP_SwitchTable]    Script Date: 1/3/2022 8:03:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[USP_SwitchTable]
 @idTable1 int, @idTable2 int
as
begin
	declare @idFirstBill int
	declare @idSecondBill int

	declare @isFirstTableEmpty int =1
	declare @isSecondTableEmpty int =1

	 
	select @idSecondBill=id from dbo.Bill where idTable=@idTable2 and status=0
	select @idFirstBill=id from dbo.Bill where idTable=@idTable1 and status=0
	
		if(@idFirstBill=null)
		begin
			insert dbo.Bill(DateCheckIn,DateCheckOut,idTable,status) 
			values(GETDATE(),null,@idTable1,0)

			select @idFirstBill = max(id) from dbo.Bill where idTable=@idTable1 and status=0
		
		end

		select @isFirstTableEmpty=COUNT(*) FROM dbo.BillInfo where idBill=@idFirstBill
	print @idFirstBill
	print @idSecondBill
	print '------------'

	if(@idSecondBill is null)
		begin
			insert dbo.Bill(DateCheckIn,DateCheckOut,idTable,status) 
			values(GETDATE(),null,@idTable2,0)

		select @idSecondBill =MAX(id) from dbo.Bill where idTable=@idTable2 and status=0
		
		end

		select @isSecondTableEmpty=COUNT(*) from dbo.BillInfo where idBill=@idSecondBill


	select id into IdBillInfoTable From dbo.BillInfo where idBill=@idSecondBill
	
	update dbo.BillInfo set idBill=@idSecondBill where idBill=@idFirstBill

	update dbo.BillInfo set idBill=@idFirstBill where id IN (select * from IdBillInfoTable)
	
	drop table IdBillInfoTable

	if(@isFirstTableEmpty=0)
	update dbo.TableFood set status=N'Trống' where id=@idTable2

	if(@isSecondTableEmpty=0)
	update dbo.TableFood set status=N'Trống' where id=@idTable1

end
GO
/****** Object:  StoredProcedure [dbo].[USP_UpdateAccount]    Script Date: 1/3/2022 8:03:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[USP_UpdateAccount]
@userName nvarchar(100), @displayName nvarchar(100), @password nvarchar(100), @newpassword nvarchar(100)
as
begin
	declare @isRightPass int=0
	select @isRightPass = COUNT(*) FROM dbo.Account where UserName=@userName and PassWord=@password

	if(@isRightPass=1)
	begin
	if(@newpassword= null or @newpassword='')
		begin
		 update dbo.Account set DisplayName=@displayName where UserName=@userName
		end
	else
		 update dbo.Account set DisplayName=@displayName , PassWord=@newpassword where UserName=@userName
	 
	end
end
GO
USE [master]
GO
ALTER DATABASE [QLRAUMAMIXX] SET  READ_WRITE 
GO
