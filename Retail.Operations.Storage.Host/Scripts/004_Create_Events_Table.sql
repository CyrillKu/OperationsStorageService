CREATE TABLE IF NOT EXISTS public."Events"
(
    "Id" bigint NOT NULL GENERATED ALWAYS AS IDENTITY ( INCREMENT 1 START 1 MINVALUE 1 MAXVALUE 9223372036854775807 CACHE 1 ),
    "EventId" uuid,
    "AggregationId" text COLLATE pg_catalog."default",
    "DomainId" integer,
    "ProcessId" bigint,
    "Content" bytea,
    "Timestamp" timestamp without time zone,
    CONSTRAINT "Events_PK" PRIMARY KEY ("Id"),
    CONSTRAINT "Events_ProcessId_FK" FOREIGN KEY ("ProcessId")
        REFERENCES public."Processes" ("Id") MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
        NOT VALID
)