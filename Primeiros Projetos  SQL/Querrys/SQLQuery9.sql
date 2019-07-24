SELECT 
Modelo,
sum(vendas)as'Vendas',
YEAR(DataVenda) 'Ano da venda'
from Carros
where (year(Carros.DataVenda) = 2019)
group by Modelo,DataVenda
