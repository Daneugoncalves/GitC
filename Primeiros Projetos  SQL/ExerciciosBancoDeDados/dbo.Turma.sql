CREATE TABLE [dbo].[Turma] (
    [Id]        INT          IDENTITY (1, 1) NOT NULL,
    [Turma]     VARCHAR (50) NOT NULL,
    [Descrição] VARCHAR (50) NOT NULL,
    CONSTRAINT [PK_Turma] PRIMARY KEY CLUSTERED ([Id] ASC)
);

