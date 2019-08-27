CREATE TABLE [dbo].[Checkboxtwo] (
    [Id]     INT          IDENTITY (1, 1) NOT NULL,
    [content] VARCHAR (MAX) NULL
	PRIMARY KEY CLUSTERED ([Id] ASC)
);
GO
insert into Checkboxtwo (content) values ('Emergency response plan in place');
insert into Checkboxtwo (content) values ('Securoty back-up');
insert into Checkboxtwo (content) values ('Duty administrator,senior clinician, psychiatric consultant nurse, patient advocate consulte consulted/advised');
insert into Checkboxtwo (content) values ('Other staff are aware of the risk');
insert into Checkboxtwo (content) values ('Safety first(never engage if you have concerns for safetwo');
insert into Checkboxtwo (content) values ('Safety tips reviewed');
insert into Checkboxtwo (content) values ('Personal protection, communication devices and duress alarms reviewed');
insert into Checkboxtwo (content) values ('Environment checked for safety hazards');
insert into Checkboxtwo (content) values ('Adequate staffing (assessment of client by at least two staff)');