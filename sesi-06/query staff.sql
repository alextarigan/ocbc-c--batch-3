--A
Create database staff
--B
CREATE TABLE data_staff(
	nik int PRIMARY KEY,
	nama VARCHAR(50) NULL,
	alamat VARCHAR(200) NULL,
	handphone VARCHAR(15)
)
--C & D
INSERT INTO data_staff values
('41241251','Andrian','Nias','081234567890'),
('41241231','Denny','Binjai','081221421412'),
('41241216','Kamrozi','Medan','08122144122'),
('41241266','Galih','Sunggal','08122531224'),
('41241124','Bayu','Tanjung Morawa','0812371242453')
select * from data_staff

ALTER TABLE data_staff drop column joindate
delete from data_staff where nama='Alex'
--E
ALTER TABLE data_staff add joindate date ; insert into data_staff values('41241177','Alex','Medan','081371712354','2022-03-23')

--F
select TOP 2 * from data_staff

--G
select TOP 3 * from data_staff

--H
CREATE TABLE staffoutsource(
	nik int PRIMARY KEY,
	nama VARCHAR(50) NULL,
	alamat VARCHAR(200) NULL,
	handphone VARCHAR(15),
	joindate date
)
--I
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
select * from staffoutsource

--J
select * from data_staff d  join staffoutsource s on d.joindate = s.joindate 
select * from data_staff d
join staffoutsource s
on d.nama = s.nama

--K
select * from data_staff 
right join staffoutsource 
on data_staff.joindate = staffoutsource.joindate

--L
select * from data_staff 
LEFT join staffoutsource 
on data_staff.joindate = staffoutsource.joindate

--M
Select * from data_staff d 
full join staffoutsource s 
on d.joindate = s.joindate