
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 04/27/2022 19:50:28
-- Generated from EDMX file: C:\Users\ivan\source\repos\Метод парных и последовательных сравнений на примере стр.орг\DatabaseEntities\EntityModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Course_database];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_VehicleRate]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[RateSet] DROP CONSTRAINT [FK_VehicleRate];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[SubcontractorSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SubcontractorSet];
GO
IF OBJECT_ID(N'[dbo].[RateSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[RateSet];
GO
IF OBJECT_ID(N'[dbo].[AdminSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AdminSet];
GO
IF OBJECT_ID(N'[dbo].[ClientSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ClientSet];
GO
IF OBJECT_ID(N'[dbo].[ExpertSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ExpertSet];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'SubcontractorSet'
CREATE TABLE [dbo].[SubcontractorSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [TotalRate] float  NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [AmountOfEmployees] int  NOT NULL,
    [UNP] int  NOT NULL,
    [BinaryPhoto] varbinary(max)  NOT NULL
);
GO

-- Creating table 'RateSet'
CREATE TABLE [dbo].[RateSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Value] float  NOT NULL,
    [TimeOfCommit] datetime  NOT NULL,
    [Subcontractor_Id] int  NOT NULL
);
GO

-- Creating table 'AdminSet'
CREATE TABLE [dbo].[AdminSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Login] nvarchar(max)  NOT NULL,
    [Password] nvarchar(max)  NOT NULL,
    [UserStatus] int  NOT NULL,
    [BinaryPhoto] varbinary(max)  NOT NULL,
    [LastOnline] datetime  NOT NULL
);
GO

-- Creating table 'ClientSet'
CREATE TABLE [dbo].[ClientSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Login] nvarchar(max)  NOT NULL,
    [Password] nvarchar(max)  NOT NULL,
    [UserStatus] int  NOT NULL,
    [BinaryPhoto] varbinary(max)  NOT NULL,
    [LastOnline] datetime  NOT NULL
);
GO

-- Creating table 'ExpertSet'
CREATE TABLE [dbo].[ExpertSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Password] nvarchar(max)  NOT NULL,
    [Login] nvarchar(max)  NOT NULL,
    [UserStatus] int  NOT NULL,
    [BinaryPhoto] varbinary(max)  NOT NULL,
    [LastOnline] datetime  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'SubcontractorSet'
ALTER TABLE [dbo].[SubcontractorSet]
ADD CONSTRAINT [PK_SubcontractorSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'RateSet'
ALTER TABLE [dbo].[RateSet]
ADD CONSTRAINT [PK_RateSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'AdminSet'
ALTER TABLE [dbo].[AdminSet]
ADD CONSTRAINT [PK_AdminSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ClientSet'
ALTER TABLE [dbo].[ClientSet]
ADD CONSTRAINT [PK_ClientSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ExpertSet'
ALTER TABLE [dbo].[ExpertSet]
ADD CONSTRAINT [PK_ExpertSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Subcontractor_Id] in table 'RateSet'
ALTER TABLE [dbo].[RateSet]
ADD CONSTRAINT [FK_VehicleRate]
    FOREIGN KEY ([Subcontractor_Id])
    REFERENCES [dbo].[SubcontractorSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_VehicleRate'
CREATE INDEX [IX_FK_VehicleRate]
ON [dbo].[RateSet]
    ([Subcontractor_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------