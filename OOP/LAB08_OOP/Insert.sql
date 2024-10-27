create procedure [dbo].[sp_Insert]
@BookName nvarchar(50),
@PublDate datetime,
@UDC nchar(10),
@id int out
as 
insert into Title (BookName, PublDate , UDC)
values (@BookName, @PublDate, @UDC)

set @id=SCOPE_IDENTITY()
GO


