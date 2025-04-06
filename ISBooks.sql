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