
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 11/24/2015 04:01:50
-- Generated from EDMX file: C:\Users\Dante\Documents\GitHub\WASSDiploma\WASS Diploma\Modelo_Entidades\WASSTD.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
CREATE DATABASE WASSTD
USE [WASSTD];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_UsuarioGrupo_Usuario]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UsuariosGrupos] DROP CONSTRAINT [FK_UsuarioGrupo_Usuario];
GO
IF OBJECT_ID(N'[dbo].[FK_UsuarioGrupo_Grupo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UsuariosGrupos] DROP CONSTRAINT [FK_UsuarioGrupo_Grupo];
GO
IF OBJECT_ID(N'[dbo].[FK_PerfilGrupo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Perfiles] DROP CONSTRAINT [FK_PerfilGrupo];
GO
IF OBJECT_ID(N'[dbo].[FK_PerfilPermiso]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Perfiles] DROP CONSTRAINT [FK_PerfilPermiso];
GO
IF OBJECT_ID(N'[dbo].[FK_PerfilFormulario]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Perfiles] DROP CONSTRAINT [FK_PerfilFormulario];
GO
IF OBJECT_ID(N'[dbo].[FK_FormularioModulo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Formularios] DROP CONSTRAINT [FK_FormularioModulo];
GO
IF OBJECT_ID(N'[dbo].[FK_CtaCtePersona]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CtasCtes] DROP CONSTRAINT [FK_CtaCtePersona];
GO
IF OBJECT_ID(N'[dbo].[FK_MovimientoCtaCte]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Movimientos] DROP CONSTRAINT [FK_MovimientoCtaCte];
GO
IF OBJECT_ID(N'[dbo].[FK_Tipo_MovimientoMovimiento]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Movimientos] DROP CONSTRAINT [FK_Tipo_MovimientoMovimiento];
GO
IF OBJECT_ID(N'[dbo].[FK_ComprobanteMovimiento]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Movimientos] DROP CONSTRAINT [FK_ComprobanteMovimiento];
GO
IF OBJECT_ID(N'[dbo].[FK_ProvinciaLocalidades]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Localidades] DROP CONSTRAINT [FK_ProvinciaLocalidades];
GO
IF OBJECT_ID(N'[dbo].[FK_PersonaDirecciones]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Direcciones] DROP CONSTRAINT [FK_PersonaDirecciones];
GO
IF OBJECT_ID(N'[dbo].[FK_Tipo_DocumentoPersona]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Personas] DROP CONSTRAINT [FK_Tipo_DocumentoPersona];
GO
IF OBJECT_ID(N'[dbo].[FK_EstadoPersona]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Personas] DROP CONSTRAINT [FK_EstadoPersona];
GO
IF OBJECT_ID(N'[dbo].[FK_LocalidadDireccion]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Direcciones] DROP CONSTRAINT [FK_LocalidadDireccion];
GO
IF OBJECT_ID(N'[dbo].[FK_Factura_inherits_Comprobante]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Comprobantes_Factura] DROP CONSTRAINT [FK_Factura_inherits_Comprobante];
GO
IF OBJECT_ID(N'[dbo].[FK_Boleta_inherits_Comprobante]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Comprobantes_Boleta] DROP CONSTRAINT [FK_Boleta_inherits_Comprobante];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Usuarios]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Usuarios];
GO
IF OBJECT_ID(N'[dbo].[Grupos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Grupos];
GO
IF OBJECT_ID(N'[dbo].[Perfiles]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Perfiles];
GO
IF OBJECT_ID(N'[dbo].[Permisos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Permisos];
GO
IF OBJECT_ID(N'[dbo].[Formularios]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Formularios];
GO
IF OBJECT_ID(N'[dbo].[Modulos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Modulos];
GO
IF OBJECT_ID(N'[dbo].[Personas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Personas];
GO
IF OBJECT_ID(N'[dbo].[CtasCtes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CtasCtes];
GO
IF OBJECT_ID(N'[dbo].[Movimientos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Movimientos];
GO
IF OBJECT_ID(N'[dbo].[Tipos_Movimientos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Tipos_Movimientos];
GO
IF OBJECT_ID(N'[dbo].[Comprobantes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Comprobantes];
GO
IF OBJECT_ID(N'[dbo].[Localidades]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Localidades];
GO
IF OBJECT_ID(N'[dbo].[Provincias]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Provincias];
GO
IF OBJECT_ID(N'[dbo].[Estados]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Estados];
GO
IF OBJECT_ID(N'[dbo].[Direcciones]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Direcciones];
GO
IF OBJECT_ID(N'[dbo].[Tipos_Documentos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Tipos_Documentos];
GO
IF OBJECT_ID(N'[dbo].[Alteradores]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Alteradores];
GO
IF OBJECT_ID(N'[dbo].[Comprobantes_Factura]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Comprobantes_Factura];
GO
IF OBJECT_ID(N'[dbo].[Comprobantes_Boleta]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Comprobantes_Boleta];
GO
IF OBJECT_ID(N'[dbo].[UsuariosGrupos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UsuariosGrupos];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Usuarios'
CREATE TABLE [dbo].[Usuarios] (
    [id] int IDENTITY(1,1) NOT NULL,
    [nombre_apellido] nvarchar(max)  NOT NULL,
    [clave] nvarchar(max)  NOT NULL,
    [email] nvarchar(max)  NOT NULL,
    [estado] bit  NOT NULL,
    [usuario] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Grupos'
CREATE TABLE [dbo].[Grupos] (
    [id] int IDENTITY(1,1) NOT NULL,
    [descripcion] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Perfiles'
CREATE TABLE [dbo].[Perfiles] (
    [id] int IDENTITY(1,1) NOT NULL,
    [Grupo_id] int  NOT NULL,
    [Permiso_id] int  NOT NULL,
    [Formulario_id] int  NOT NULL
);
GO

-- Creating table 'Permisos'
CREATE TABLE [dbo].[Permisos] (
    [id] int IDENTITY(1,1) NOT NULL,
    [descripcion] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Formularios'
CREATE TABLE [dbo].[Formularios] (
    [id] int IDENTITY(1,1) NOT NULL,
    [descripcion] nvarchar(max)  NOT NULL,
    [nombredemuestra] nvarchar(max)  NOT NULL,
    [Modulo_id] int  NOT NULL
);
GO

-- Creating table 'Modulos'
CREATE TABLE [dbo].[Modulos] (
    [id] int IDENTITY(1,1) NOT NULL,
    [descripcion] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Personas'
CREATE TABLE [dbo].[Personas] (
    [dni] int  NOT NULL,
    [nombre_apellido] nvarchar(max)  NOT NULL,
    [fecha_nacimiento] datetime  NOT NULL,
    [sexo] nvarchar(max)  NOT NULL,
    [telefono] int  NOT NULL,
    [celular] int  NOT NULL,
    [email1] nvarchar(max)  NOT NULL,
    [observaciones] nvarchar(max)  NOT NULL,
    [lugar_trabajo] nvarchar(max)  NULL,
    [clave_fiscal] nvarchar(max)  NULL,
    [Tipo_Documento_id] int  NOT NULL,
    [Estado_id] int  NOT NULL
);
GO

-- Creating table 'CtasCtes'
CREATE TABLE [dbo].[CtasCtes] (
    [id] int IDENTITY(1,1) NOT NULL,
    [saldo] decimal(18,0)  NOT NULL,
    [CtaCtePersona_CtaCte_dni] int  NOT NULL
);
GO

-- Creating table 'Movimientos'
CREATE TABLE [dbo].[Movimientos] (
    [id] int IDENTITY(1,1) NOT NULL,
    [descripcion] nvarchar(max)  NOT NULL,
    [importe] float  NOT NULL,
    [fecha] datetime  NOT NULL,
    [CtaCte_id] int  NOT NULL,
    [Tipo_Movimiento_id] int  NOT NULL,
    [Comprobante_id] int  NOT NULL
);
GO

-- Creating table 'Tipos_Movimientos'
CREATE TABLE [dbo].[Tipos_Movimientos] (
    [id] int IDENTITY(1,1) NOT NULL,
    [descripcion] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Comprobantes'
CREATE TABLE [dbo].[Comprobantes] (
    [id] int IDENTITY(1,1) NOT NULL
);
GO

-- Creating table 'Localidades'
CREATE TABLE [dbo].[Localidades] (
    [id] int IDENTITY(1,1) NOT NULL,
    [nombre] nvarchar(max)  NOT NULL,
    [cp] int  NOT NULL,
    [Provincia_id] int  NOT NULL
);
GO

-- Creating table 'Provincias'
CREATE TABLE [dbo].[Provincias] (
    [id] int IDENTITY(1,1) NOT NULL,
    [nombre] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Estados'
CREATE TABLE [dbo].[Estados] (
    [id] int IDENTITY(1,1) NOT NULL,
    [descripcion] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Direcciones'
CREATE TABLE [dbo].[Direcciones] (
    [id] int IDENTITY(1,1) NOT NULL,
    [direccion] nvarchar(max)  NOT NULL,
    [Persona_dni] int  NOT NULL,
    [Localidad_id] int  NOT NULL
);
GO

-- Creating table 'Tipos_Documentos'
CREATE TABLE [dbo].[Tipos_Documentos] (
    [id] int IDENTITY(1,1) NOT NULL,
    [descripcion] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Alteradores'
CREATE TABLE [dbo].[Alteradores] (
    [porcentaje_recargo] float  NOT NULL,
    [dias_gracias] int  NOT NULL,
    [valor_cuota] float  NOT NULL,
    [id] int IDENTITY(1,1) NOT NULL
);
GO

-- Creating table 'Comprobantes_Factura'
CREATE TABLE [dbo].[Comprobantes_Factura] (
    [numero] int IDENTITY(1,1) NOT NULL,
    [cantidad] int  NOT NULL,
    [descripcion] nvarchar(max)  NOT NULL,
    [precio_unitario] decimal(18,0)  NOT NULL,
    [importe] decimal(18,0)  NOT NULL,
    [total] decimal(18,0)  NOT NULL,
    [id] int  NOT NULL
);
GO

-- Creating table 'Comprobantes_Boleta'
CREATE TABLE [dbo].[Comprobantes_Boleta] (
    [numero] int IDENTITY(1,1) NOT NULL,
    [id] int  NOT NULL
);
GO

-- Creating table 'UsuariosGrupos'
CREATE TABLE [dbo].[UsuariosGrupos] (
    [Usuarios_id] int  NOT NULL,
    [Grupos_id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [id] in table 'Usuarios'
ALTER TABLE [dbo].[Usuarios]
ADD CONSTRAINT [PK_Usuarios]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'Grupos'
ALTER TABLE [dbo].[Grupos]
ADD CONSTRAINT [PK_Grupos]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'Perfiles'
ALTER TABLE [dbo].[Perfiles]
ADD CONSTRAINT [PK_Perfiles]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'Permisos'
ALTER TABLE [dbo].[Permisos]
ADD CONSTRAINT [PK_Permisos]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'Formularios'
ALTER TABLE [dbo].[Formularios]
ADD CONSTRAINT [PK_Formularios]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'Modulos'
ALTER TABLE [dbo].[Modulos]
ADD CONSTRAINT [PK_Modulos]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [dni] in table 'Personas'
ALTER TABLE [dbo].[Personas]
ADD CONSTRAINT [PK_Personas]
    PRIMARY KEY CLUSTERED ([dni] ASC);
GO

-- Creating primary key on [id] in table 'CtasCtes'
ALTER TABLE [dbo].[CtasCtes]
ADD CONSTRAINT [PK_CtasCtes]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'Movimientos'
ALTER TABLE [dbo].[Movimientos]
ADD CONSTRAINT [PK_Movimientos]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'Tipos_Movimientos'
ALTER TABLE [dbo].[Tipos_Movimientos]
ADD CONSTRAINT [PK_Tipos_Movimientos]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'Comprobantes'
ALTER TABLE [dbo].[Comprobantes]
ADD CONSTRAINT [PK_Comprobantes]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'Localidades'
ALTER TABLE [dbo].[Localidades]
ADD CONSTRAINT [PK_Localidades]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'Provincias'
ALTER TABLE [dbo].[Provincias]
ADD CONSTRAINT [PK_Provincias]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'Estados'
ALTER TABLE [dbo].[Estados]
ADD CONSTRAINT [PK_Estados]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'Direcciones'
ALTER TABLE [dbo].[Direcciones]
ADD CONSTRAINT [PK_Direcciones]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'Tipos_Documentos'
ALTER TABLE [dbo].[Tipos_Documentos]
ADD CONSTRAINT [PK_Tipos_Documentos]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'Alteradores'
ALTER TABLE [dbo].[Alteradores]
ADD CONSTRAINT [PK_Alteradores]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'Comprobantes_Factura'
ALTER TABLE [dbo].[Comprobantes_Factura]
ADD CONSTRAINT [PK_Comprobantes_Factura]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'Comprobantes_Boleta'
ALTER TABLE [dbo].[Comprobantes_Boleta]
ADD CONSTRAINT [PK_Comprobantes_Boleta]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [Usuarios_id], [Grupos_id] in table 'UsuariosGrupos'
ALTER TABLE [dbo].[UsuariosGrupos]
ADD CONSTRAINT [PK_UsuariosGrupos]
    PRIMARY KEY CLUSTERED ([Usuarios_id], [Grupos_id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Usuarios_id] in table 'UsuariosGrupos'
ALTER TABLE [dbo].[UsuariosGrupos]
ADD CONSTRAINT [FK_UsuarioGrupo_Usuario]
    FOREIGN KEY ([Usuarios_id])
    REFERENCES [dbo].[Usuarios]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Grupos_id] in table 'UsuariosGrupos'
ALTER TABLE [dbo].[UsuariosGrupos]
ADD CONSTRAINT [FK_UsuarioGrupo_Grupo]
    FOREIGN KEY ([Grupos_id])
    REFERENCES [dbo].[Grupos]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_UsuarioGrupo_Grupo'
CREATE INDEX [IX_FK_UsuarioGrupo_Grupo]
ON [dbo].[UsuariosGrupos]
    ([Grupos_id]);
GO

-- Creating foreign key on [Grupo_id] in table 'Perfiles'
ALTER TABLE [dbo].[Perfiles]
ADD CONSTRAINT [FK_PerfilGrupo]
    FOREIGN KEY ([Grupo_id])
    REFERENCES [dbo].[Grupos]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_PerfilGrupo'
CREATE INDEX [IX_FK_PerfilGrupo]
ON [dbo].[Perfiles]
    ([Grupo_id]);
GO

-- Creating foreign key on [Permiso_id] in table 'Perfiles'
ALTER TABLE [dbo].[Perfiles]
ADD CONSTRAINT [FK_PerfilPermiso]
    FOREIGN KEY ([Permiso_id])
    REFERENCES [dbo].[Permisos]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_PerfilPermiso'
CREATE INDEX [IX_FK_PerfilPermiso]
ON [dbo].[Perfiles]
    ([Permiso_id]);
GO

-- Creating foreign key on [Formulario_id] in table 'Perfiles'
ALTER TABLE [dbo].[Perfiles]
ADD CONSTRAINT [FK_PerfilFormulario]
    FOREIGN KEY ([Formulario_id])
    REFERENCES [dbo].[Formularios]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_PerfilFormulario'
CREATE INDEX [IX_FK_PerfilFormulario]
ON [dbo].[Perfiles]
    ([Formulario_id]);
GO

-- Creating foreign key on [Modulo_id] in table 'Formularios'
ALTER TABLE [dbo].[Formularios]
ADD CONSTRAINT [FK_FormularioModulo]
    FOREIGN KEY ([Modulo_id])
    REFERENCES [dbo].[Modulos]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_FormularioModulo'
CREATE INDEX [IX_FK_FormularioModulo]
ON [dbo].[Formularios]
    ([Modulo_id]);
GO

-- Creating foreign key on [CtaCtePersona_CtaCte_dni] in table 'CtasCtes'
ALTER TABLE [dbo].[CtasCtes]
ADD CONSTRAINT [FK_CtaCtePersona]
    FOREIGN KEY ([CtaCtePersona_CtaCte_dni])
    REFERENCES [dbo].[Personas]
        ([dni])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_CtaCtePersona'
CREATE INDEX [IX_FK_CtaCtePersona]
ON [dbo].[CtasCtes]
    ([CtaCtePersona_CtaCte_dni]);
GO

-- Creating foreign key on [CtaCte_id] in table 'Movimientos'
ALTER TABLE [dbo].[Movimientos]
ADD CONSTRAINT [FK_MovimientoCtaCte]
    FOREIGN KEY ([CtaCte_id])
    REFERENCES [dbo].[CtasCtes]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_MovimientoCtaCte'
CREATE INDEX [IX_FK_MovimientoCtaCte]
ON [dbo].[Movimientos]
    ([CtaCte_id]);
GO

-- Creating foreign key on [Tipo_Movimiento_id] in table 'Movimientos'
ALTER TABLE [dbo].[Movimientos]
ADD CONSTRAINT [FK_Tipo_MovimientoMovimiento]
    FOREIGN KEY ([Tipo_Movimiento_id])
    REFERENCES [dbo].[Tipos_Movimientos]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_Tipo_MovimientoMovimiento'
CREATE INDEX [IX_FK_Tipo_MovimientoMovimiento]
ON [dbo].[Movimientos]
    ([Tipo_Movimiento_id]);
GO

-- Creating foreign key on [Comprobante_id] in table 'Movimientos'
ALTER TABLE [dbo].[Movimientos]
ADD CONSTRAINT [FK_ComprobanteMovimiento]
    FOREIGN KEY ([Comprobante_id])
    REFERENCES [dbo].[Comprobantes]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ComprobanteMovimiento'
CREATE INDEX [IX_FK_ComprobanteMovimiento]
ON [dbo].[Movimientos]
    ([Comprobante_id]);
GO

-- Creating foreign key on [Provincia_id] in table 'Localidades'
ALTER TABLE [dbo].[Localidades]
ADD CONSTRAINT [FK_ProvinciaLocalidades]
    FOREIGN KEY ([Provincia_id])
    REFERENCES [dbo].[Provincias]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ProvinciaLocalidades'
CREATE INDEX [IX_FK_ProvinciaLocalidades]
ON [dbo].[Localidades]
    ([Provincia_id]);
GO

-- Creating foreign key on [Persona_dni] in table 'Direcciones'
ALTER TABLE [dbo].[Direcciones]
ADD CONSTRAINT [FK_PersonaDirecciones]
    FOREIGN KEY ([Persona_dni])
    REFERENCES [dbo].[Personas]
        ([dni])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_PersonaDirecciones'
CREATE INDEX [IX_FK_PersonaDirecciones]
ON [dbo].[Direcciones]
    ([Persona_dni]);
GO

-- Creating foreign key on [Tipo_Documento_id] in table 'Personas'
ALTER TABLE [dbo].[Personas]
ADD CONSTRAINT [FK_Tipo_DocumentoPersona]
    FOREIGN KEY ([Tipo_Documento_id])
    REFERENCES [dbo].[Tipos_Documentos]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_Tipo_DocumentoPersona'
CREATE INDEX [IX_FK_Tipo_DocumentoPersona]
ON [dbo].[Personas]
    ([Tipo_Documento_id]);
GO

-- Creating foreign key on [Estado_id] in table 'Personas'
ALTER TABLE [dbo].[Personas]
ADD CONSTRAINT [FK_EstadoPersona]
    FOREIGN KEY ([Estado_id])
    REFERENCES [dbo].[Estados]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_EstadoPersona'
CREATE INDEX [IX_FK_EstadoPersona]
ON [dbo].[Personas]
    ([Estado_id]);
GO

-- Creating foreign key on [Localidad_id] in table 'Direcciones'
ALTER TABLE [dbo].[Direcciones]
ADD CONSTRAINT [FK_LocalidadDireccion]
    FOREIGN KEY ([Localidad_id])
    REFERENCES [dbo].[Localidades]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_LocalidadDireccion'
CREATE INDEX [IX_FK_LocalidadDireccion]
ON [dbo].[Direcciones]
    ([Localidad_id]);
GO

-- Creating foreign key on [id] in table 'Comprobantes_Factura'
ALTER TABLE [dbo].[Comprobantes_Factura]
ADD CONSTRAINT [FK_Factura_inherits_Comprobante]
    FOREIGN KEY ([id])
    REFERENCES [dbo].[Comprobantes]
        ([id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [id] in table 'Comprobantes_Boleta'
ALTER TABLE [dbo].[Comprobantes_Boleta]
ADD CONSTRAINT [FK_Boleta_inherits_Comprobante]
    FOREIGN KEY ([id])
    REFERENCES [dbo].[Comprobantes]
        ([id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------