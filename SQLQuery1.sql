use [LibraryManagement]

create table NewBook(
id int NOT NULL IDENTITY(1,1) primary key,
name nvarchar(250) not null,
tacgia nvarchar(250) not null,
xuatban nvarchar(250) not null,
ngaygio nvarchar(250) not null,
gia bigint not null,
charluong bigint not null
)
select * from NewBook
(id,name,tacgia,xuatban,ngaygio,gia,charluong)
insert into NewBook (id,name,tacgia,xuatban,ngaygio,gia,charluong) values ('tenSach','tacGia','xuatBan','ngayMuon',gia,chatLuong)