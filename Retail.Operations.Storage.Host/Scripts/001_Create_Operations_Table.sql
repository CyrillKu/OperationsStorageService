CREATE TABLE IF NOT EXISTS public."Operations"
(
    "Id" bigint NOT NULL GENERATED ALWAYS AS IDENTITY ( INCREMENT 1 START 1 MINVALUE 1 MAXVALUE 9223372036854775807 CACHE 1 ),
    "Status" integer,
    "Timestamp" timestamp without time zone,
    CONSTRAINT "Operations_PK" PRIMARY KEY ("Id")
)