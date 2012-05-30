﻿CREATE PROCEDURE [dbo].[SP_CHART_CLTF]
	@beginYear int = 2012, 
	@endYear int = 2023
AS
  SELECT fiscal_year, 
      SUM([Accelerated Area]) AS [Accelerated Area],
      SUM([Preventive Maintenance]) AS [Preventive Maintenance],
      SUM([Tractive Forces]) AS [Tractive Forces], 
      SUM([Tractive Forces (>36 in)]) AS [Tractive Forces (>36 in)]
  FROM (SELECT * FROM VW_CLEANING_ACTIVITIES_BY_DRIVER_TYPE_FISCAL_YEAR WHERE fiscal_year BETWEEN @beginYear AND @endYear) PS
  PIVOT
  (SUM(length_ft) FOR reporting_category IN 
    (
      [Accelerated Area],
      [Preventive Maintenance],
      [Tractive Forces], 
      [Tractive Forces (>36 in)]
    )) AS PVT
  GROUP BY fiscal_year
  ORDER BY fiscal_year