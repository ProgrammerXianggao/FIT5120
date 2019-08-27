CREATE TABLE [dbo].[Checkboxone] (
    [Id]     INT          IDENTITY (1, 1) NOT NULL,
    [content] VARCHAR (MAX) NULL
	PRIMARY KEY CLUSTERED ([Id] ASC)
);
GO
insert into Checkboxone (content) values ('Presenting with injuries inflicted by self or others');
insert into Checkboxone (content) values ('Substabce or alcohol affected');
insert into Checkboxone (content) values ('Behavioural disturbance');
insert into Checkboxone (content) values ('Stating intention to harm self or others');
insert into Checkboxone (content) values ('Hyper-vigilance');
insert into Checkboxone (content) values ('Suspected of having weapons');
insert into Checkboxone (content) values ('Confusion');