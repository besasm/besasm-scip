﻿CREATE INDEX [NEXT_ACTIVITIES_ALTERNATIVEID]
  ON [dbo].[NEXT_ACTIVITIES] ([alternative_id])
  INCLUDE ([compkey])
