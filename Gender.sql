CREATE TABLE [dbo].[Gender] (
    [Id]     INT          IDENTITY (1, 1) NOT NULL,
    [genderr] VARCHAR (MAX) NULL
	PRIMARY KEY CLUSTERED ([Id] ASC)
);
GO
insert into Gender (genderr) values ('FEMALE');