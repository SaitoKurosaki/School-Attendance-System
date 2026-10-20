-- One-time migration: track whether an absent record has an approved excuse letter.
-- Excused absences remain STATUS = 'Absent' but do not count toward FDA.
-- This does not modify the website-managed students or password_reset tables.
ALTER TABLE attendance_records
    ADD COLUMN IS_EXCUSED TINYINT(1) NOT NULL DEFAULT 0 AFTER STATUS;
