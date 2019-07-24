select 
TipoDog,
SUM(Vendas) as 'Total de vendas',
MONTH (DataVenda) as 'Mês'

from FoodTruck

where Id Between 2 and 7
group by TipoDog,MONTH(DataVenda)
order by 'Total de vendas' desc