CREATE PROCEDURE CALCULATE
as

insert into Calc (X,Operation,Y)
select * from Input_X  cross join Operation  cross join Input_Y;

update Calc set Results = X + Y where Operation = '+';
update Calc set Results = X - Y where Operation = '-';
update Calc set Results = X * Y where Operation = '*';
update Calc set Results = X / Y where Operation = '/';

insert into Results
select Results from Calc;

