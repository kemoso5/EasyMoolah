CREATE TABLE [dbo].[audit_Logs] (
    [Id]            INT           NOT NULL,
    [Progammability] VARCHAR (50)  NULL,
    [Parameters]     VARCHAR (100) NULL,
    [OldXML]         XML           NULL,
    [NewXML]         XML           NULL,
    [Date]           DATETIME      NOT NULL,
    CONSTRAINT [PK_audit_logs] PRIMARY KEY CLUSTERED ([Id] ASC)
);

