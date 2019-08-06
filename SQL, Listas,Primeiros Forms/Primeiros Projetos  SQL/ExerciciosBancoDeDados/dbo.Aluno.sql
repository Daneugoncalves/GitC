CREATE TABLE [dbo].[Aluno] (
    [Id]         INT           IDENTITY (1, 1) NOT NULL,
    [Nome]       VARCHAR (100) NOT NULL,
    [Matricula]  INT           NOT NULL,
    [Frequencia] BIT           NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

