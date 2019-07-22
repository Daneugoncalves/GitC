select 
c.NomeCarro 'Carros mais alocados',
count(l.Carro)'Total de Alocações',
Year(l.Devolucao)'Ano'

from Locacao l 

inner join Carros c on l.Carro = c.Id

WHERE  Year(l.Devolucao) = 2019

group by c.NomeCarro,Year(l.Devolucao)
order by c.NomeCarro,Year(l.Devolucao) desc
