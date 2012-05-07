﻿CREATE TABLE [dbo].[ASSETS] (
    [COMPKEY]                   INT         NOT NULL,
    [length_ft]                 INT         NOT NULL,
    [diamWidth_inches]          FLOAT       NOT NULL,
    [height_inches]             FLOAT       NULL,
    [basin_id]                  VARCHAR (3) NOT NULL,
	  [district_id]               VARCHAR (4) NOT NULL,
    [last_inspection_date]      DATETIME    NULL,
    [last_root_management_date] DATETIME    NULL,
    [last_cleaning_date]        DATETIME    NULL,
    [structural_grade]          INT         NULL
);
