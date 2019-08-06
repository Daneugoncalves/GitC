CREATE TABLE [dbo].[Notas] (
    [Id]    INT      IDENTITY (1, 1) NOT NULL,
    [Nota]  INT      NOT NULL,
	[Presença] BIT NOT NULL,
    [Data]  DATETIME DEFAULT (getdate()) NOT NULL,
    [aluno] INT      NOT NULL,
    [Turma] INT      NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Notas_Aluno] FOREIGN KEY ([aluno]) REFERENCES [dbo].[Aluno] ([Id]),
    CONSTRAINT [FK_Notas_Turma] FOREIGN KEY ([Turma]) REFERENCES [dbo].[Turma] ([Id])
);

