select 

count(l.Carro)'Total de Alocações',
--MONTH(l.Devolucao)'Mês da locação',
MOnth(l.Devolucao)  'Mês da locação',
yEAR(l.Devolucao) 'Ano da locação'
from Locacao l 

inner join Carros c on l.Carro = c.Id

group by Month(l.Devolucao), YEAR(l.Devolucao)
order by Year(l.Devolucao) desc