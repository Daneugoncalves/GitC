Select tr.Nome as 'Turma', 
		a.Aluno as 'Alunos'
		

from turmas tr inner join TurmaAlunos ta on tr.Id = ta.Turma
inner join Alunos a on ta.Aluno=a.Id
left join Diario d on tr.Id = d.Turma;

select 
		d.[Data],
		tr.Aluno,
		--a.Aluno,
		(n.Nota) as 'Média' ,
		IIF(COUNT(p.Id) = 1,'Presente', 'Ausente') as 'Presenças'
		
	from Diario d

	inner join TurmaAlunos tr on d.Turma = tr.Turma
	--inner join Turmas t on d.Turma = t.Id
	--inner join Alunos a on tr.Aluno = a.Id
	left join Presenca P on d.Id = p.Diario and tr.Aluno = p.Aluno
	left join Nota n on tr.Aluno = n.Aluno and d.Id = n.Diario
	group by d.[Data],tr.Aluno,n.Nota

