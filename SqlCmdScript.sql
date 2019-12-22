use master
go

if db_id('capgemini') is not null
	drop database capgemini;
	GO

create database capgemini;
GO

use capgemini;
create table people (PersonId int Primary Key, Name nvarchar(50));
insert into people values (1,'julie');
insert into people values (2,'giantpuppy');
