CREATE TABLE [dbo].[Diarios]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY (1,1),
	[Data] DATETIME NOT NULL DEFAULT GETDATE(),
	[Turma] int NOT NULL,
	[Obs] VARCHAR (500) NOT NULL,
	[Ativo] BIT NOT NULL,
	[UsuInc] int not null,
	[UsuAlt] int not null,
	DataInc datetime not null default getdate(), 
	DataAlt datetime not null default getdate(), 
    CONSTRAINT [FK_Diarios_Turma] FOREIGN KEY ([Turma]) REFERENCES [Turmas]([Id]),
	CONSTRAINT [FK_Diarios_Usuarios_Inc] FOREIGN KEY ([UsuInc]) REFERENCES [Usuarios]([Id]),
    CONSTRAINT [FK_Diarios_Usuarios_Alt] FOREIGN KEY ([UsuAlt]) REFERENCES [Usuarios]([Id]),
)
