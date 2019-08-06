Select 
a.Nome,
sum(nt.Nota)/count(NT.Nota)as 'Média',

IIF((sum(nt.nota) / count(nt.nota)) >= 7,'aprovado', 'reprovado') as 'Status de nota' ,

IIF((SUM(CONVERT(MONEY,NT.Presença)) / CONVERT(MONEY,COUNT(NT.Presença)) * 100) >= 75, 'aprovado', 'reprovado') AS 'Status de Frequencia'


from Aluno A

INNER JOIN Notas NT on A.Id = NT.aluno

GROUP BY A.Nome