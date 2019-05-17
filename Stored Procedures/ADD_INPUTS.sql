create procedure ADD_INPUTS 
@X float,
@Y float 
as
insert into Input_X (X) values (@X);
insert into Input_Y (Y) values (@Y);
