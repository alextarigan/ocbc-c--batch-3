USE [master]
GO
/****** Object:  Database [Bank]    Script Date: 24/03/2022 03:13:09 ******/
CREATE DATABASE [Bank]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Bank', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.ALEXTARIGAN\MSSQL\DATA\Bank.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Bank_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.ALEXTARIGAN\MSSQL\DATA\Bank_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Bank] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Bank].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Bank] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Bank] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Bank] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Bank] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Bank] SET ARITHABORT OFF 
GO
ALTER DATABASE [Bank] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [Bank] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Bank] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Bank] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Bank] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Bank] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Bank] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Bank] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Bank] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Bank] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Bank] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Bank] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Bank] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Bank] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Bank] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Bank] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Bank] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Bank] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Bank] SET  MULTI_USER 
GO
ALTER DATABASE [Bank] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Bank] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Bank] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Bank] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Bank] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Bank] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Bank] SET QUERY_STORE = OFF
GO
USE [Bank]
GO
/****** Object:  Table [dbo].[customers]    Script Date: 24/03/2022 03:13:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[customers](
	[customerNumber] [int] NOT NULL,
	[customerName] [varchar](100) NULL,
	[contactLastName] [varchar](50) NULL,
	[contactFirstName] [varchar](50) NULL,
	[phone] [varchar](12) NULL,
	[addressLine1] [varchar](200) NULL,
	[addressLine2] [varchar](200) NULL,
	[city] [varchar](50) NULL,
	[states] [varchar](50) NULL,
	[postalCode] [varchar](5) NULL,
	[country] [varchar](50) NULL,
	[employeeNumber] [int] NULL,
	[creditLimit] [money] NULL,
PRIMARY KEY CLUSTERED 
(
	[customerNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[employees]    Script Date: 24/03/2022 03:13:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[employees](
	[employeeNumber] [int] NOT NULL,
	[lastName] [varchar](50) NULL,
	[firstName] [varchar](50) NULL,
	[extension] [date] NULL,
	[email] [varchar](30) NULL,
	[officeCode] [int] NULL,
	[reportsTo] [varchar](50) NULL,
	[jobtitle] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[employeeNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[offices]    Script Date: 24/03/2022 03:13:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[offices](
	[officeCode] [int] NOT NULL,
	[city] [varchar](20) NULL,
	[phone] [varchar](12) NULL,
	[addressLine1] [varchar](200) NULL,
	[addressLine2] [varchar](200) NULL,
	[states] [varchar](50) NULL,
	[postalCode] [varchar](5) NULL,
	[country] [varchar](50) NULL,
	[territory] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[officeCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[orderdetails]    Script Date: 24/03/2022 03:13:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[orderdetails](
	[orderNumber] [int] NULL,
	[productCode] [int] NULL,
	[quantityOrdered] [int] NULL,
	[priceEach] [money] NULL,
	[orderLineNumber] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[orders]    Script Date: 24/03/2022 03:13:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[orders](
	[orderNumber] [int] NOT NULL,
	[orderDate] [date] NULL,
	[requiredDate] [date] NULL,
	[shippedDate] [date] NULL,
	[statuss] [varchar](20) NULL,
	[comment] [varchar](100) NULL,
	[customerNumber] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[orderNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[payments]    Script Date: 24/03/2022 03:13:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[payments](
	[customerNumber] [int] NULL,
	[checkNumber] [varchar](50) NOT NULL,
	[paymentDate] [date] NULL,
	[amount] [money] NULL,
PRIMARY KEY CLUSTERED 
(
	[checkNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[productlines]    Script Date: 24/03/2022 03:13:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[productlines](
	[productLine] [varchar](50) NOT NULL,
	[textDescription] [varchar](100) NULL,
	[htmlDescription] [varchar](100) NULL,
	[image] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[productLine] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[products]    Script Date: 24/03/2022 03:13:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[products](
	[productCode] [int] NOT NULL,
	[productName] [varchar](50) NULL,
	[productLine] [varchar](50) NULL,
	[productScale] [varchar](20) NULL,
	[productVendor] [varchar](20) NULL,
	[productDescription] [varchar](50) NULL,
	[quantityInStock] [int] NULL,
	[buyPrice] [money] NULL,
PRIMARY KEY CLUSTERED 
(
	[productCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[customers] ([customerNumber], [customerName], [contactLastName], [contactFirstName], [phone], [addressLine1], [addressLine2], [city], [states], [postalCode], [country], [employeeNumber], [creditLimit]) VALUES (10, N'Andrian Laia', N'Laia', N'Martin', N'081231421232', N'Jl. Gunung Sitoli', N'Jl. Singosari', N'Gunung Sitoli', N'Sumatera Utara', N'21112', N'Indonesia', 3, 1500000.0000)
INSERT [dbo].[customers] ([customerNumber], [customerName], [contactLastName], [contactFirstName], [phone], [addressLine1], [addressLine2], [city], [states], [postalCode], [country], [employeeNumber], [creditLimit]) VALUES (20, N'Bayu Barus', N'Melda', N'Karina', N'081231421142', N'Jl. Bendungan 3', N'Jl. Batu 11', N'Tanjung Morawa', N'Sumatera Utara', N'21422', N'Indonesia', 1, 1000000.0000)
INSERT [dbo].[customers] ([customerNumber], [customerName], [contactLastName], [contactFirstName], [phone], [addressLine1], [addressLine2], [city], [states], [postalCode], [country], [employeeNumber], [creditLimit]) VALUES (30, N'Katon Surya', N'Gita', N'Amelia', N'081231425218', N'Jl. Cemara', N'Jl. Mawar', N'Medan', N'Sumatera Utara', N'21123', N'Indonesia', 2, 1500000.0000)
GO
INSERT [dbo].[employees] ([employeeNumber], [lastName], [firstName], [extension], [email], [officeCode], [reportsTo], [jobtitle]) VALUES (1, N'Setya', N'Denny', CAST(N'2022-05-28' AS Date), N'dennysetya@gmail.com', 3, NULL, N'Manager')
INSERT [dbo].[employees] ([employeeNumber], [lastName], [firstName], [extension], [email], [officeCode], [reportsTo], [jobtitle]) VALUES (2, N'Galih', N'Agung', CAST(N'2022-06-18' AS Date), N'agunggalih@gmail.com', 1, N'Denny Setya', N'Supervisor')
INSERT [dbo].[employees] ([employeeNumber], [lastName], [firstName], [extension], [email], [officeCode], [reportsTo], [jobtitle]) VALUES (3, N'Nasir', N'Fahmi', CAST(N'2022-04-28' AS Date), N'fahmi17@gmail.com', 2, N'Agung Galih', N'Marketing')
GO
INSERT [dbo].[offices] ([officeCode], [city], [phone], [addressLine1], [addressLine2], [states], [postalCode], [country], [territory]) VALUES (1, N'Medan', N'081237417242', N'Jl. Asia', N'Jl. Merdeka', N'Sumatera Utara', N'29937', N'Indonesia', N'Indonesia')
INSERT [dbo].[offices] ([officeCode], [city], [phone], [addressLine1], [addressLine2], [states], [postalCode], [country], [territory]) VALUES (2, N'Dumai', N'081237417123', N'Jl. Kulim', N'Jl. Kayangan', N'Riau', N'28884', N'Indonesia', N'Indonesia')
INSERT [dbo].[offices] ([officeCode], [city], [phone], [addressLine1], [addressLine2], [states], [postalCode], [country], [territory]) VALUES (3, N'Binjai', N'081237417125', N'Jl. Sunggal', N'Jl. Martubung', N'Sumatera Utara', N'20124', N'Indonesia', N'Indonesia')
GO
INSERT [dbo].[orderdetails] ([orderNumber], [productCode], [quantityOrdered], [priceEach], [orderLineNumber]) VALUES (777, 401, 1, 15000000.0000, 1)
INSERT [dbo].[orderdetails] ([orderNumber], [productCode], [quantityOrdered], [priceEach], [orderLineNumber]) VALUES (666, 404, 2, 17000000.0000, 2)
INSERT [dbo].[orderdetails] ([orderNumber], [productCode], [quantityOrdered], [priceEach], [orderLineNumber]) VALUES (888, 403, 5, 200000.0000, 3)
GO
INSERT [dbo].[orders] ([orderNumber], [orderDate], [requiredDate], [shippedDate], [statuss], [comment], [customerNumber]) VALUES (666, CAST(N'2022-03-20' AS Date), CAST(N'2022-03-21' AS Date), CAST(N'2022-03-23' AS Date), N'COD', N'Jangan dibanting', 10)
INSERT [dbo].[orders] ([orderNumber], [orderDate], [requiredDate], [shippedDate], [statuss], [comment], [customerNumber]) VALUES (777, CAST(N'2022-03-23' AS Date), CAST(N'2022-03-23' AS Date), CAST(N'2022-03-27' AS Date), N'Non COD', N'Jangan dibanting', 20)
INSERT [dbo].[orders] ([orderNumber], [orderDate], [requiredDate], [shippedDate], [statuss], [comment], [customerNumber]) VALUES (888, CAST(N'2022-03-21' AS Date), CAST(N'2022-03-21' AS Date), CAST(N'2022-03-24' AS Date), N'COD', N'Bawa dengan hati', 30)
GO
INSERT [dbo].[payments] ([customerNumber], [checkNumber], [paymentDate], [amount]) VALUES (20, N'123', CAST(N'2022-03-23' AS Date), 150000.0000)
INSERT [dbo].[payments] ([customerNumber], [checkNumber], [paymentDate], [amount]) VALUES (10, N'213', CAST(N'2022-03-21' AS Date), 200000.0000)
INSERT [dbo].[payments] ([customerNumber], [checkNumber], [paymentDate], [amount]) VALUES (30, N'321', CAST(N'2022-03-20' AS Date), 189000.0000)
GO
INSERT [dbo].[productlines] ([productLine], [textDescription], [htmlDescription], [image]) VALUES (N'aksesoris', N'Spare part nya kak', N'Dijamin Puas', N'Knalpot.png')
INSERT [dbo].[productlines] ([productLine], [textDescription], [htmlDescription], [image]) VALUES (N'oli', N'Oli Racing Bikin motor Kebut', N'Dijamin Original', N'oli.png')
INSERT [dbo].[productlines] ([productLine], [textDescription], [htmlDescription], [image]) VALUES (N'spare part', N'Spare part original harga termurah', N'Dijamin Murah', N'Shock Breaker.png')
GO
INSERT [dbo].[products] ([productCode], [productName], [productLine], [productScale], [productVendor], [productDescription], [quantityInStock], [buyPrice]) VALUES (401, N'Austin Racing Full System', N'aksesoris', N'ghi', N'Austin Racing', N'Knalpot dengan suara gahar', 10, 15000000.0000)
INSERT [dbo].[products] ([productCode], [productName], [productLine], [productScale], [productVendor], [productDescription], [quantityInStock], [buyPrice]) VALUES (403, N'Oli Motul', N'oli', N'def', N'Motul', N'Oli dengan performa tinggi', 48, 200000.0000)
INSERT [dbo].[products] ([productCode], [productName], [productLine], [productScale], [productVendor], [productDescription], [quantityInStock], [buyPrice]) VALUES (404, N'Shock Breaker Ohlins', N'spare part', N'abc', N'Ohlins', N'Shock Breaker ini di pakai di Moto GP', 100, 17000000.0000)
GO
ALTER TABLE [dbo].[customers]  WITH CHECK ADD FOREIGN KEY([employeeNumber])
REFERENCES [dbo].[employees] ([employeeNumber])
GO
ALTER TABLE [dbo].[employees]  WITH CHECK ADD FOREIGN KEY([officeCode])
REFERENCES [dbo].[offices] ([officeCode])
GO
ALTER TABLE [dbo].[orderdetails]  WITH CHECK ADD FOREIGN KEY([orderNumber])
REFERENCES [dbo].[orders] ([orderNumber])
GO
ALTER TABLE [dbo].[orderdetails]  WITH CHECK ADD FOREIGN KEY([productCode])
REFERENCES [dbo].[products] ([productCode])
GO
ALTER TABLE [dbo].[orders]  WITH CHECK ADD FOREIGN KEY([customerNumber])
REFERENCES [dbo].[customers] ([customerNumber])
GO
ALTER TABLE [dbo].[payments]  WITH CHECK ADD FOREIGN KEY([customerNumber])
REFERENCES [dbo].[customers] ([customerNumber])
GO
ALTER TABLE [dbo].[products]  WITH CHECK ADD FOREIGN KEY([productLine])
REFERENCES [dbo].[productlines] ([productLine])
GO
USE [master]
GO
ALTER DATABASE [Bank] SET  READ_WRITE 
GO
