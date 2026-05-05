-- Crearea bazei de date PecoDB
IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = 'PecoDB')
BEGIN
    CREATE DATABASE PecoDB;
END
GO

USE PecoDB;
GO

-- Tabelul StatiePeco
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'StatiePeco')
BEGIN
    CREATE TABLE StatiePeco (
        IdStatie    INT IDENTITY(1,1) PRIMARY KEY,
        Denumire    NVARCHAR(100) NOT NULL,
        Adresa      NVARCHAR(200) NOT NULL,
        Oras        NVARCHAR(100) NOT NULL,
        NrPompe     INT NOT NULL,
        Status      NVARCHAR(20) NOT NULL DEFAULT 'Activa'
    );
END
GO

-- Tabelul Combustibil
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Combustibil')
BEGIN
    CREATE TABLE Combustibil (
        IdCombustibil   INT IDENTITY(1,1) PRIMARY KEY,
        Tip             NVARCHAR(50) NOT NULL,
        PretPerLitru    DECIMAL(10,2) NOT NULL,
        StocLitri       DECIMAL(10,2) NOT NULL
    );
END
GO

-- Tabelul Tranzactie
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Tranzactie')
BEGIN
    CREATE TABLE Tranzactie (
        IdTranzactie        INT IDENTITY(1,1) PRIMARY KEY,
        IdStatie            INT NOT NULL,
        IdCombustibil       INT NOT NULL,
        DataOra             DATETIME NOT NULL DEFAULT GETDATE(),
        CantitateaLitri     DECIMAL(10,2) NOT NULL,
        SumaTotala          DECIMAL(10,2) NOT NULL,
        ModPlata            NVARCHAR(50) NOT NULL,

        CONSTRAINT FK_Tranzactie_Statie
            FOREIGN KEY (IdStatie) REFERENCES StatiePeco(IdStatie),

        CONSTRAINT FK_Tranzactie_Combustibil
            FOREIGN KEY (IdCombustibil) REFERENCES Combustibil(IdCombustibil)
    );
END
GO