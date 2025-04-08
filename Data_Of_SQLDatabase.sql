

use [LibraryManagement]

create table LoginTable(
id int not null IDENTITY(1,1) primary key,
username varchar(150) not null,
pass varchar(150) not null
)
select * from LoginTable
--(id,username,pass)

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
--(id,name,tacgia,xuatban,ngaygio,gia,charluong)

create table ISBook(
id int not null identity(1,1) primary key,
std_enroll nvarchar(250) not null,
std_name nvarchar(250) not null,
std_dep nvarchar(250) not null,
std_sem nvarchar(250) not null,
std_contact bigint not null,
std_email nvarchar(250) not null,
book_name nvarchar(1250) not null,
book_issue_date nvarchar(250) not null,
book_return_date nvarchar(250)
)
select * from ISBook
--(id,std_enroll,std_name,std_dep,std_sem,std_contact,std_email,book_name,book_issue_date,book_return_date)

create table NewStudent(
stuid int NOT NULL primary key IDENTITY(1,1), --Tu tang
sname nvarchar(250) NOT NULL,
enroll nvarchar(250) NOT NULL,
dep nvarchar(250) NOT NULL,
sem nvarchar(250) NOT NULL,
contact bigint NOT NULL,
email nvarchar(250) NOT NULL,
)

select * from NewStudent 
--(sname,enroll,dep,sem,contact,email)