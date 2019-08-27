CREATE TABLE [dbo].[PatienLocationId] (
    [Id]     INT          IDENTITY (1, 1) NOT NULL,
    [PLI] numeric (4) NULL,
	PRIMARY KEY CLUSTERED ([Id] ASC)
);
GO
insert into PatienLocationId(PLI) values (98);