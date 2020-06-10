--DROP DATABASE qlsv;
create database qlsv;
go

use qlsv;
go

create table lop (
	ma_lop varchar(10) not null primary key,
	ten_lop nvarchar(50)
)
go

create table sinhvien (
	ma_sv varchar(10) not null primary key,
	ten_sv nvarchar(50),
	ma_lop varchar(10),
	foreign key (ma_lop) REFERENCES lop(ma_lop)
)
go


--insert lop
insert into lop values('DA17TT', N'Công nghệ Thông tin 17')
insert into lop values('DA17QTM', N'Quản Trị Mạng 17')

--insert sinhvien
insert into sinhvien values('110117051', N'Đổ Trọng Hảo', 'DA17TT')
insert into sinhvien values('110117048', N'Đổ Trọng Hảo', 'DA17QTM')