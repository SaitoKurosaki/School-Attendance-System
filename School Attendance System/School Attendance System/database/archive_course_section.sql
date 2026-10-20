-- One-time migration: adds soft-archive flags to catalog tables only.
-- The local school database already has these columns applied.
-- This migration intentionally does not alter students or password_reset.
ALTER TABLE course
    ADD COLUMN IS_ARCHIVED TINYINT(1) NOT NULL DEFAULT 0;

ALTER TABLE section
    ADD COLUMN IS_ARCHIVED TINYINT(1) NOT NULL DEFAULT 0;
