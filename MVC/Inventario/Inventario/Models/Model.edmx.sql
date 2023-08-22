
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 01/22/2022 14:15:09
-- Generated from EDMX file: C:\Users\Felipe Isla\Desktop\portafolio\propios\repos\Inventario\Inventario\Models\Model.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Inventario];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_Relationship1]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[USUARIO_X_TIPO] DROP CONSTRAINT [FK_Relationship1];
GO
IF OBJECT_ID(N'[dbo].[FK_Relationship11]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AVANCE_INVENTARIO] DROP CONSTRAINT [FK_Relationship11];
GO
IF OBJECT_ID(N'[dbo].[FK_Relationship12]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AVANCE_INVENTARIO] DROP CONSTRAINT [FK_Relationship12];
GO
IF OBJECT_ID(N'[dbo].[FK_Relationship14]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AVANCE_INVENTARIO] DROP CONSTRAINT [FK_Relationship14];
GO
IF OBJECT_ID(N'[dbo].[FK_Relationship2]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[USUARIO_X_TIPO] DROP CONSTRAINT [FK_Relationship2];
GO
IF OBJECT_ID(N'[dbo].[FK_Relationship3]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[USUARIO] DROP CONSTRAINT [FK_Relationship3];
GO
IF OBJECT_ID(N'[dbo].[FK_Relationship4]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UBICACION] DROP CONSTRAINT [FK_Relationship4];
GO
IF OBJECT_ID(N'[dbo].[FK_Relationship5]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MAESTRA_INPUT] DROP CONSTRAINT [FK_Relationship5];
GO
IF OBJECT_ID(N'[dbo].[FK_Relationship6]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MODIFICAR_CAPTURA] DROP CONSTRAINT [FK_Relationship6];
GO
IF OBJECT_ID(N'[dbo].[FK_Relationship8]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MAESTRA_INPUT] DROP CONSTRAINT [FK_Relationship8];
GO
IF OBJECT_ID(N'[dbo].[FK_Relationship9]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MODIFICAR_CAPTURA] DROP CONSTRAINT [FK_Relationship9];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[AVANCE_INVENTARIO]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AVANCE_INVENTARIO];
GO
IF OBJECT_ID(N'[dbo].[ESTADO_INVENTARIO]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ESTADO_INVENTARIO];
GO
IF OBJECT_ID(N'[dbo].[ESTADO_MAESTRA]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ESTADO_MAESTRA];
GO
IF OBJECT_ID(N'[dbo].[ESTADO_PATENTE]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ESTADO_PATENTE];
GO
IF OBJECT_ID(N'[dbo].[ESTADO_USUARIO]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ESTADO_USUARIO];
GO
IF OBJECT_ID(N'[dbo].[MAESTRA_CONGELADO]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MAESTRA_CONGELADO];
GO
IF OBJECT_ID(N'[dbo].[MAESTRA_INPUT]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MAESTRA_INPUT];
GO
IF OBJECT_ID(N'[dbo].[MAESTRA_PROCESO]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MAESTRA_PROCESO];
GO
IF OBJECT_ID(N'[dbo].[MODIFICAR_CAPTURA]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MODIFICAR_CAPTURA];
GO
IF OBJECT_ID(N'[dbo].[PORCENTAJE_AVANCE]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PORCENTAJE_AVANCE];
GO
IF OBJECT_ID(N'[dbo].[sysdiagrams]', 'U') IS NOT NULL
    DROP TABLE [dbo].[sysdiagrams];
GO
IF OBJECT_ID(N'[dbo].[TIPO_BUSQUEDA]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TIPO_BUSQUEDA];
GO
IF OBJECT_ID(N'[dbo].[TIPO_UBICACION]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TIPO_UBICACION];
GO
IF OBJECT_ID(N'[dbo].[TIPO_USUARIO]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TIPO_USUARIO];
GO
IF OBJECT_ID(N'[dbo].[UBICACION]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UBICACION];
GO
IF OBJECT_ID(N'[dbo].[USUARIO]', 'U') IS NOT NULL
    DROP TABLE [dbo].[USUARIO];
GO
IF OBJECT_ID(N'[dbo].[USUARIO_X_TIPO]', 'U') IS NOT NULL
    DROP TABLE [dbo].[USUARIO_X_TIPO];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'AVANCE_INVENTARIO'
CREATE TABLE [dbo].[AVANCE_INVENTARIO] (
    [PATENTE] varchar(20)  NOT NULL,
    [ID_TIPO_PAT] int  NULL,
    [ID_BODEGA] int  NULL,
    [MOTIVO] varchar(100)  NULL,
    [TIPO_PATENTE] varchar(150)  NULL,
    [ID_PATENTE] int  NULL
);
GO

-- Creating table 'ESTADO_MAESTRA'
CREATE TABLE [dbo].[ESTADO_MAESTRA] (
    [ID_EST] int  NOT NULL,
    [DETALLE] varchar(100)  NULL
);
GO

-- Creating table 'ESTADO_PATENTE'
CREATE TABLE [dbo].[ESTADO_PATENTE] (
    [ID_TIPO_PAT] int  NOT NULL,
    [DESCRIPCION] varchar(50)  NULL
);
GO

-- Creating table 'ESTADO_USUARIO'
CREATE TABLE [dbo].[ESTADO_USUARIO] (
    [ID_ESTADO] int  NOT NULL,
    [DETALLE] varchar(100)  NULL
);
GO

-- Creating table 'MAESTRA_INPUT'
CREATE TABLE [dbo].[MAESTRA_INPUT] (
    [ID_INPUT] int  NOT NULL,
    [LOCAL] varchar(50)  NULL,
    [TIPO_INVENTARIO] varchar(50)  NULL,
    [PATENTE] int  NULL,
    [EAN] varchar(50)  NULL,
    [DESCRIPCION] varchar(100)  NULL,
    [SKU] varchar(50)  NULL,
    [CANTIDAD] varchar(50)  NULL,
    [PRECIO] decimal(38,3)  NULL,
    [UNIDAD] varchar(10)  NULL,
    [RUT] varchar(10)  NULL,
    [HORA] varchar(20)  NULL,
    [FECHA] varbinary(50)  NULL,
    [ID_EST] int  NULL,
    [ID_BODEGA] int  NULL,
    [DESCRIPCION_PAT] varchar(150)  NULL
);
GO

-- Creating table 'MODIFICAR_CAPTURA'
CREATE TABLE [dbo].[MODIFICAR_CAPTURA] (
    [ID_MOD] int  NOT NULL,
    [CONTEO1] varchar(50)  NULL,
    [CONTEO2] varchar(20)  NULL,
    [ID_EST] int  NULL,
    [ID_INPUT] int  NULL
);
GO

-- Creating table 'sysdiagrams'
CREATE TABLE [dbo].[sysdiagrams] (
    [name] nvarchar(128)  NOT NULL,
    [principal_id] int  NOT NULL,
    [diagram_id] int IDENTITY(1,1) NOT NULL,
    [version] int  NULL,
    [definition] varbinary(max)  NULL
);
GO

-- Creating table 'TIPO_UBICACION'
CREATE TABLE [dbo].[TIPO_UBICACION] (
    [ID_BODEGA] int  NOT NULL,
    [BODEGA] varchar(100)  NULL
);
GO

-- Creating table 'TIPO_USUARIO'
CREATE TABLE [dbo].[TIPO_USUARIO] (
    [ID_TIPO] int  NOT NULL,
    [DESCRIPCION] varchar(100)  NULL
);
GO

-- Creating table 'UBICACION'
CREATE TABLE [dbo].[UBICACION] (
    [ID_PATENTE] int  NOT NULL,
    [ID_PATENTE_BODEGA] int  NULL,
    [DESCRIPCION] varchar(100)  NULL,
    [RANGO_BAJO] varchar(50)  NULL,
    [RANGO_ALTO] varchar(50)  NULL,
    [TOTAL] varchar(50)  NULL,
    [ID_BODEGA] int  NULL,
    [AVANCE_CERRADO] varchar(50)  NULL,
    [AVANCE_ABIERTO] varchar(50)  NULL,
    [AVANCE_NULO] varchar(50)  NULL
);
GO

-- Creating table 'USUARIO'
CREATE TABLE [dbo].[USUARIO] (
    [ID_USUARIO] int  NOT NULL,
    [USUARIO1] varchar(50)  NULL,
    [RUT] varchar(50)  NULL,
    [ID_ESTADO] int  NULL
);
GO

-- Creating table 'ESTADO_INVENTARIO'
CREATE TABLE [dbo].[ESTADO_INVENTARIO] (
    [ID_INVENTARIO] int  NOT NULL,
    [ESTADO_INVENTARIO1] varchar(50)  NULL
);
GO

-- Creating table 'PORCENTAJE_AVANCE'
CREATE TABLE [dbo].[PORCENTAJE_AVANCE] (
    [ID_AVANCE] int  NOT NULL,
    [REGISTROS] varchar(100)  NULL,
    [EXTENDIDO] varchar(100)  NULL,
    [PORCENTAJE] varchar(100)  NULL,
    [TOTAL] varchar(100)  NULL,
    [UBICACION] varchar(150)  NULL
);
GO

-- Creating table 'TIPO_BUSQUEDA'
CREATE TABLE [dbo].[TIPO_BUSQUEDA] (
    [ID_BUSQUEDA] int  NOT NULL,
    [BUSQUEDA] varchar(50)  NULL
);
GO

-- Creating table 'MAESTRA_CONGELADO'
CREATE TABLE [dbo].[MAESTRA_CONGELADO] (
    [NUMCONTEO] varchar(50)  NULL,
    [FECHA] varchar(20)  NULL,
    [CODIGO_INTERNO] varchar(100)  NULL,
    [LOCALES] varchar(100)  NULL,
    [TIPO_INVENTARIO] varchar(100)  NULL,
    [DESCRIPCION] varchar(100)  NULL,
    [MARCA] varchar(100)  NULL,
    [UNIDAD_MEDIDA] varchar(10)  NULL,
    [PRECIO] varchar(100)  NULL,
    [MONEDA] varchar(50)  NULL,
    [SUB_CLASE] varchar(100)  NULL,
    [DESCRIPCION_SUBCLASE] varchar(100)  NULL,
    [CLASE] varchar(100)  NULL,
    [DESCRIPCION_CLASE] varchar(100)  NULL,
    [SUB_DEPARTAMENTO] varchar(100)  NULL,
    [DESCRIPCION_SUB_DPTO] varchar(100)  NULL,
    [DEPARTAMENTO] varchar(100)  NULL,
    [DESCRIPCION_DPTO] varchar(100)  NULL,
    [FECHA_CREACION_ARCHIVO] varchar(20)  NULL,
    [TIPO_CODBARRA] varchar(50)  NULL,
    [EAN] varchar(20)  NULL,
    [CANTIDAD] varchar(50)  NULL,
    [IDMCONG] int IDENTITY(1,1) NOT NULL
);
GO

-- Creating table 'MAESTRA_PROCESO'
CREATE TABLE [dbo].[MAESTRA_PROCESO] (
    [NUMCONTEO] varchar(50)  NULL,
    [FECHA] varchar(20)  NULL,
    [CODIGO_INTERNO] varchar(100)  NULL,
    [LOCALES] varchar(100)  NULL,
    [TIPO_INVENTARIO] varchar(100)  NULL,
    [DESCRIPCION] varchar(100)  NULL,
    [MARCA] varchar(100)  NULL,
    [UNIDAD_MEDIDA] varchar(10)  NULL,
    [PRECIO] varchar(100)  NULL,
    [MONEDA] varchar(50)  NULL,
    [SUB_CLASE] varchar(100)  NULL,
    [DESCRIPCION_SUBCLASE] varchar(100)  NULL,
    [CLASE] varchar(100)  NULL,
    [DESCRIPCION_CLASE] varchar(100)  NULL,
    [SUB_DEPARTAMENTO] varchar(100)  NULL,
    [DESCRIPCION_SUB_DPTO] varchar(100)  NULL,
    [DEPARTAMENTO] varchar(100)  NULL,
    [DESCRIPCION_DPTO] varchar(100)  NULL,
    [FECHA_CREACION_ARCHIVO] varchar(20)  NULL,
    [TIPO_CODBARRA] varchar(50)  NULL,
    [EAN] varchar(20)  NULL,
    [CANTIDAD] varchar(50)  NULL,
    [IDMPROC] int IDENTITY(1,1) NOT NULL
);
GO

-- Creating table 'USUARIO_X_TIPO'
CREATE TABLE [dbo].[USUARIO_X_TIPO] (
    [USUARIO_ID_USUARIO] int  NOT NULL,
    [TIPO_USUARIO_ID_TIPO] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [PATENTE] in table 'AVANCE_INVENTARIO'
ALTER TABLE [dbo].[AVANCE_INVENTARIO]
ADD CONSTRAINT [PK_AVANCE_INVENTARIO]
    PRIMARY KEY CLUSTERED ([PATENTE] ASC);
GO

-- Creating primary key on [ID_EST] in table 'ESTADO_MAESTRA'
ALTER TABLE [dbo].[ESTADO_MAESTRA]
ADD CONSTRAINT [PK_ESTADO_MAESTRA]
    PRIMARY KEY CLUSTERED ([ID_EST] ASC);
GO

-- Creating primary key on [ID_TIPO_PAT] in table 'ESTADO_PATENTE'
ALTER TABLE [dbo].[ESTADO_PATENTE]
ADD CONSTRAINT [PK_ESTADO_PATENTE]
    PRIMARY KEY CLUSTERED ([ID_TIPO_PAT] ASC);
GO

-- Creating primary key on [ID_ESTADO] in table 'ESTADO_USUARIO'
ALTER TABLE [dbo].[ESTADO_USUARIO]
ADD CONSTRAINT [PK_ESTADO_USUARIO]
    PRIMARY KEY CLUSTERED ([ID_ESTADO] ASC);
GO

-- Creating primary key on [ID_INPUT] in table 'MAESTRA_INPUT'
ALTER TABLE [dbo].[MAESTRA_INPUT]
ADD CONSTRAINT [PK_MAESTRA_INPUT]
    PRIMARY KEY CLUSTERED ([ID_INPUT] ASC);
GO

-- Creating primary key on [ID_MOD] in table 'MODIFICAR_CAPTURA'
ALTER TABLE [dbo].[MODIFICAR_CAPTURA]
ADD CONSTRAINT [PK_MODIFICAR_CAPTURA]
    PRIMARY KEY CLUSTERED ([ID_MOD] ASC);
GO

-- Creating primary key on [diagram_id] in table 'sysdiagrams'
ALTER TABLE [dbo].[sysdiagrams]
ADD CONSTRAINT [PK_sysdiagrams]
    PRIMARY KEY CLUSTERED ([diagram_id] ASC);
GO

-- Creating primary key on [ID_BODEGA] in table 'TIPO_UBICACION'
ALTER TABLE [dbo].[TIPO_UBICACION]
ADD CONSTRAINT [PK_TIPO_UBICACION]
    PRIMARY KEY CLUSTERED ([ID_BODEGA] ASC);
GO

-- Creating primary key on [ID_TIPO] in table 'TIPO_USUARIO'
ALTER TABLE [dbo].[TIPO_USUARIO]
ADD CONSTRAINT [PK_TIPO_USUARIO]
    PRIMARY KEY CLUSTERED ([ID_TIPO] ASC);
GO

-- Creating primary key on [ID_PATENTE] in table 'UBICACION'
ALTER TABLE [dbo].[UBICACION]
ADD CONSTRAINT [PK_UBICACION]
    PRIMARY KEY CLUSTERED ([ID_PATENTE] ASC);
GO

-- Creating primary key on [ID_USUARIO] in table 'USUARIO'
ALTER TABLE [dbo].[USUARIO]
ADD CONSTRAINT [PK_USUARIO]
    PRIMARY KEY CLUSTERED ([ID_USUARIO] ASC);
GO

-- Creating primary key on [ID_INVENTARIO] in table 'ESTADO_INVENTARIO'
ALTER TABLE [dbo].[ESTADO_INVENTARIO]
ADD CONSTRAINT [PK_ESTADO_INVENTARIO]
    PRIMARY KEY CLUSTERED ([ID_INVENTARIO] ASC);
GO

-- Creating primary key on [ID_AVANCE] in table 'PORCENTAJE_AVANCE'
ALTER TABLE [dbo].[PORCENTAJE_AVANCE]
ADD CONSTRAINT [PK_PORCENTAJE_AVANCE]
    PRIMARY KEY CLUSTERED ([ID_AVANCE] ASC);
GO

-- Creating primary key on [ID_BUSQUEDA] in table 'TIPO_BUSQUEDA'
ALTER TABLE [dbo].[TIPO_BUSQUEDA]
ADD CONSTRAINT [PK_TIPO_BUSQUEDA]
    PRIMARY KEY CLUSTERED ([ID_BUSQUEDA] ASC);
GO

-- Creating primary key on [IDMCONG] in table 'MAESTRA_CONGELADO'
ALTER TABLE [dbo].[MAESTRA_CONGELADO]
ADD CONSTRAINT [PK_MAESTRA_CONGELADO]
    PRIMARY KEY CLUSTERED ([IDMCONG] ASC);
GO

-- Creating primary key on [IDMPROC] in table 'MAESTRA_PROCESO'
ALTER TABLE [dbo].[MAESTRA_PROCESO]
ADD CONSTRAINT [PK_MAESTRA_PROCESO]
    PRIMARY KEY CLUSTERED ([IDMPROC] ASC);
GO

-- Creating primary key on [USUARIO_ID_USUARIO], [TIPO_USUARIO_ID_TIPO] in table 'USUARIO_X_TIPO'
ALTER TABLE [dbo].[USUARIO_X_TIPO]
ADD CONSTRAINT [PK_USUARIO_X_TIPO]
    PRIMARY KEY CLUSTERED ([USUARIO_ID_USUARIO], [TIPO_USUARIO_ID_TIPO] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [ID_TIPO_PAT] in table 'AVANCE_INVENTARIO'
ALTER TABLE [dbo].[AVANCE_INVENTARIO]
ADD CONSTRAINT [FK_Relationship11]
    FOREIGN KEY ([ID_TIPO_PAT])
    REFERENCES [dbo].[ESTADO_PATENTE]
        ([ID_TIPO_PAT])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Relationship11'
CREATE INDEX [IX_FK_Relationship11]
ON [dbo].[AVANCE_INVENTARIO]
    ([ID_TIPO_PAT]);
GO

-- Creating foreign key on [ID_BODEGA] in table 'AVANCE_INVENTARIO'
ALTER TABLE [dbo].[AVANCE_INVENTARIO]
ADD CONSTRAINT [FK_Relationship12]
    FOREIGN KEY ([ID_BODEGA])
    REFERENCES [dbo].[TIPO_UBICACION]
        ([ID_BODEGA])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Relationship12'
CREATE INDEX [IX_FK_Relationship12]
ON [dbo].[AVANCE_INVENTARIO]
    ([ID_BODEGA]);
GO

-- Creating foreign key on [ID_PATENTE] in table 'AVANCE_INVENTARIO'
ALTER TABLE [dbo].[AVANCE_INVENTARIO]
ADD CONSTRAINT [FK_Relationship14]
    FOREIGN KEY ([ID_PATENTE])
    REFERENCES [dbo].[UBICACION]
        ([ID_PATENTE])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Relationship14'
CREATE INDEX [IX_FK_Relationship14]
ON [dbo].[AVANCE_INVENTARIO]
    ([ID_PATENTE]);
GO

-- Creating foreign key on [ID_EST] in table 'MAESTRA_INPUT'
ALTER TABLE [dbo].[MAESTRA_INPUT]
ADD CONSTRAINT [FK_Relationship5]
    FOREIGN KEY ([ID_EST])
    REFERENCES [dbo].[ESTADO_MAESTRA]
        ([ID_EST])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Relationship5'
CREATE INDEX [IX_FK_Relationship5]
ON [dbo].[MAESTRA_INPUT]
    ([ID_EST]);
GO

-- Creating foreign key on [ID_EST] in table 'MODIFICAR_CAPTURA'
ALTER TABLE [dbo].[MODIFICAR_CAPTURA]
ADD CONSTRAINT [FK_Relationship6]
    FOREIGN KEY ([ID_EST])
    REFERENCES [dbo].[ESTADO_MAESTRA]
        ([ID_EST])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Relationship6'
CREATE INDEX [IX_FK_Relationship6]
ON [dbo].[MODIFICAR_CAPTURA]
    ([ID_EST]);
GO

-- Creating foreign key on [ID_ESTADO] in table 'USUARIO'
ALTER TABLE [dbo].[USUARIO]
ADD CONSTRAINT [FK_Relationship3]
    FOREIGN KEY ([ID_ESTADO])
    REFERENCES [dbo].[ESTADO_USUARIO]
        ([ID_ESTADO])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Relationship3'
CREATE INDEX [IX_FK_Relationship3]
ON [dbo].[USUARIO]
    ([ID_ESTADO]);
GO

-- Creating foreign key on [ID_BODEGA] in table 'MAESTRA_INPUT'
ALTER TABLE [dbo].[MAESTRA_INPUT]
ADD CONSTRAINT [FK_Relationship8]
    FOREIGN KEY ([ID_BODEGA])
    REFERENCES [dbo].[TIPO_UBICACION]
        ([ID_BODEGA])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Relationship8'
CREATE INDEX [IX_FK_Relationship8]
ON [dbo].[MAESTRA_INPUT]
    ([ID_BODEGA]);
GO

-- Creating foreign key on [ID_INPUT] in table 'MODIFICAR_CAPTURA'
ALTER TABLE [dbo].[MODIFICAR_CAPTURA]
ADD CONSTRAINT [FK_Relationship9]
    FOREIGN KEY ([ID_INPUT])
    REFERENCES [dbo].[MAESTRA_INPUT]
        ([ID_INPUT])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Relationship9'
CREATE INDEX [IX_FK_Relationship9]
ON [dbo].[MODIFICAR_CAPTURA]
    ([ID_INPUT]);
GO

-- Creating foreign key on [ID_BODEGA] in table 'UBICACION'
ALTER TABLE [dbo].[UBICACION]
ADD CONSTRAINT [FK_Relationship4]
    FOREIGN KEY ([ID_BODEGA])
    REFERENCES [dbo].[TIPO_UBICACION]
        ([ID_BODEGA])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Relationship4'
CREATE INDEX [IX_FK_Relationship4]
ON [dbo].[UBICACION]
    ([ID_BODEGA]);
GO

-- Creating foreign key on [USUARIO_ID_USUARIO] in table 'USUARIO_X_TIPO'
ALTER TABLE [dbo].[USUARIO_X_TIPO]
ADD CONSTRAINT [FK_USUARIO_X_TIPO_USUARIO]
    FOREIGN KEY ([USUARIO_ID_USUARIO])
    REFERENCES [dbo].[USUARIO]
        ([ID_USUARIO])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [TIPO_USUARIO_ID_TIPO] in table 'USUARIO_X_TIPO'
ALTER TABLE [dbo].[USUARIO_X_TIPO]
ADD CONSTRAINT [FK_USUARIO_X_TIPO_TIPO_USUARIO]
    FOREIGN KEY ([TIPO_USUARIO_ID_TIPO])
    REFERENCES [dbo].[TIPO_USUARIO]
        ([ID_TIPO])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_USUARIO_X_TIPO_TIPO_USUARIO'
CREATE INDEX [IX_FK_USUARIO_X_TIPO_TIPO_USUARIO]
ON [dbo].[USUARIO_X_TIPO]
    ([TIPO_USUARIO_ID_TIPO]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------