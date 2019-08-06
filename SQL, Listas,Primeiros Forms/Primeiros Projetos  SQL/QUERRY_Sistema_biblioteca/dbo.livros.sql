CREATE TABLE [dbo].[Livros]
(
	[Id] INT NOT NULL PRIMARY KEY identity (1,1), 
    [Titulo] VARCHAR(200) NOT NULL, 
    [Isbn] VARCHAR(15) NOT NULL, 
    [Genero] INT NOT NULL, 
    [Editora] INT NOT NULL, 
    [Sinopse] text NULL
)
