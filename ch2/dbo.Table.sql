CREATE TABLE [dbo].[tToDo]
(
	[fId] INT NOT NULL  IDENTITY, 
    [fTitle] NVARCHAR(50) NULL, 
    [fLevel] NVARCHAR(50) NULL, 
    [fDate] DATE NULL, 
    CONSTRAINT [PK_tToDo] PRIMARY KEY ([fId])
)
