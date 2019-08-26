CREATE TABLE [dbo].[GenderAgeSafety] (
    [Id]     INT         IDENTITY (1, 1) NOT NULL,
	[Age]   VARCHAR(10) NOT NULL,
	[Gender] VARCHAR (MAX)  NOT NULL,
    [Assault]  NUMERIC (10,3) NOT NULL,
    [Total] NUMERIC (10,3) NOT NULL,
    [Violencerate]  NUMERIC (10,3) NOT NULL,
    [Levell] VARCHAR (MAX) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);
GO
insert into GenderAgeSafety(Gender,Age,Assault,Total,Violencerate,Levell) values ('MALE','18-24',20.2,307.0,0.066,'RELATIVELY HIGH');
insert into GenderAgeSafety(Gender,Age,Assault,Total,Violencerate,Levell) values ('MALE','25-34',36.0,477.4,0.075,'HIGH');
insert into GenderAgeSafety(Gender,Age,Assault,Total,Violencerate,Levell) values ('MALE','35-44',20.1,428.0,0.047,'MEDIUM');
insert into GenderAgeSafety(Gender,Age,Assault,Total,Violencerate,Levell) values ('MALE','45-54',11.6,416.4,0.028,'LOW');
insert into GenderAgeSafety(Gender,Age,Assault,Total,Violencerate,Levell) values ('MALE','55-64',7.7,368.6,0.021,'LOW');
insert into GenderAgeSafety(Gender,Age,Assault,Total,Violencerate,Levell) values ('MALE','65+',5.2,456.2,0.011,'REALLY LOW')
insert into GenderAgeSafety(Gender,Age,Assault,Total,Violencerate,Levell) values ('FEMALE','18-24',32.217,286.015,0.113,'HIGH')
insert into GenderAgeSafety(Gender,Age,Assault,Total,Violencerate,Levell) values ('FEMALE','25-34',30.053,467.392,0.064,'RELATIVELY HIGH')
insert into GenderAgeSafety(Gender,Age,Assault,Total,Violencerate,Levell) values ('FEMALE','35-44',14.763,420.049,0.035,'MEDIUM')
insert into GenderAgeSafety(Gender,Age,Assault,Total,Violencerate,Levell) values ('FEMALE','45-54',14.588,414.590,0.035,'MEDIUM')
insert into GenderAgeSafety(Gender,Age,Assault,Total,Violencerate,Levell) values ('FEMALE','55-64',7.572,369.899,0.020,'LOW')
insert into GenderAgeSafety(Gender,Age,Assault,Total,Violencerate,Levell) values ('FEMALE','65+',4.297,479.247,0.009,'REALLY LOW')
