CREATE TABLE [dbo].[audit_Login] (
    [logKey]          INT           NOT NULL,
    [logUserName]     VARCHAR (100) NULL,
    [logUserPassword] VARCHAR (100) NULL,
    [logAttempt]      BIT           NULL,
    [logReset]        BIT           NULL,
    [logIPAddress]    VARCHAR (100) NULL,
    [logLoginDate]    DATETIME      NULL,
    [ChangeDate]      DATETIME      NULL,
    [IsActive]        BIT           NULL
);

