insert into NewBook
select * from NewBook

create table NewStudent(
stuid int NOT NULL primary key IDENTITY(1,1), --Tu tang
sname nvarchar(250) NOT NULL,
enroll nvarchar(250) NOT NULL,
dep nvarchar(250) NOT NULL,
sem nvarchar(250) NOT NULL,
contact bigint NOT NULL,
email nvarchar(250) NOT NULL,
)
--sname,enroll,dep,sem,contact,email
select * from NewStudent