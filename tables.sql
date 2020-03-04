CREATE TABLE [dbo].[Lieu]
(
	[Id] VARCHAR(25) NOT NULL PRIMARY KEY, 
    [nom] VARCHAR(50) NOT NULL, 
    [lieu] VARCHAR(50) NULL
);

CREATE TABLE [dbo].[Evenement] (
    [Id]          VARCHAR (25) NOT NULL,
    [lieu]      VARCHAR (25) NULL,
	[nom] VARCHAR(50) NOT NULL, 
    [date]        DATETIME        NULL,
    [coordinates] TEXT         NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [lieuFK] FOREIGN KEY ([lieu]) REFERENCES [dbo].[Lieu] ([Id])
);

CREATE TABLE [dbo].[Chaises] (
    [Id]          VARCHAR (25)   NOT NULL,
    [zone]        VARCHAR (25)   NULL,
    [position]    NUMERIC (8, 2) NULL,
    [longueur]    NUMERIC (8, 2) NULL,
    [largeur]     NUMERIC (8, 2) NULL,
    [coordonneeX] NUMERIC (8, 2) NULL,
    [coordonneeY] NUMERIC (8, 2) NULL,
    [idevent] VARCHAR(25) NULL, 
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [Chaises_To_Zone] FOREIGN KEY ([zone]) REFERENCES [dbo].[Zone] ([Id]),
    CONSTRAINT [Chaises_To_Evenement] FOREIGN KEY ([idevent]) REFERENCES [dbo].[Evenement] ([Id])
);

CREATE TABLE [dbo].[Zone] (
    [Id]           VARCHAR (25)    NOT NULL,
    [lieu]         VARCHAR (25)    NOT NULL,
    [nom]          VARCHAR (50)    NULL,
    [coordinates]  TEXT            NULL,
    [prixunitaire] NUMERIC (15, 2) NULL,
    [estimation]   NUMERIC (15, 2) NULL,
    [remplissage] NUMERIC(15, 2) NULL, 
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Zone_ToEvenement] FOREIGN KEY ([lieu]) REFERENCES [dbo].[Evenement] ([Id])
);

CREATE TABLE [dbo].[Reservation] (
    [Id]              INT             NOT NULL,
    [lieu]            VARCHAR (25)    NULL,
    [nom]             VARCHAR (50)    NULL,
    [idevent]         VARCHAR (25)    NULL,
    [prixunitaire]    NUMERIC (15, 2) NULL,
    [datereservation] DATETIME        NULL,
    [idzone] VARCHAR(25) NULL, 
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Reservation_ToZone] FOREIGN KEY ([idzone]) REFERENCES [dbo].[Zone] ([Id]),
    CONSTRAINT [FK_Reservation_ToEvenement] FOREIGN KEY ([idevent]) REFERENCES [dbo].[Evenement] ([Id])
);

CREATE VIEW [dbo].[EtatReservation]
	AS SELECT Reservation.idevent, Reservation.lieu, etat, prixunitaire, datereservation, idzone, position FROM [Reservation], [Chaises] where Reservation.idzone = Chaises.zone;

create sequence lieusequence as int start with 1 increment by 1;
create sequence eventsequence as int start with 1 increment by 1;
create sequence zonesequence as int start with 1 increment by 1;
create sequence chaisesequence as int start with 1 increment by 1;
create sequence reservationsequence as int start with 1 increment by 1;
