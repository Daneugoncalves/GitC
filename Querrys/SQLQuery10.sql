select 
Modelo,

(SUM(Vendas)/ COUNT(*)) as 'Média',
YEAR(DataVenda) as 'Ano'

from Carros
group by Modelo,Ano,YEAR(DataVenda)
