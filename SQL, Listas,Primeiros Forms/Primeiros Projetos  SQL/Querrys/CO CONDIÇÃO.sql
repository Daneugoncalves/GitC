SELECT 

Modelo,
sum(vendas)as'Vendas em 2019'

from Carros
where ((Carros.DataVenda) >= '2019-01-01')
group by Modelo