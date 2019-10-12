CREATE TABLE [dbo].[experience] (
    [Id]           INT             IDENTITY (1, 1) NOT NULL,
	[Category]  VARCHAR(max) NOT NULL,
    [Title]       VARCHAR (100)   NOT NULL,
    [Content]  VARCHAR (MAX) NOT NULL,
	[Visible] VARCHAR (1) DEFAULT 0 NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
	CHECK (Category IN ('Physical Abuse', 'Sexual Abuse', 'Emotional Abuse','Psychological Abuse','Other'))
);