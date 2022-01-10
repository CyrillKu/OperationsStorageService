CREATE TABLE IF NOT EXISTS public."ParentProcesses"
(
    "Id" bigint NOT NULL GENERATED ALWAYS AS IDENTITY ( INCREMENT 1 START 1 MINVALUE 1 MAXVALUE 9223372036854775807 CACHE 1 ),
    "DomainId" integer,
    "OperationId" bigint,
    CONSTRAINT "ParentProcesses_PK" PRIMARY KEY ("Id"),
    CONSTRAINT "ParentProcesses_OperationId_FK" FOREIGN KEY ("OperationId")
        REFERENCES public."Operations" ("Id") MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
)
