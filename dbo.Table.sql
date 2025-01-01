CREATE TABLE [dbo].[Cadastro]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Nome] NVARCHAR(20) NULL, 
    [Sobrenome] NVARCHAR(100) NULL, 
    [Cidade] NVARCHAR(100) NULL, 
    [Nascimento] DATETIME2 NULL, 
    [Estado] NVARCHAR(2) NULL, 
    [Sexo] NVARCHAR(1) NULL, 
    [Telefone 1] NVARCHAR(11) NULL, 
    [Telefone 2] NVARCHAR(11) NULL 
)


