--4Trazer somente as marcas que Felipe cadastrou
Select 
m.Nome

from Marcas m
where UsuInc=1;
--5Trazer somente as marcas que Giomar cadastrou
Select 
m.Nome

from Marcas m
where UsuInc=2;
--7Trazer somente a quantidade de marcas que Felipe cadastrou do maior para menor
Select 
m.Nome,
m.UsuInc

from Marcas m
where UsuInc=1
order by m.Nome desc;
--8Trazer somente a quantidade de marcas que Giomar cadastrou do menor para maior
Select 
m.Nome,
m.UsuInc

from Marcas m
where UsuInc=2
order by m.Nome asc;


--10Trazer somente a quantidade de marcas que Felipe e Giomar cadastraram 

Select 
count(m.Nome)'Quatidade de marcas'

from Marcas m
where UsuInc=1 or UsuInc=2
order by count(m.Nome);

--12Trazer somente os carros que Felipe cadastrou
select 

c.Modelo 

from Carros c

where c.UsuInc = 1


--13Trazer somente os carros que Giomar cadastrou

select 

c.Modelo 

from Carros c

where c.UsuInc = 2





--15Trazer somente a quantidade de carros que Felipe cadastrou maior para menor
select 
count(c.Modelo)'Quantidade carros felipe'

from
Carros c
where c.UsuInc =1
order by  count(c.Modelo) desc;

--16Trazer somente a quantidade de carros que Giomar cadastrou menor para maior
select 
count(c.Modelo)'Quantidade carros Giomar'

from
Carros c
where c.UsuInc =2
order by  count(c.Modelo) asc;

--18Trazer somente a quantidade de carros que Felipe e Giomar cadastraram 

select 
count(c.Modelo)'Quantidade carros Giomar e felipe'

from
Carros c
where c.UsuInc =1 or c.UsuInc=2
order by  count(c.Modelo) desc;

--20Trazer somente os carros das marcas que Felipe cadastrou
select 
c.Modelo
from Carros c
inner join Marcas m on m.Id = c.Marca
where c.UsuInc = 1;

--21Trazer somente os carros das marcas que Giomar cadastrou
select 
c.Modelo
from Carros c
inner join Marcas m on m.Id = c.Marca
where c.UsuInc = 2;

--23Trazer somente a quantidade de carros das marcas que Felipe cadastrou maior para menor
Select 
count(c.Modelo)'Carros felipe cadastrou'
from Carros c
where UsuInc=1
order by count(c.Modelo) desc;

--24Trazer somente a quantidade de carros das marcas que Giomar cadastrou menor para maior
Select 
count(c.Modelo)'Carros que Giomar cadastrou'
from Carros c
where UsuInc=2
order by count(c.Modelo) asc;

--26Trazer o valor total de vendas 2019 isolado

select 
sum(Valor)'Valor total das vendas'

from vendas v

WHERE Year(v.DatInc)=2019;

--27Trazer a quantidade total de vendas 2019 isolado

select 
sum(QUANTIDADE)'Total vendas 2019'

FROM Vendas v

WHERE Year(v.DatInc)=2019;

--29Trazer o valor total de vendas em cada ano e ordernar do maior para o menor

select 
year(v.DatInc)'Ano da venda',
sum(v.Valor)'Valor total das vendas'

from vendas v
group by year(v.DatInc)
order by sum(v.Valor) desc;

--30Trazer a quantidade de vendas em cada ano e ordernar do maior para o menor

select 
year(v.DatInc)'Ano das venda',
Sum(v.Quantidade)'total das vendas'
from vendas v
group by year(v.DatInc)
order by Sum(v.Quantidade) desc;

--32Trazer o mês de cada ano que retornou a maior quantidade de vendas
select 

year(v.DatInc)'Ano das venda',
month(v.DatInc)'Mês da Venda',
sum(v.Quantidade)'Quantidade de Vendas'

from vendas v

group by  month(v.DatInc),year(v.DatInc)
order by sum(v.Quantidade) desc ;

--35Trazer o mês de cada ano que retornou o maior valor de vendas
select

month(v.DatInc)'Mês da Venda',
sum(v.Quantidade)'Quantidade de Vendas'

from vendas v

group by  month(v.DatInc)
order by sum(v.Quantidade) desc ;

--38Trazer o valor total de vendas que Felipe realizou

select 
Sum(v.Valor)'Valor total vendas Felipe'
from Vendas v
where v.UsuAlt=1;

--39Trazer o valor total de vendas que Giomar realizou

select 
Sum(v.Valor)'Valor total vendas Giomar'
from Vendas v
where v.UsuAlt=2;

--41Trazer a quantidade total de vendas que Felipe realizou

select 
Sum(v.Quantidade)'Quantidade total vendas Felipe'
from Vendas v
where v.UsuAlt=1;

--42Trazer a quantidade de vendas que Giomar realizou

select 
Sum(v.Quantidade)'Quantidade total vendas Giomar'
from Vendas v
where v.UsuAlt=2;

--44trazer a quantidade total de vendas que Felipe e Giomar realizaram ordenando do maior para menor
select 
u.Usuario,
Sum(v.Quantidade)'Quantidade total vendas'

from Vendas v
inner join Usuarios u on v.UsuAlt = u.Id 

group by u.Usuario
order by Sum(v.Quantidade) desc;

--45Trazer o valor de vendas que Felipe e Giomar realizaram ordenando do maior para menor

select 
u.usuario,
SUM(v.valor)'Valor total das Vendas'
from vendas v
inner join Usuarios u on v.UsuAlt = u.Id 
group by u.Usuario
order by SUM(v.valor) desc;

--47Trazer  a marca mais vendida de todos os anos

select 
YEAR(v.DatInc)'Ano da venda',
m.nome'Nome da Marca',
Sum(v.Quantidade)'Quantidade total vendas'

from Marcas m
inner join carros c on c.Marca = m.Id
inner join Vendas v on v.Carro = c.Id
 
group by YEAR(v.DatInc),m.nome
order by Sum(v.Quantidade) desc

--49Trazer o valor total da marca mais vendida de todos os anos
select 

YEAR(v.DatInc)'Ano da venda',
m.nome'Nome da Marca',
Sum(v.Valor)'Valor total vendas'

from vendas v
inner join carros c on c.id = v.Carro
inner join marcas m on m.Id = c.Marca
 
group by YEAR(v.DatInc),m.nome
order by Sum(v.Valor) desc

--51Trazer a quantidade do carro mais vendido de todos os anos

select top 1 percent

c.modelo 'modelo do carro',
sum(v.Quantidade)'total de vendas'

from vendas v
inner join carros c on c.id = v.Carro
 
group by c.Modelo
order by Sum(v.Quantidade) desc

--52Trazer o valor do carro mais vendido de todos os anos

Select top 1 percent
c.modelo,
(sum(v.Quantidade)*(sum(v.Valor)))'Valor total das vendas'

from Vendas v

inner join Carros c on c.Id = v.Carro
group by c.modelo
order by'Valor total das vendas' desc