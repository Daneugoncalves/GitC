select
TipoDog,
SUM(Vendas) as 'vendas',

MONTH(DataVenda) as 'Mês'

from foodTruck
group by TipoDog,DataVenda
order by TipoDog