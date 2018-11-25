CREATE TABLE [dbo].[lkp_BorrowerQuestion]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [QuestionDescription] VARCHAR(250) NULL, 
    [QuestionId] INT NULL, 
    [AnswerDescription] VARCHAR(250) NULL, 
    [Control] VARCHAR(50) NULL, 
    [CreatedDate] DATETIME NULL, 
    [ChangedDate] DATETIME NULL, 
    [IsActive] BIT NULL
)
