create database abdulasp
use abdulasp
create table tbl_emp(
id int identity (1,1),
emp_id int ,
emp_name nvarchar(100),
emp_age nvarchar(100),
emp_salary nvarchar(100),
emp_mob nvarchar(100))
select * from tbl_emp
drop table tbl_emp

create proc sp_tbl_emp_ins(
@emp_id int ,
@emp_name nvarchar(100),
@emp_age nvarchar(100),
@emp_salary nvarchar(100),
@emp_mob nvarchar(100))
as begin
insert into tbl_emp(emp_id,emp_name,emp_age,emp_salary,emp_mob)
values(@emp_id,@emp_name,@emp_age,@emp_salary,@emp_mob)
end

----view
create procedure sp_tbl_emp_view
as begin
select * from tbl_emp
end
 
 ---update
 create proc sp_tbl_emp_upd(
@emp_id int ,
@emp_name nvarchar(100),
@emp_age nvarchar(100),
@emp_salary nvarchar(100),
@emp_mob nvarchar(100))
as begin
update tbl_emp 
set emp_id=@emp_id,
emp_name=@emp_name,
emp_age=@emp_age,
emp_salary=@emp_salary,
emp_mob=@emp_mob
where emp_id=@emp_id
end

----delete
create procedure sp_tbl_emp_dlt
@emp_id int
as begin
delete from tbl_emp where emp_id=@emp_id
end


------------get----------
create procedure sp_getstd
@emp_id int
as begin 
select* from tbl_emp where emp_id=@emp_id
end

-----------------------------------------------------------------------------------------------------
---tbl_services
create table tbl_services(
id int identity(1,1) primary key,
service_id int not null,
service_name Nvarchar(100) not null,
service_cost Nvarchar(100) not null
)
-----tbl_services_insert
create procedure sp_tbl_service_insert(
@service_id int ,
@service_name Nvarchar(100) ,
@service_cost Nvarchar(100))
as begin
insert into tbl_services(service_id,service_name,service_cost)
values(@service_id,@service_name,@service_cost)
end
------view
create procedure sp_tbl_service_view
as begin
select * from tbl_services
end
------update
create procedure sp_tbl_services_upd(
@service_id int ,
@service_name Nvarchar(100) ,
@service_cost Nvarchar(100))
as begin
update tbl_services 
set service_id=@service_id,
service_name=@service_name,
service_cost=@service_cost
where service_id=@service_id
end
-----delete
create procedure sp_tbl_services_dlt
@service_id int
as begin
delete from tbl_services where service_id=@service_id
end
------get
create procedure sp_tbl_services_get
@service_id int
as begin
select * from tbl_services where service_id=@service_id
end
------------------------------------------------------------------------------------------------------------------------
----PRODUCT
create table tbl_product(
id int identity(1,1),
product_id int primary key,
product_name nvarchar(100),
product_cost nvarchar(100))
drop table tbl_product
----insert
create procedure sp_tbl_product_insert(
@product_id int ,
@product_name nvarchar(100),
@product_cost nvarchar(100))
as begin
insert into tbl_product(product_id,product_name,product_cost)
values(@product_id,@product_name,@product_cost)
end
drop proc sp_tbl_product_insert
----view
create procedure sp_tbl_product_view
as begin
select * from tbl_product
end
----update
create procedure sp_tbl_product_upd
(@product_id int ,
@product_name nvarchar(100),
@product_cost nvarchar(100))
as begin
update tbl_product set 
product_id=@product_id,
product_name=@product_name,
product_cost=@product_cost
end
drop proc sp_tbl_product_upd
-----delete
create procedure sp_tbl_product_dlt
@product_id int
as begin
delete from tbl_products where product_id=@product_id
end
drop proc sp_tbl_product_dlt
----get
create procedure sp_tbl_product_get
@product_id int
as begin
select * from tbl_product where product_id =@product_id
end
drop procedure sp_tbl_product_get