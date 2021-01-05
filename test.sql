-- -------------------------------------------------------------
-- TablePlus 3.9.1(342)
--
-- https://tableplus.com/
--
-- Database: test
-- Generation Time: 2021-01-05 10:22:41.1950
-- -------------------------------------------------------------


-- This script only contains the table creation statements and does not fully represent the table in the database. It's still missing: indices, triggers. Do not use it as a backup.

-- Sequence and defined type
CREATE SEQUENCE IF NOT EXISTS p_id_seq;

-- Table Definition
CREATE TABLE "public"."p" (
    "id" int4 NOT NULL DEFAULT nextval('p_id_seq'::regclass),
    "name" varchar,
    PRIMARY KEY ("id")
);

-- This script only contains the table creation statements and does not fully represent the table in the database. It's still missing: indices, triggers. Do not use it as a backup.

-- Sequence and defined type
CREATE SEQUENCE IF NOT EXISTS post_id_seq;

-- Table Definition
CREATE TABLE "public"."post" (
    "id" int4 NOT NULL DEFAULT nextval('post_id_seq'::regclass),
    "user_id" int4 NOT NULL,
    "content" text NOT NULL,
    "created" timetz,
    "updated" timetz,
    PRIMARY KEY ("id")
);

-- This script only contains the table creation statements and does not fully represent the table in the database. It's still missing: indices, triggers. Do not use it as a backup.

-- Table Definition
CREATE TABLE "public"."user" (
    "first_name" varchar(150) NOT NULL,
    "id" int4 NOT NULL,
    "last_name" varchar(150) NOT NULL,
    "email" varchar(150) NOT NULL,
    "password" varchar(150) NOT NULL,
    PRIMARY KEY ("id")
);

-- This script only contains the table creation statements and does not fully represent the table in the database. It's still missing: indices, triggers. Do not use it as a backup.

-- Sequence and defined type
CREATE SEQUENCE IF NOT EXISTS user_profile_id_seq;

-- Table Definition
CREATE TABLE "public"."user_profile" (
    "id" int4 NOT NULL DEFAULT nextval('user_profile_id_seq'::regclass),
    "user_id" int4,
    "marital_status" varchar,
    "gender" varchar,
    "created" timetz,
    "updated" timetz,
    PRIMARY KEY ("id")
);

ALTER TABLE "public"."post" ADD FOREIGN KEY ("user_id") REFERENCES "public"."user"("id");
ALTER TABLE "public"."user_profile" ADD FOREIGN KEY ("user_id") REFERENCES "public"."user"("id");
