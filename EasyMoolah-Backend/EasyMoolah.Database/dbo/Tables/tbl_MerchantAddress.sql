CREATE TABLE [dbo].[tbl_MerchantAddress] (
    [Id]        INT           NOT NULL,
    [MerchantKey]   INT           IDENTITY (1, 1) NOT NULL,
    [addStreet]     VARCHAR (100) NULL,
    [addSuburb]     VARCHAR (100) NULL,
    [addCity]       VARCHAR (100) NULL,
    [addProvince]   VARCHAR (100) NULL,
    [addCreateDate] DATETIME      NULL,
    [addChangeDate] DATETIME      NULL,
    [addIsActive]   BIT           NULL,
    CONSTRAINT [PK_tbl_MerchantAddress] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_tbl_MerchantAddress_tbl_Merchant] FOREIGN KEY ([Id]) REFERENCES [dbo].[tbl_Merchant] ([Id])
);

