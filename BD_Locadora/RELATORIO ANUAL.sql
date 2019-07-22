select 

count(l.Carro)'Total de Alocações',
--MONTH(l.Devolucao)'Mês da locação',
Year(l.Devolucao)'Ano da locação'
from Locacao l 

inner join Carros c on l.Carro = c.Id

group by Year(l.Devolucao)
order by year(l.Devolucao) desc