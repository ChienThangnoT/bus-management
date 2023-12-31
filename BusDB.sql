USE [master]
GO
/****** Object:  Database [BusDB]    Script Date: 7/10/2023 10:38:02 PM ******/
CREATE DATABASE [BusDB]
ALTER DATABASE [BusDB] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BusDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BusDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BusDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BusDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BusDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BusDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [BusDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [BusDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BusDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BusDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BusDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BusDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BusDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BusDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BusDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BusDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [BusDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BusDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BusDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BusDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BusDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BusDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BusDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BusDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [BusDB] SET  MULTI_USER 
GO
ALTER DATABASE [BusDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BusDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BusDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BusDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [BusDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [BusDB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'BusDB', N'ON'
GO
ALTER DATABASE [BusDB] SET QUERY_STORE = OFF
GO
USE [BusDB]
GO
/****** Object:  Table [dbo].[tblAccount]    Script Date: 7/10/2023 10:38:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblAccount](
	[account_id] [nvarchar](50) NOT NULL,
	[username] [nvarchar](30) NULL,
	[password] [nvarchar](30) NULL,
	[full_name] [nvarchar](40) NULL,
	[dob] [datetime] NULL,
	[email] [nvarchar](50) NULL,
	[phone_number] [nvarchar](12) NULL,
	[role] [nvarchar](30) NULL,
	[is_active] [bit] NULL,
 CONSTRAINT [PK_tblAccount] PRIMARY KEY CLUSTERED 
(
	[account_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblBus]    Script Date: 7/10/2023 10:38:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblBus](
	[bus_id] [nvarchar](10) NOT NULL,
	[number_plate] [nvarchar](10) NULL,
	[bus_type] [nvarchar](15) NULL,
	[seat_quantity] [int] NULL,
	[engine_ouput] [int] NULL,
	[manufacturing_date] [datetime] NULL,
	[registration_date] [datetime] NULL,
	[periodic_maintenance] [int] NULL,
	[routes_id] [nvarchar](10) NULL,
	[is_active] [bit] NULL,
 CONSTRAINT [PK_tblBus] PRIMARY KEY CLUSTERED 
(
	[bus_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblBusRoutes]    Script Date: 7/10/2023 10:38:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblBusRoutes](
	[routes_id] [nvarchar](10) NOT NULL,
	[transport_unit_id] [nvarchar](10) NULL,
	[routes_name] [nvarchar](50) NULL,
	[start_time] [time](7) NULL,
	[end_time] [time](7) NULL,
	[estimated_time] [int] NULL,
	[start_point] [nvarchar](100) NULL,
	[end_point] [nvarchar](100) NULL,
	[is_active] [bit] NULL,
 CONSTRAINT [PK_tblBusRoutes] PRIMARY KEY CLUSTERED 
(
	[routes_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblDriver]    Script Date: 7/10/2023 10:38:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblDriver](
	[driver_id] [nvarchar](10) NOT NULL,
	[driver_name] [nvarchar](40) NULL,
	[dob] [datetime] NULL,
	[gender] [nvarchar](10) NULL,
	[address] [nvarchar](100) NULL,
	[start_date] [datetime] NULL,
	[salary] [decimal](10, 2) NULL,
	[bus_id] [nvarchar](10) NULL,
	[is_active] [bit] NULL,
 CONSTRAINT [PK_tblDriver] PRIMARY KEY CLUSTERED 
(
	[driver_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblTransportUnit]    Script Date: 7/10/2023 10:38:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblTransportUnit](
	[transport_unit_id] [nvarchar](10) NOT NULL,
	[transport_unit_name] [nvarchar](50) NULL,
	[address] [nvarchar](100) NULL,
	[phone_number] [nvarchar](12) NULL,
	[email] [nvarchar](50) NULL,
	[is_active] [bit] NULL,
 CONSTRAINT [PK_tblTransportUnit] PRIMARY KEY CLUSTERED 
(
	[transport_unit_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[tblAccount] ([account_id], [username], [password], [full_name], [dob], [email], [phone_number], [role], [is_active]) VALUES (N'A0001', N'eggchery', N'wvc74xo8zud', N'Amir Christian', CAST(N'2001-07-23T00:00:00.000' AS DateTime), N'mauris.sagittis@gmail.com', N'0213135', N'quan ly', 1)
INSERT [dbo].[tblAccount] ([account_id], [username], [password], [full_name], [dob], [email], [phone_number], [role], [is_active]) VALUES (N'A0002', N'WestatkE', N'lnk55pk6gei', N'Keely Hobbs', CAST(N'1993-06-23T00:00:00.000' AS DateTime), N'mauris.sagittis@gmail.com', N'0356135', N'Quản Lí', 1)
INSERT [dbo].[tblAccount] ([account_id], [username], [password], [full_name], [dob], [email], [phone_number], [role], [is_active]) VALUES (N'A0003', N'ORtHEdeC', N'ehw77ws2krl', N'Harriet Battle', CAST(N'1990-12-20T00:00:00.000' AS DateTime), N'cras.sed@gmail.com', N'2752345', N'Quản Lí', 0)
INSERT [dbo].[tblAccount] ([account_id], [username], [password], [full_name], [dob], [email], [phone_number], [role], [is_active]) VALUES (N'A0004', N'oadhOnWo', N'eau12co3ykj', N'Zelda Cantrell', CAST(N'1991-12-10T00:00:00.000' AS DateTime), N'ullamcorper.viverra@gmail.com', N'2345261', N'Quản Lí', 1)
INSERT [dbo].[tblAccount] ([account_id], [username], [password], [full_name], [dob], [email], [phone_number], [role], [is_active]) VALUES (N'A0005', N'YeSeYPLI', N'dfk59dv9ogp', N'Leslie Cote', CAST(N'2001-07-29T00:00:00.000' AS DateTime), N'suspendisse.non@gmail.com', N'1341527', N'Quản Lí', 0)
GO
INSERT [dbo].[tblBus] ([bus_id], [number_plate], [bus_type], [seat_quantity], [engine_ouput], [manufacturing_date], [registration_date], [periodic_maintenance], [routes_id], [is_active]) VALUES (N'B0001', N'FPY8750', N'Cỡ nhỏ', 16, 1600, CAST(N'2023-08-01T00:00:00.000' AS DateTime), CAST(N'2022-01-26T00:00:00.000' AS DateTime), 1, N'R0001', 1)
INSERT [dbo].[tblBus] ([bus_id], [number_plate], [bus_type], [seat_quantity], [engine_ouput], [manufacturing_date], [registration_date], [periodic_maintenance], [routes_id], [is_active]) VALUES (N'B0002', N'5MNJ071', N'Cỡ lớn', 40, 6400, CAST(N'2024-03-09T00:00:00.000' AS DateTime), CAST(N'2022-12-09T00:00:00.000' AS DateTime), 18, N'R0004', 1)
INSERT [dbo].[tblBus] ([bus_id], [number_plate], [bus_type], [seat_quantity], [engine_ouput], [manufacturing_date], [registration_date], [periodic_maintenance], [routes_id], [is_active]) VALUES (N'B0003', N'ADM7810', N'Cỡ nhỏ', 20, 2200, CAST(N'2024-02-05T00:00:00.000' AS DateTime), CAST(N'2021-05-28T00:00:00.000' AS DateTime), 6, N'R0005', 1)
INSERT [dbo].[tblBus] ([bus_id], [number_plate], [bus_type], [seat_quantity], [engine_ouput], [manufacturing_date], [registration_date], [periodic_maintenance], [routes_id], [is_active]) VALUES (N'B0004', N'5WYW038', N'Cỡ vừa', 30, 3400, CAST(N'2023-05-30T00:00:00.000' AS DateTime), CAST(N'2020-09-09T00:00:00.000' AS DateTime), 12, N'R0007', 1)
INSERT [dbo].[tblBus] ([bus_id], [number_plate], [bus_type], [seat_quantity], [engine_ouput], [manufacturing_date], [registration_date], [periodic_maintenance], [routes_id], [is_active]) VALUES (N'B0005', N'V280288', N'Cỡ vừa', 30, 3400, CAST(N'2023-10-15T00:00:00.000' AS DateTime), CAST(N'2021-05-02T00:00:00.000' AS DateTime), 8, N'R0008', 1)
INSERT [dbo].[tblBus] ([bus_id], [number_plate], [bus_type], [seat_quantity], [engine_ouput], [manufacturing_date], [registration_date], [periodic_maintenance], [routes_id], [is_active]) VALUES (N'B0006', N'141HEY32', N'Cỡ vừa', 25, 3000, CAST(N'2023-08-24T00:00:00.000' AS DateTime), CAST(N'2020-09-12T00:00:00.000' AS DateTime), 8, N'R0010', 1)
INSERT [dbo].[tblBus] ([bus_id], [number_plate], [bus_type], [seat_quantity], [engine_ouput], [manufacturing_date], [registration_date], [periodic_maintenance], [routes_id], [is_active]) VALUES (N'B0007', N'8EGK224', N'Cỡ lớn', 60, 7000, CAST(N'2023-08-24T00:00:00.000' AS DateTime), CAST(N'2021-07-29T00:00:00.000' AS DateTime), 24, N'R0011', 1)
GO
INSERT [dbo].[tblBusRoutes] ([routes_id], [transport_unit_id], [routes_name], [start_time], [end_time], [estimated_time], [start_point], [end_point], [is_active]) VALUES (N'R0001', N'TU00001', N'Bến Thành - Chợ Lớn', CAST(N'05:00:00' AS Time), CAST(N'20:15:00' AS Time), 35, N'Bến Thành', N'Chợ Lớn', 1)
INSERT [dbo].[tblBusRoutes] ([routes_id], [transport_unit_id], [routes_name], [start_time], [end_time], [estimated_time], [start_point], [end_point], [is_active]) VALUES (N'R0002', N'TU00002', N'Bến Thành - Thạnh Lộc', CAST(N'04:00:00' AS Time), CAST(N'20:45:00' AS Time), 65, N'Bến Thành', N'Thạnh Lộc', 1)
INSERT [dbo].[tblBusRoutes] ([routes_id], [transport_unit_id], [routes_name], [start_time], [end_time], [estimated_time], [start_point], [end_point], [is_active]) VALUES (N'R0003', N'TU00003', N'Chợ Lớn - Trường Đại học Nông Lâm', CAST(N'04:55:00' AS Time), CAST(N'20:30:00' AS Time), 70, N'Chợ Lớn', N'Trường Đại học Nông Lâm', 1)
INSERT [dbo].[tblBusRoutes] ([routes_id], [transport_unit_id], [routes_name], [start_time], [end_time], [estimated_time], [start_point], [end_point], [is_active]) VALUES (N'R0004', N'TU00004', N'Chợ Lớn - Gò Vấp', CAST(N'05:00:00' AS Time), CAST(N'19:30:00' AS Time), 65, N'Chợ Lớn', N'Gò Vấp', 1)
INSERT [dbo].[tblBusRoutes] ([routes_id], [transport_unit_id], [routes_name], [start_time], [end_time], [estimated_time], [start_point], [end_point], [is_active]) VALUES (N'R0005', N'TU00012', N'Long Phước - Bến xe Miền Đông mới', CAST(N'04:50:00' AS Time), CAST(N'19:00:00' AS Time), 58, N'Long Phước', N'Bến xe Miền Đông mới', 1)
INSERT [dbo].[tblBusRoutes] ([routes_id], [transport_unit_id], [routes_name], [start_time], [end_time], [estimated_time], [start_point], [end_point], [is_active]) VALUES (N'R0006', N'TU00012', N'Khu du lịch BCR - Khu chế xuất Linh Trung II', CAST(N'05:00:00' AS Time), CAST(N'19:15:00' AS Time), 65, N'Khu du lịch BCR', N'Khu chế xuất Linh Trung II', 1)
INSERT [dbo].[tblBusRoutes] ([routes_id], [transport_unit_id], [routes_name], [start_time], [end_time], [estimated_time], [start_point], [end_point], [is_active]) VALUES (N'R0007', N'TU00007', N'Bến xe buýt Sài Gòn - Khu dân cư Phú Lợi', CAST(N'05:00:00' AS Time), CAST(N'19:00:00' AS Time), 60, N'Bến xe buýt Sài Gòn', N'Khu dân cư Phú Lợi', 1)
INSERT [dbo].[tblBusRoutes] ([routes_id], [transport_unit_id], [routes_name], [start_time], [end_time], [estimated_time], [start_point], [end_point], [is_active]) VALUES (N'R0008', N'TU00009', N'Bến xe Miền Đông - Chợ Hiệp Thành', CAST(N'04:45:00' AS Time), CAST(N'19:00:00' AS Time), 65, N'Bến xe Miền Đông', N'Chợ Hiệp Thành', 1)
INSERT [dbo].[tblBusRoutes] ([routes_id], [transport_unit_id], [routes_name], [start_time], [end_time], [estimated_time], [start_point], [end_point], [is_active]) VALUES (N'R0009', N'TU00009', N'Phà Cát Lái - Chợ nông sản Thủ Đức', CAST(N'05:00:00' AS Time), CAST(N'19:15:00' AS Time), 70, N'Phà Cát Lái', N'Chợ nông sản Thủ Đức', 1)
INSERT [dbo].[tblBusRoutes] ([routes_id], [transport_unit_id], [routes_name], [start_time], [end_time], [estimated_time], [start_point], [end_point], [is_active]) VALUES (N'R0010', N'TU00005', N'Bến xe An Sương - 	Trường Đại học Nông Lâm', CAST(N'04:40:00' AS Time), CAST(N'20:00:00' AS Time), 75, N'Bến xe An Sương', N'Trường Đại học Nông Lâm', 1)
INSERT [dbo].[tblBusRoutes] ([routes_id], [transport_unit_id], [routes_name], [start_time], [end_time], [estimated_time], [start_point], [end_point], [is_active]) VALUES (N'R0011', N'TU00011', N'Bến Thành - Bến xe Miền Tây', CAST(N'04:45:00' AS Time), CAST(N'19:00:00' AS Time), 80, N'Bến Thành', N'Bến xe Miền Tây', 1)
GO
INSERT [dbo].[tblDriver] ([driver_id], [driver_name], [dob], [gender], [address], [start_date], [salary], [bus_id], [is_active]) VALUES (N'D0001', N'Trần Gia Thành Đạt', CAST(N'1996-02-06T00:00:00.000' AS DateTime), N'Nam', N'Tỉnh Thừa Thiên Huế', CAST(N'2022-07-26T00:00:00.000' AS DateTime), CAST(9000000.00 AS Decimal(10, 2)), N'B0001', 1)
INSERT [dbo].[tblDriver] ([driver_id], [driver_name], [dob], [gender], [address], [start_date], [salary], [bus_id], [is_active]) VALUES (N'D0002', N'Lê Hoàng An', CAST(N'1998-05-21T00:00:00.000' AS DateTime), N'Khac', N'Quận Bình Tân', CAST(N'2020-12-31T00:00:00.000' AS DateTime), CAST(14000000.00 AS Decimal(10, 2)), N'B0002', 0)
INSERT [dbo].[tblDriver] ([driver_id], [driver_name], [dob], [gender], [address], [start_date], [salary], [bus_id], [is_active]) VALUES (N'D0003', N'Nguyễn Chiến Thắng', CAST(N'1994-05-21T00:00:00.000' AS DateTime), N'Khac', N'Tỉnh Long An', CAST(N'2021-10-25T00:00:00.000' AS DateTime), CAST(12000000.00 AS Decimal(10, 2)), N'B0005', 1)
INSERT [dbo].[tblDriver] ([driver_id], [driver_name], [dob], [gender], [address], [start_date], [salary], [bus_id], [is_active]) VALUES (N'D0004', N'Nguyễn Phạm Quốc Thắng ', CAST(N'1997-06-23T00:00:00.000' AS DateTime), N'Nam', N'Thành phố Biên Hòa', CAST(N'2022-07-05T00:00:00.000' AS DateTime), CAST(9000000.00 AS Decimal(10, 2)), N'B0007', 0)
INSERT [dbo].[tblDriver] ([driver_id], [driver_name], [dob], [gender], [address], [start_date], [salary], [bus_id], [is_active]) VALUES (N'D0005', N'Nguyễn Thành Long', CAST(N'2000-05-21T00:00:00.000' AS DateTime), N'Nam', N'Thành phố Hồ Chí Minh', CAST(N'2022-12-07T00:00:00.000' AS DateTime), CAST(9000000.00 AS Decimal(10, 2)), N'B0003', 1)
INSERT [dbo].[tblDriver] ([driver_id], [driver_name], [dob], [gender], [address], [start_date], [salary], [bus_id], [is_active]) VALUES (N'D0006', N'Phạm Quang Khải', CAST(N'1993-07-30T00:00:00.000' AS DateTime), N'Nam', N'Thành Phố Hải Phòng', CAST(N'2022-07-30T00:00:00.000' AS DateTime), CAST(9000000.00 AS Decimal(10, 2)), N'B0004', 1)
INSERT [dbo].[tblDriver] ([driver_id], [driver_name], [dob], [gender], [address], [start_date], [salary], [bus_id], [is_active]) VALUES (N'D0007', N'Lê Uyên Trâm', CAST(N'1995-03-03T00:00:00.000' AS DateTime), N'Nu', N'Thành phố Hồ Chí Minh', CAST(N'2021-09-29T00:00:00.000' AS DateTime), CAST(12000000.00 AS Decimal(10, 2)), N'B0006', 1)
INSERT [dbo].[tblDriver] ([driver_id], [driver_name], [dob], [gender], [address], [start_date], [salary], [bus_id], [is_active]) VALUES (N'D0008', N'Lê Trâm Uyên', CAST(N'1995-03-03T00:00:00.000' AS DateTime), N'Nu', N'Thành phố Hồ Chí Minh', CAST(N'2022-10-07T00:00:00.000' AS DateTime), CAST(9000000.00 AS Decimal(10, 2)), N'B0006', 1)
GO
INSERT [dbo].[tblTransportUnit] ([transport_unit_id], [transport_unit_name], [address], [phone_number], [email], [is_active]) VALUES (N'TU00001', N'Bao Yen Group', N'26 Đường Số 43, Tân Quy, Quận 7, Thành phố Hồ Chí Minh', N'0183265946', N'nequesed@gmail.com', 1)
INSERT [dbo].[tblTransportUnit] ([transport_unit_id], [transport_unit_name], [address], [phone_number], [email], [is_active]) VALUES (N'TU00002', N'HTX Vận tải 19/5', N'1 ĐH60B, Tân Thới Nhì, Hóc Môn, Thành phố Hồ Chí Minh', N'0422643606', N'semconsequat@gmail.com', 1)
INSERT [dbo].[tblTransportUnit] ([transport_unit_id], [transport_unit_name], [address], [phone_number], [email], [is_active]) VALUES (N'TU00003', N'HTX Vận tải Xe buýt Quyết Thắng', N'1129 Lạc Long Quân, Phường 11, Tân Bình, Thành phố Hồ Chí Minh', N'0382266656', N'semsmolestie@gmail.com', 1)
INSERT [dbo].[tblTransportUnit] ([transport_unit_id], [transport_unit_name], [address], [phone_number], [email], [is_active]) VALUES (N'TU00004', N'SaigonBus', N'39 Đ. Hải Thượng Lãn Ông, Phường 10, Quận 5, Thành phố Hồ Chí Minh', N'0503543586', N'ad.litora@gmail.com', 1)
INSERT [dbo].[tblTransportUnit] ([transport_unit_id], [transport_unit_name], [address], [phone_number], [email], [is_active]) VALUES (N'TU00005', N'Liên hiệp HTX Vận tải Thành phố', N'1129/18, Đường Lạc Long Quân, Phường 11, Quận Tân Bình, Hồ Chí Minh', N'0348886161', N'quisque@gmail.com', 1)
INSERT [dbo].[tblTransportUnit] ([transport_unit_id], [transport_unit_name], [address], [phone_number], [email], [is_active]) VALUES (N'TU00006', N'HTX Vận tải số 28', N'43 Đường D1, Mỹ Phước, Bến Cát, Bình Dương', N'0544559132', N'nibhsit@gmail.com', 0)
INSERT [dbo].[tblTransportUnit] ([transport_unit_id], [transport_unit_name], [address], [phone_number], [email], [is_active]) VALUES (N'TU00007', N'Công ty Cổ phần Vận tải 26', N'16A Lê Hồng Phong, Phường 12, Quận 10, Thành phố Hồ Chí Minh', N'0995712262', N'interdumnunc@gmail.com', 1)
INSERT [dbo].[tblTransportUnit] ([transport_unit_id], [transport_unit_name], [address], [phone_number], [email], [is_active]) VALUES (N'TU00008', N'HTX Vận tải Liên tỉnh & Du lịch Việt Thắng', N'2N Lê Quang Sung, Phường 2, Quận 6, Thành phố Hồ Chí Minh', N'0810117837', N'pretium.neque@gmail.com', 0)
INSERT [dbo].[tblTransportUnit] ([transport_unit_id], [transport_unit_name], [address], [phone_number], [email], [is_active]) VALUES (N'TU00009', N'HTX Vận tải & Du lịch Thanh Sơn', N'22 Đường Số 2, Trường Thọ, Thủ Đức, Thành phố Hồ Chí Minh', N'0948960572', N'tempor@gmail.com', 1)
INSERT [dbo].[tblTransportUnit] ([transport_unit_id], [transport_unit_name], [address], [phone_number], [email], [is_active]) VALUES (N'TU00010', N'FutaBusLines', N'486-486A Lê Văn Lương, Phường Tân Phong, Quận 7, Thành phố Hồ Chí Minh', N'0245076069', N'molestieodales@gmail.com', 0)
INSERT [dbo].[tblTransportUnit] ([transport_unit_id], [transport_unit_name], [address], [phone_number], [email], [is_active]) VALUES (N'TU00011', N'Citranco', N'1394 Đ. 3 Tháng 2, Phường 2, Quận 11, Thành phố Hồ Chí Minh', N'0603847561', N'adasm@gmail.com', 1)
INSERT [dbo].[tblTransportUnit] ([transport_unit_id], [transport_unit_name], [address], [phone_number], [email], [is_active]) VALUES (N'TU00012', N'HTX Vận tải số 15', N'62 Đường số 1, Khu phố 1, Phường Tam Bình, Thành phố Thủ Đức, Thành phố Hồ Chí Minh', N'0743273779', N'natoquepenatibus.et@gmail.com', 1)
GO
ALTER TABLE [dbo].[tblBus]  WITH CHECK ADD  CONSTRAINT [FK_tblBus_tblBusRoutes] FOREIGN KEY([routes_id])
REFERENCES [dbo].[tblBusRoutes] ([routes_id])
GO
ALTER TABLE [dbo].[tblBus] CHECK CONSTRAINT [FK_tblBus_tblBusRoutes]
GO
ALTER TABLE [dbo].[tblBusRoutes]  WITH CHECK ADD  CONSTRAINT [FK_tblBusRoutes_tblTransportUnit] FOREIGN KEY([transport_unit_id])
REFERENCES [dbo].[tblTransportUnit] ([transport_unit_id])
GO
ALTER TABLE [dbo].[tblBusRoutes] CHECK CONSTRAINT [FK_tblBusRoutes_tblTransportUnit]
GO
ALTER TABLE [dbo].[tblDriver]  WITH CHECK ADD  CONSTRAINT [FK_tblDriver_tblBus] FOREIGN KEY([bus_id])
REFERENCES [dbo].[tblBus] ([bus_id])
GO
ALTER TABLE [dbo].[tblDriver] CHECK CONSTRAINT [FK_tblDriver_tblBus]
GO
USE [master]
GO
ALTER DATABASE [BusDB] SET  READ_WRITE 
GO
