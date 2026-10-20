-- Removes the optional parent-email delivery log. Attendance email sending
-- remains in the application; delivery diagnostics go to the debug output.
DROP TABLE IF EXISTS parent_email_log;
