﻿CREATE TABLE [dbo].[VARIABLES] (
    [VariableName]   NVARCHAR (128) NOT NULL,
    [VariableValue]  NUMERIC (18)   NULL,
    [VariableString] NVARCHAR (128) NULL,
    CONSTRAINT [PK_VARIABLES] PRIMARY KEY CLUSTERED ([VariableName] ASC) WITH (FILLFACTOR = 90)
);

