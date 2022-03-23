--A. Buat Database baru dengan nama staff
Create database staff

--B. Buat Table data_staff  
CREATE TABLE data_staff(
	nik int PRIMARY KEY,
	nama VARCHAR(50) NULL,
	alamat VARCHAR(200) NULL,
	handphone VARCHAR(15)
)

--C. Masukkan data ke dalam table data_staff sesuai dengan table diatas 
--D. Masukkan lebih dari 1 data ke dalam table data masih dalam table diatas.
INSERT INTO data_staff values
('41241251','Andrian','Nias','081234567890'),
('41241231','Denny','Binjai','081221421412'),
('41241216','Kamrozi','Medan','08122144122'),
('41241266','Galih','Sunggal','08122531224'),
('41241124','Bayu','Tanjung Morawa','0812371242453')


--E. Tambahkan kolom baru pada table data_staff yaitu joindate sekaligus masukan 1 data kedalam table data_staff
ALTER TABLE data_staff add joindate date ; insert into data_staff values('41241177','Alex','Medan','081371712354','2022-03-23')


--F. Tampilkan 2 data SQL kalian sekarang 
select TOP 2 * from data_staff

--G. Tampilkan 3 data SQL kalian sekarang 
select TOP 3 * from data_staff


--H. Buat Table baru staffoutsource dengan isi yang sama seperti data_staff
CREATE TABLE staffoutsource(
	nik int PRIMARY KEY,
	nama VARCHAR(50) NULL,
	alamat VARCHAR(200) NULL,
	handphone VARCHAR(15),
	joindate date
)

--I.  Masukkan 10 data baru ke table staffoutsourceJ. Tampilkan data pada 2 Table yang sudah kalian buat dengan joindate yang sama
INSERT INTO staffoutsource values
('41241251','Andrian','Nias','081234567890','2022-03-23'),
('41241231','Denny','Binjai','081221421412','2022-03-23'),
('41241216','Kamrozi','Medan','08122144122','2022-03-23'),
('41241266','Galih','Sunggal','08122531224','2022-03-23'),
('41241124','Bayu','Tanjung Morawa','0812371242453','2022-03-23'),
('41241201','Mawar','Nias','081234567890','2022-03-21'),
('41241202','Ronal','Binjai','081221421412','2022-03-20'),
('41241203','Fahmi','Medan','08122144122','2022-03-20'),
('41241204','Miftahul','Sunggal','08122531224','2022-03-19'),
('41241105','Boy','Tanjung Morawa','0812371242453','2022-03-17')

--J. Tampilkan data pada 2 Table yang sudah kalian buat dengan joindate yang sama
select * from data_staff d
join staffoutsource s
on d.nama = s.nama

--K. Tampilkan seluruh data sebelah kanan yang sama pada table staff_outsource
select * from data_staff 
right join staffoutsource 
on data_staff.joindate = staffoutsource.joindate


--L. Tampilkan seluruh data staff sebelah kiri yang punya nilai tidak sama akan bernilai null
select * from data_staff 
LEFT join staffoutsource 
on data_staff.joindate = staffoutsource.joindate

--M. Tampilkan seluruh data antara 2 tabel baik itu tidak punya kesamaan dan bernilai null.
Select * from data_staff d 
full join staffoutsource s 
on d.joindate = s.joindate