--Codigos SQL--
--Creacion de tabla SQL-Server

DROP TABLE [dbo].[Persona];

DROP TABLE [dbo].[Administrador];

DROP TABLE [dbo].[Jugador];

DROP TABLE [dbo].[Arbitro];

DROP TABLE [dbo].[Campeonato];

DROP TABLE [dbo].[Acta];

DROP TABLE [dbo].[Fecha];

DROP TABLE [dbo].[Equipo];

DROP TABLE [dbo].[Marcador];

DROP TABLE [dbo].[Partido];

CREATE TABLE [dbo].[Persona] (
    [id_persona] INT NOT NULL PRIMARY KEY IDENTITY,
    [nombres] VARCHAR (100) NULL,
    [apellidos] VARCHAR (100) NULL,
    [cedula] VARCHAR (100) NULL,
    [fechanacimiento] DATETIME NULL,
    [telefono] VARCHAR (100) NULL,
    [nacionalidad] VARCHAR (100) NULL,
    [foto] IMAGE NULL 
);

CREATE TABLE [dbo].[Administrador] (
    [id_persona] INT NOT NULL PRIMARY KEY IDENTITY,
    [nombres] VARCHAR (100) NULL,
    [apellidos] VARCHAR (100) NULL,
    [cedula] VARCHAR (100) NULL,
    [fechanacimiento] DATETIME NULL,
    [telefono] VARCHAR (100) NULL,
    [nacionalidad] VARCHAR (100) NULL,
    [foto] IMAGE NULL,
    [usuario] VARCHAR (100) NULL,
    [psw] VARCHAR (100) NULL,
    [puesto] VARCHAR (100) NULL 
);

CREATE TABLE [dbo].[Jugador] (
    [id_persona] INT NOT NULL PRIMARY KEY IDENTITY,
    [nombres] VARCHAR (100) NULL,
    [apellidos] VARCHAR (100) NULL,
    [cedula] VARCHAR (100) NULL,
    [fechanacimiento] DATETIME NULL,
    [telefono] VARCHAR (100) NULL,
    [nacionalidad] VARCHAR (100) NULL,
    [foto] IMAGE NULL,
    [numero] INT NULL 
);

CREATE TABLE [dbo].[Arbitro] (
    [id_persona] INT NOT NULL PRIMARY KEY IDENTITY,
    [usuario] VARCHAR (100) NULL,
    [psw] VARCHAR (100) NULL,
    [puesto] VARCHAR (100) NULL,
    [nombres] VARCHAR (100) NULL,
    [apellidos] VARCHAR (100) NULL,
    [cedula] VARCHAR (100) NULL,
    [fechanacimiento] DATETIME NULL,
    [telefono] VARCHAR (100) NULL,
    [nacionalidad] VARCHAR (100) NULL,
    [foto] IMAGE NULL,
    [licencia] VARCHAR (100) NULL 
);

CREATE TABLE [dbo].[Campeonato] (
    [id_campeonato] INT NOT NULL PRIMARY KEY IDENTITY,
    [nombre_campeonado] VARCHAR (100) NULL,
    [fechas] INT NULL 
);
CREATE TABLE [dbo].[Campeonato_u_fechas] (
    [id_campeonato] INT,
    [id_fecha] INT
);


CREATE TABLE [dbo].[Acta] (
    [id_acta] INT NOT NULL PRIMARY KEY IDENTITY,
    [nombre] VARCHAR (100) NULL,
    [fecha] INT NULL,
    [partido] INT NULL,
    [marcador_acta] INT NULL,
    [equipoa_acta] INT NULL,
    [equipob_acta] INT NULL 
);

CREATE TABLE [dbo].[Fecha] (
    [id_fecha] INT NOT NULL PRIMARY KEY IDENTITY,
    [id_campeonato] INT NULL,
    [nombre] VARCHAR (100) NULL,
    [numero_fecha] INT NULL,
    [fechainicio] DATETIME NULL,
    [fechafin] DATETIME NULL 
);

CREATE TABLE [dbo].[Equipo] (
    [id_equipo] INT NOT NULL PRIMARY KEY IDENTITY,
    [nombre] VARCHAR (100) NULL,
    [jugadores] INT NULL 
);

CREATE TABLE [dbo].[Marcador] (
    [id_marcador] INT NOT NULL PRIMARY KEY IDENTITY,
    [goleaequipoa] SMALLINT NULL,
    [golesequipob] SMALLINT NULL 
);

