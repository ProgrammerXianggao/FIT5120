CREATE TABLE [dbo].[Age] (
    [Id]     INT         IDENTITY (1, 1) NOT NULL,
    [Age]  VARCHAR (MAX) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);
GO
insert into Age (Age) values ('20');

