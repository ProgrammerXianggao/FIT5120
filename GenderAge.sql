CREATE TABLE [dbo].[GenderAgeSafety] (
    [Id]           INT             IDENTITY (1, 1) NOT NULL,
    [Age]          VARCHAR (MAX)   NOT NULL,
    [Gender]       VARCHAR (MAX)   NOT NULL,
    [Assault]      NUMERIC (10, 3) NOT NULL,
    [Total]        NUMERIC (10, 3) NOT NULL,
    [Violencerate] NUMERIC (10, 3) NOT NULL,
    [Levell]       VARCHAR (MAX)   NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);
GO
INSERT INTO [dbo].[GenderAgeSafety] ([Age], [Gender], [Assault], [Total], [Violencerate], [Levell]) VALUES ('18-24', 'MALE', 20.200, 307.000 , 0.066, 'RELATIVELY HIGH');
INSERT INTO [dbo].[GenderAgeSafety] ([Age], [Gender], [Assault], [Total], [Violencerate], [Levell]) VALUES ( '25-34', 'MALE', 36.000, 477.400 , 0.075, 'HIGH');
INSERT INTO [dbo].[GenderAgeSafety] ([Age], [Gender], [Assault], [Total], [Violencerate], [Levell]) VALUES ( '35-44', 'MALE', 20.100, 428.000 , 0.047, 'MEDIUM');
INSERT INTO [dbo].[GenderAgeSafety] ([Age], [Gender], [Assault], [Total], [Violencerate], [Levell]) VALUES ( '45-54', 'MALE', 11.600, 416.400 , 0.028, 'LOW');
INSERT INTO [dbo].[GenderAgeSafety] ([Age], [Gender], [Assault], [Total], [Violencerate], [Levell]) VALUES ( '55-64', 'MALE', 7.700, 368.600 , 0.021, 'LOW');
INSERT INTO [dbo].[GenderAgeSafety] ([Age], [Gender], [Assault], [Total], [Violencerate], [Levell]) VALUES ( '65+', 'MALE', 5.200, 456.200 , 0.011, 'REALLY LOW');
INSERT INTO [dbo].[GenderAgeSafety] ([Age], [Gender], [Assault], [Total], [Violencerate], [Levell]) VALUES ( '18-24', 'FEMALE', 32.217, 286.015 , 0.113, 'HIGH');
INSERT INTO [dbo].[GenderAgeSafety] ([Age], [Gender], [Assault], [Total], [Violencerate], [Levell]) VALUES ( '25-34', 'FEMALE', 30.053, 467.392, 0.064, 'RELATIVELY HIGH');
INSERT INTO [dbo].[GenderAgeSafety] ([Age], [Gender], [Assault], [Total], [Violencerate], [Levell]) VALUES ( '35-44', 'FEMALE', 14.763, 420.049 , 0.035, 'MEDIUM');
INSERT INTO [dbo].[GenderAgeSafety] ([Age], [Gender], [Assault], [Total], [Violencerate], [Levell]) VALUES ( '45-54', 'FEMALE', 14.588, 414.590 , 0.035, 'MEDIUM');
INSERT INTO [dbo].[GenderAgeSafety] ([Age], [Gender], [Assault], [Total], [Violencerate], [Levell]) VALUES ( '55-64', 'FEMALE', 7.572, 369.899, 0.020, 'LOW');
INSERT INTO [dbo].[GenderAgeSafety] ([Age], [Gender], [Assault], [Total], [Violencerate], [Levell]) VALUES ( '65+', 'FEMALE', 4.297, 479.247, 0.009, 'REALLY LOW');