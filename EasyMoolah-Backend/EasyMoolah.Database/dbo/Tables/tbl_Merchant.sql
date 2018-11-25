CREATE TABLE [dbo].[tbl_Merchant] (
    [Id]                INT             IDENTITY (1, 1) NOT NULL,
    [Name]               VARCHAR (100)   NULL,
    [Description]        VARCHAR (250)   NULL,
    [EstablishedYear]    INT             NULL,
    [URL]                VARCHAR (100)   NULL,
    [ContactNumber]      VARCHAR (50)    NULL,
    [AnnualRevenueSales] DECIMAL (18, 4) NULL,
    [AverageTicket]      DECIMAL (18, 4) NULL,
    [FinanceOffered]     BIT             NULL,
    [IndustryId]        INT             NULL,
    [CreateDate]         DATETIME        NULL,
    [ChangeDate]         DATETIME        NULL,
    [IsActive]           BIT             NULL,
    CONSTRAINT [PK_tbl_Merchant] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_tbl_Merchant_lkp_MerchantIndustry] FOREIGN KEY ([IndustryId]) REFERENCES [dbo].[lkp_MerchantIndustry] ([Id])
);

