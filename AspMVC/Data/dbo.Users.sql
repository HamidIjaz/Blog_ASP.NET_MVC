CREATE TABLE [dbo].[Users] (
    [Id]   INT        IDENTITY (1, 1) NOT NULL,
    [Name] NCHAR (10) NULL,
    [Age]  INT        NULL,
    [Password] CHAR(10) NULL, 
    [Email] CHAR(10) NULL, 
    [Age] CHAR(10) NULL, 
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

