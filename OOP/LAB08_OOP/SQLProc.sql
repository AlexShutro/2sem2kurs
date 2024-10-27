
create procedure Find_name @nm nvarchar(15)
as
begin
set @nm = @nm + '%'
SELECT Book.id, Book.Publisher , Book.sendDate, Title.BookName, Title.Publdate, Title.UDC, Book.Formate , Book.startSize, Title.ImageData from 
Book inner join Title on Book.TitleId = Title.id
where Title.BookName like @nm
end;


create procedure Find_publisher @formate nvarchar(15)
as
begin
set @formate = @formate + '%'
SELECT Book.id, Book.Publisher, Book.sendDate, Title.BookName, Title.PublDate, Title.UDC, Book.Formate, Book.startSize, Title.ImageData from 
Book inner join Title on Book.TitleId = Title.id
where Book.Formate like @formate
end;

