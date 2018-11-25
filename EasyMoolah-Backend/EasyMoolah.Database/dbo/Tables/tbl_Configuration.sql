CREATE TABLE [dbo].[tbl_Configuration] (
    [conKey]        INT          IDENTITY (1, 1) NOT NULL,
    [conField]      VARCHAR (50) NULL,
    [conValue]      VARCHAR (50) NULL,
    [conParentKey]  INT          NULL,
    [conCreateDate] DATETIME     NULL,
    [conChangeDate] DATETIME     NULL,
    [conIsActive]   BIT          NULL,
    CONSTRAINT [PK_tbl_Configuration] PRIMARY KEY CLUSTERED ([conKey] ASC)
);

