
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 02/25/2016 17:48:39
-- Generated from EDMX file: C:\Users\Dante\Documents\GitHub\WASSDiploma\WASS Diploma\Modelo_Entidades\WASSTD_Auditoria.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
CREATE DATABASE WASSTD_Auditoria
USE [WASSTD_Auditoria];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Auditorias_Log]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Auditorias_Log];
GO
IF OBJECT_ID(N'[dbo].[Auditorias_Tramites]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Auditorias_Tramites];
GO
IF OBJECT_ID(N'[dbo].[Auditoria_Detalles_Tramites]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Auditoria_Detalles_Tramites];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Auditorias_Log'
CREATE TABLE [dbo].[Auditorias_Log] (
    [id] int IDENTITY(1,1) NOT NULL,
    [usuario] nvarchar(max)  NOT NULL,
    [fecha] datetime  NOT NULL,
    [accion] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Auditorias_Tramites'
CREATE TABLE [dbo].[Auditorias_Tramites] (
    [id] int IDENTITY(1,1) NOT NULL,
    [tipoTramite] bit  NOT NULL,
    [enviadoPor] nvarchar(max)  NOT NULL,
    [dni_cuil_cliente] int  NOT NULL,
    [accion] nvarchar(max)  NOT NULL,
    [usuario] nvarchar(max)  NOT NULL,
    [id_tramite] int  NOT NULL
);
GO

-- Creating table 'Auditoria_Detalles_Tramites'
CREATE TABLE [dbo].[Auditoria_Detalles_Tramites] (
    [id] int IDENTITY(1,1) NOT NULL,
    [detalle_anterior] nvarchar(max)  NOT NULL,
    [usuario] nvarchar(max)  NOT NULL,
    [fecha_detalle_anterior] datetime  NOT NULL,
    [accion] nvarchar(max)  NOT NULL,
    [id_tramite] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [id] in table 'Auditorias_Log'
ALTER TABLE [dbo].[Auditorias_Log]
ADD CONSTRAINT [PK_Auditorias_Log]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id], [id_tramite] in table 'Auditorias_Tramites'
ALTER TABLE [dbo].[Auditorias_Tramites]
ADD CONSTRAINT [PK_Auditorias_Tramites]
    PRIMARY KEY CLUSTERED ([id], [id_tramite] ASC);
GO

-- Creating primary key on [id], [id_tramite] in table 'Auditoria_Detalles_Tramites'
ALTER TABLE [dbo].[Auditoria_Detalles_Tramites]
ADD CONSTRAINT [PK_Auditoria_Detalles_Tramites]
    PRIMARY KEY CLUSTERED ([id], [id_tramite] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------