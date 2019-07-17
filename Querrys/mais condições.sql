select 
		Aluno,
		Idade,
		IIF(Ativo = 1,'ativo','inativo') as 'Status'
	
	from AulaCshap
where Id in

(select Id
	from AulaCshap
	where Idade > 14)

	order by Id desc

