CREATE TABLE [dbo].[Precaution] (
    [Id]     INT         IDENTITY (1, 1) NOT NULL,
    [First]  NUMERIC (1) NULL,
    [Second] NUMERIC (1) NULL,
    [Third]  NUMERIC (1) NULL,
    [Fourth] NUMERIC (1) NULL,
    [Fifth]  NUMERIC (1) NULL,
    [Sixth]  NUMERIC (1) NULL,
	[Seventh]  NUMERIC (1) NULL,
	[Eighth]  NUMERIC (1) NULL,
	[Nineth]  NUMERIC (1) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);
GO
insert into Precaution (First,Second,Third,Fourth,Fifth,Sixth,Seventh,Eighth,Nineth) values(1,1,1,1,1,1,1,1,1)
