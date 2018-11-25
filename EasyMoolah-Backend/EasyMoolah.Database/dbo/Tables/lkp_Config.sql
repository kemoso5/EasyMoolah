CREATE TABLE [dbo].[lkp_Config] (
    [Id]       INT           NOT NULL,
    [Type]      VARCHAR (100) NULL,
    [Value]     VARCHAR (MAX) NULL,
    [StartDate] XML           NULL,
    [EndDate]   XML           NULL,
    [IsActive]  BIT           NOT NULL,
    CONSTRAINT [PK_lkp_config] PRIMARY KEY CLUSTERED ([Id] ASC)
);

