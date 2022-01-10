CREATE TABLE IF NOT EXISTS public."Processes"
(
    "Id" bigint NOT NULL GENERATED ALWAYS AS IDENTITY ( INCREMENT 1 START 1 MINVALUE 1 MAXVALUE 9223372036854775807 CACHE 1 ),
    "DomainId" integer,
    "OperationId" bigint,
    "State" integer,
    "Timestamp" timestamp without time zone,
    "ParentProcessId" integer,
    CONSTRAINT "Processes_PK" PRIMARY KEY ("Id"),
    CONSTRAINT "Processes_OperationId_FK" FOREIGN KEY ("OperationId")
        REFERENCES public."Operations" ("Id") MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
        NOT VALID,
    CONSTRAINT "Processes_ParentProcessId_FK" FOREIGN KEY ("ParentProcessId")
        REFERENCES public."ParentProcesses" ("Id") MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
        NOT VALID
)
