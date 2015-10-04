@ECHO OFF
ECHO.
ECHO.
ECHO You are about to drop and re-create the automatically 
ECHO generated views and stored procedures using osql.
ECHO.
ECHO Server:    GHOLAMI-PC\SQL2012
ECHO.
ECHO Database:  AmlakMaskan
ECHO.
ECHO Press Ctrl+C to quit or
Pause

osql -S GHOLAMI-PC\SQL2012 -E -d AmlakMaskan -n -i 010_ViewsForStoredProcedures.sql
osql -S GHOLAMI-PC\SQL2012 -E -d AmlakMaskan -n -i 020_StoredProcedures_Select.sql
osql -S GHOLAMI-PC\SQL2012 -E -d AmlakMaskan -n -i 030_StoredProcedures_Insert.sql
osql -S GHOLAMI-PC\SQL2012 -E -d AmlakMaskan -n -i 040_StoredProcedures_Update.sql
osql -S GHOLAMI-PC\SQL2012 -E -d AmlakMaskan -n -i 050_StoredProcedures_Delete.sql

ECHO.
ECHO Views and Stored Procedures updated
Pause
