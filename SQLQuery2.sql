Create table [dbo].[Locationiddd](
    [Id]     INT          IDENTITY (1, 1) NOT NULL,
    [locationID] VARCHAR (MAX) NULL
	PRIMARY KEY CLUSTERED ([Id] ASC)
);
GO
insert into Locationiddd (locationID) values (98);