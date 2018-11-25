CREATE TABLE [dbo].[tbl_Login] (
    [Id]              INT              IDENTITY (1, 1) NOT NULL,
    [UserName]         VARCHAR (100)    NOT NULL,
    [Password]         VARCHAR (100)    NULL,
    [IsLocked]         BIT              NULL,
    [IsConfirmd]      BIT              NULL,
    [ConfirmationGUID] UNIQUEIDENTIFIER NULL,
    [CreateDate]       DATETIME         NOT NULL,
    [ChangeDate]       DATETIME         NOT NULL,
    [IsActive]         BIT              NOT NULL,
    CONSTRAINT [PK_tbl_Login] PRIMARY KEY CLUSTERED ([Id] ASC)
);

