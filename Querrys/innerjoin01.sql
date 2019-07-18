Select 
BL.Nome,
COUNT(LV.Id) as 'Quantidades De Livros'
US.nome
	from Biblioteca BL
		inner join Livros LV on BL.Id = LV.Biblioteca
		inner join Usuario US on BL.Id = LV.Us

		group by BL.Nome