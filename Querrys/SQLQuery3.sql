select 
       Id,
	   Nome,
	   Materia,
	   ((nota1 + nota2 + nota3 + nota4 + nota5 + nota6)/6) as 'Media do aluno',
	   IIF(((nota1 + nota2 + nota3 + nota4 + nota5 + nota6)/6) >=7,'aprovado','reprovado')as 'status',
	   IIF((Id) = 1, 'Melhor da turma', 'Pode melhorar') as 'OBSERVAÇÃO'	  
from Diario2

where 

Nome <> 'Daniel' or
Materia = 'matematica#';