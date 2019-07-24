select
	Nome, materia, (SUM(notas)/COUNT(notas))as 'Media',
	count(notas) as 'provas'

	from notasAlunos

	group by Nome,materia
	order by Nome asc