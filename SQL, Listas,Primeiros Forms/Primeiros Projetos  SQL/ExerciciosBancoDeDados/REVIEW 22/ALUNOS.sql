CREATE TABLE [dbo].[Alunos]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [Aluno] VARCHAR(110) NOT NULL,
    [Ativo] bit NOT NULL,
    [UsuInc] int not null,
	[UsuAlt] int not null,
	DataInc datetime not null default getdate(), 
	DataAlt datetime not null default getdate(), 
    CONSTRAINT [FK_Alunos_Usuarios_Inc] FOREIGN KEY ([UsuInc]) REFERENCES [Usuarios]([Id]),
    CONSTRAINT [FK_Alunos_Usuarios_Alt] FOREIGN KEY ([UsuAlt]) REFERENCES [Usuarios]([Id]),
)