CREATE TABLE [dbo].[Partido] (
    [id_partido] INT NOT NULL PRIMARY KEY IDENTITY,
    [id_fecha] INT NULL,
    [equipo_a] INT NULL,
    [equipo_b] INT NULL,
    [marcador_partido] INT NULL,
    [arbitroprincipal] INT NULL 
);









ALTER TABLE Campeonato ADD CONSTRAINT [FK_Campeonato_fechas] FOREIGN KEY ([fechas]) REFERENCES [fecha]([id_fecha]);
ALTER TABLE Campeonato_u_fechas ADD CONSTRAINT [FK_Campeonato_u_fechas_id_campeonato] FOREIGN KEY ([id_campeonato]) REFERENCES [campeonato]([id_campeonato])
ALTER TABLE Campeonato_u_fechas ADD CONSTRAINT [FK_Campeonato_u_fechas_id_fecha] FOREIGN KEY ([id_fecha]) REFERENCES [fecha]([id_fecha])


ALTER TABLE Acta ADD CONSTRAINT [FK_Acta_fecha] FOREIGN KEY ([fecha]) REFERENCES [fecha]([id_fecha]);
ALTER TABLE Acta ADD CONSTRAINT [FK_Acta_partido] FOREIGN KEY ([partido]) REFERENCES [partido]([id_partido]);
ALTER TABLE Acta ADD CONSTRAINT [FK_Acta_marcador_acta] FOREIGN KEY ([marcador_acta]) REFERENCES [marcador]([id_marcador]);
ALTER TABLE Acta ADD CONSTRAINT [FK_Acta_equipoa_acta] FOREIGN KEY ([equipoa_acta]) REFERENCES [equipo]([id_equipo]);
ALTER TABLE Acta ADD CONSTRAINT [FK_Acta_equipob_acta] FOREIGN KEY ([equipob_acta]) REFERENCES [equipo]([id_equipo]);



ALTER TABLE Equipo ADD CONSTRAINT [FK_Equipo_jugadores] FOREIGN KEY ([jugadores]) REFERENCES [jugador]([id_persona]);



ALTER TABLE Partido ADD CONSTRAINT [FK_Partido_equipo_a] FOREIGN KEY ([equipo_a]) REFERENCES [equipo]([id_equipo]);
ALTER TABLE Partido ADD CONSTRAINT [FK_Partido_equipo_b] FOREIGN KEY ([equipo_b]) REFERENCES [equipo]([id_equipo]);
ALTER TABLE Partido ADD CONSTRAINT [FK_Partido_marcador_partido] FOREIGN KEY ([marcador_partido]) REFERENCES [marcador]([id_marcador]);
ALTER TABLE Partido ADD CONSTRAINT [FK_Partido_arbitroprincipal] FOREIGN KEY ([arbitroprincipal]) REFERENCES [arbitro]([id_persona]);

/*
INSERT INTO [dbo].[Persona] ([nombres],[apellidos],[cedula],[fechanacimiento],[telefono],[nacionalidad],[foto]) VALUES ('','','','','','','');

INSERT INTO [dbo].[Administrador] ([nombres],[apellidos],[cedula],[fechanacimiento],[telefono],[nacionalidad],[foto],[usuario],[psw],[puesto]) VALUES ('','','','','','','','','','');

INSERT INTO [dbo].[Jugador] ([nombres],[apellidos],[cedula],[fechanacimiento],[telefono],[nacionalidad],[foto],[numero]) VALUES ('','','','','','','','');

INSERT INTO [dbo].[Arbitro] ([usuario],[psw],[puesto],[nombres],[apellidos],[cedula],[fechanacimiento],[telefono],[nacionalidad],[foto],[licencia]) VALUES ('','','','','','','','','','','');

INSERT INTO [dbo].[Campeonato] ([nombre_campeonado]) VALUES ('');

INSERT INTO [dbo].[Acta] ([nombre]) VALUES ('');

INSERT INTO [dbo].[Fecha] ([id_campeonato],[nombre],[numero_fecha],[fechainicio],[fechafin]) VALUES ('','','','','');
*/
INSERT INTO [dbo].[Equipo] ([nombre]) VALUES ('null');
select * from equipo;
/*
INSERT INTO [dbo].[Marcador] ([goleaequipoa],[golesequipob]) VALUES ('','');

INSERT INTO [dbo].[Partido] ([id_fecha]) VALUES ('');
*/
