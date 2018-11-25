CREATE TABLE [dbo].[lkp_MerchantIndustry] (
    [Id]         INT           IDENTITY (1, 1) NOT NULL,
    [Name]        VARCHAR (50)  NULL,
    [Description] VARCHAR (100) NULL,
    [ParentId]   INT           NULL,
    [CreateDate]  DATETIME      NOT NULL,
    [ChangeDate]  DATETIME      NOT NULL,
    [IsActive]    BIT           NOT NULL,
    CONSTRAINT [PK_lkp_MerchantIndustry] PRIMARY KEY CLUSTERED ([Id] ASC)
);

