CREATE TABLE [dbo].[ResultOperation] (
    [Id]           INT  NOT NULL,
    [OperationID]  INT  NULL,
    [Result]       INT  NULL,
    [Args]         INT  NULL,
    [CreationData] DATE NULL,
    [Status]       BIT  NULL,
    [UserID]       INT  NULL,
    [ExecTime]     INT  NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[Operation] (
    [Id]        INT        NOT NULL,
    [Name]      NCHAR (15) NULL,
    [Rating]    INT        NULL,
    [ArgsCount] INT        NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


CREATE TABLE [dbo].[User] (
    [Id]       INT        NOT NULL,
    [Login]    NCHAR (15) NULL,
    [Password] NCHAR (15) NULL,
    [Roles]    NCHAR (15) NULL,
    [Email]    NCHAR (30) NULL,
    [BirthDay] DATE       NULL,
    [Status]   NCHAR (15) NULL,
    [Sex]      BIT        NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

