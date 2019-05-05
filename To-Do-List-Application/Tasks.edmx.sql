
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/05/2019 14:59:57
-- Generated from EDMX file: C:\Users\Mark Walsh\source\repos\To-Do-List-Application3\To-Do-List-Application\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [TasksDB];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'TasksDBs'
CREATE TABLE [dbo].[TasksDBs] (
    [TaskName] nvarchar(max)  NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [DueDate] datetime  NOT NULL,
    [Category] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [TaskName] in table 'TasksDBs'
ALTER TABLE [dbo].[TasksDBs]
ADD CONSTRAINT [PK_TasksDBs]
    PRIMARY KEY CLUSTERED ([TaskName] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------