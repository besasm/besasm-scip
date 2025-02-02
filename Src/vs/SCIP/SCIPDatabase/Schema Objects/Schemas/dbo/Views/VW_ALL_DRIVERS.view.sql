﻿CREATE VIEW [dbo].[VW_ALL_DRIVERS]
	AS
  SELECT A.[driver_id]
        ,A.[compkey]
        ,D.length_ft
        ,D.diamwidth_inches
        ,D.height_inches
        ,E.name AS basin
        ,F.name AS district
        ,B.name AS driver_type
        ,B.reporting_category AS reporting_category
        ,B.driver_type_id AS driver_type_id
        ,B.[rank] AS driver_rank
        ,C.name AS activity_type
        ,C.activity_type_id AS activity_type_id
        ,CASE WHEN A.[override_cost_per_ft] IS NULL THEN B.default_cost_per_ft ELSE A.[override_cost_per_ft] END AS cost_per_ft
        ,CASE WHEN A.[override_frequency_years] IS NULL THEN B.default_frequency_years ELSE A.[override_frequency_years] END AS frequency_years
        ,A.[alternative_id]
        ,A.[updated_by]
        ,A.[update_date]
        ,D.[length_ft]*(CASE WHEN A.[override_cost_per_ft] IS NULL THEN B.default_cost_per_ft ELSE A.[override_cost_per_ft] END) AS driver_cost
  FROM
  (
    (
      (
        (
          (
            [DRIVERS] A INNER JOIN DRIVER_TYPES B ON (A.driver_type_id = B.driver_type_id)
          ) INNER JOIN ACTIVITY_TYPES C ON (B.activity_type_id = C.activity_type_id)
        ) INNER JOIN ALTERNATIVES G ON ((G.alternative_id = A.alternative_id))
      ) INNER JOIN ASSETS D ON ((A.compkey = D.compkey) AND (D.asset_set_id = G.asset_set_id))
    ) INNER JOIN BASINS E ON (E.basin_id = D.basin_id)
  ) INNER JOIN DISTRICTS F ON (F.district_id = D.district_id)
  
