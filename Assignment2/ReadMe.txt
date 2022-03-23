Nama : Alexander Radianta Tarigan
No_Peserta : FSDO003ONL010
Panduan Penggunaan Aplikasi:

--Membuat database bank
create DATABASE Bank

--membua tabel offices
create table offices(
	officeCode int primary key,
	city varchar(20),
	phone varchar(12),
	addressLine1 varchar(200),
	addressLine2 varchar(200),
	states varchar(50),
	postalCode varchar(5),
	country varchar(50),
	territory varchar(20)
)

--membuat tabel employees
create  table employees(
	employeeNumber int primary key,
	lastName varchar(50),
	firstName varchar(50),
	extension date,
	email varchar(30),
	officeCode int foreign key references offices(officeCode),
	reportsTo varchar(50),
	jobtitle varchar(50)
)

--membuat tabel customers
create table customers(
	customerNumber int primary key,
	customerName varchar(100),
	contactLastName varchar(50),
	contactFirstName varchar(50),
	phone varchar(12),
	addressLine1 varchar(200),
	addressLine2 varchar(200),
	city varchar(50),
	states varchar(50),
	postalCode varchar(5),
	country varchar(50),
	employeeNumber int foreign key references employees(employeeNumber),
	creditLimit money
)

--membuat tabel payments
create table payments(
	customerNumber int foreign key references customers(customerNumber),
	checkNumber varchar(50) primary key,
	paymentDate date,
	amount money
)

--membuat tabel orders
create table orders(
	orderNumber int primary key,
	orderDate date,
	requiredDate date,
	shippedDate date,
	statuss varchar(20),
	comment varchar(100),
	customerNumber int foreign key references customers(customerNumber)
)

--membuat tabel productlines
create table productlines(
	productLine varchar(50) primary key,
	textDescription varchar(100),
	htmlDescription varchar(100),
	image varchar(100)
)

--membuat tabel products
create table products(
	productCode int primary key,
	productName varchar(50),
	productLine varchar(50) foreign key references productlines(productLine),
	productScale varchar(20),
	productVendor varchar(20),
	productDescription varchar(50),
	quantityInStock int,
	buyPrice money

)

--membuat tabel orderdetails
create table orderdetails
(
	orderNumber int foreign key references orders(orderNumber),
	productCode int foreign key references products(productCode),
	quantityOrdered int,
	priceEach money,
	orderLineNumber int
)


--insert Data ke tabel
insert into offices values
(1,'Medan','081237417242','Jl. Asia','Jl. Merdeka','Sumatera Utara', '29937', 'Indonesia' ,'Indonesia'),
(2,'Dumai','081237417123','Jl. Kulim','Jl. Kayangan','Riau', '28884', 'Indonesia','Indonesia'),
(3,'Binjai','081237417125','Jl. Sunggal','Jl. Martubung','Sumatera Utara' , '20124', 'Indonesia','Indonesia')

insert into employees values
(1, 'Setya', 'Denny','2022-05-28','dennysetya@gmail.com',3,null,'Manager'),
(2, 'Galih', 'Agung','2022-06-18','agunggalih@gmail.com',1,'Denny Setya','Supervisor'),
(3, 'Nasir', 'Fahmi','2022-04-28','fahmi17@gmail.com',2,'Agung Galih','Marketing')

insert into customers values
(10,'Andrian Laia','Laia','Martin','081231421232','Jl. Gunung Sitoli','Jl. Singosari','Gunung Sitoli','Sumatera Utara','21112','Indonesia',3,1500000),
(20,'Bayu Barus','Melda','Karina','081231421142','Jl. Bendungan 3','Jl. Batu 11','Tanjung Morawa','Sumatera Utara','21422','Indonesia',1,1000000),
(30,'Katon Surya','Gita','Amelia','081231425218','Jl. Cemara','Jl. Mawar','Medan','Sumatera Utara','21123','Indonesia',2,1500000)

insert into payments values
(20,123,'2022-03-23',150000),
(10,213,'2022-03-21',200000),
(30,321,'2022-03-20',189000)

insert into orders values
(777,'2022-03-23','2022-03-23','2022-03-27','Non COD','Jangan dibanting',20),
(888,'2022-03-21','2022-03-21','2022-03-24','COD','Bawa dengan hati',30),
(666,'2022-03-20','2022-03-21','2022-03-23','COD','Jangan dibanting',10)

insert into productlines values
('spare part','Spare part original harga termurah', 'Dijamin Murah', 'Shock Breaker.png'),
('oli','Oli Racing Bikin motor Kebut', 'Dijamin Original', 'oli.png'),
('aksesoris','Spare part nya kak', 'Dijamin Puas', 'Knalpot.png')

insert into products values
(404,'Shock Breaker Ohlins','spare part','abc','Ohlins','Shock Breaker ini di pakai di Moto GP',100,17000000),
(403,'Oli Motul','oli','def','Motul','Oli dengan performa tinggi',48,200000),
(401,'Austin Racing Full System','aksesoris','ghi','Austin Racing','Knalpot dengan suara gahar',10,15000000)

insert into orderdetails values
(777,401,1,15000000,1),
(666,404,2,17000000,2),
(888,403,5,200000,3)

Link Github : https://github.com/alextarigan/ocbc-c--batch-3.git