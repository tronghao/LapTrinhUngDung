create database sv;
go
use sv;

create table sinhvien (
	maSinhVien nvarchar(10),
	tenSinhVien nvarchar(50)
)
go


insert into sinhvien values('110117051', N'Đổ Trọng Hảo');
insert into sinhvien values('110117035', N'Nguyễn Minh Thư');
insert into sinhvien values('110117048', N'Võ Lê Khánh Duy');