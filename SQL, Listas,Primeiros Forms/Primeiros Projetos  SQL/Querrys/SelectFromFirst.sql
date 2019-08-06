select dbo.SacolaDaCooper.CaixaCafe as 'Kg de café',
		dbo.SacolaDaCooper.Leite as 'Kg de leite'
from
		dbo.SacolaDaCooper;

-------------------------------------------------------------

select SacolaDaCooper.CaixaCafe +  
       SacolaDaCooper.Acucar + 
       SacolaDaCooper.[Cerveja lata] + 
       SacolaDaCooper.CervejaBarril + 
       SacolaDaCooper.CErvejaLong + 
       SacolaDaCooper.KilosCarne + 
       SacolaDaCooper.Leite as 'limite de peso' 


from
		dbo.SacolaDaCooper;

------------------------------------------------------------------

select 
	(select leite + Acucar + CaixaCafe 
		from dbo.SacolaDaCooper) as 'CAfe da manha'; (nao usar)

-----------------------------------------------------------------------------------------------------

select 
		id,
		Leite
	from	SacolaDaCooper 
where id = 1
and 	
Leite = 2

-----------------------------------------


insert into SacolaDaCooper
(CaixaCafe,Leite)
values
(9,5);

go
select * from SacolaDaCooper;

-----------------------------------

select * from SacolaDaCooper

where Acucar IS  NULL (OU IS NOT NULL)

and CaixaCafe >  0

--------------------------------------------

delete SacolaDaCooper

where CaixaCafe >  45
go
select * from SacolaDaCooper;