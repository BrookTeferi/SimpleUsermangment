
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/26/2022 00:28:46
-- Generated from EDMX file: C:\Users\omen\source\repos\SimpleUserManagmentSystem\SimpleUserManagmentSystem\Models\myusermodel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [user];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[USERS]', 'U') IS NOT NULL
    DROP TABLE [dbo].[USERS];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'USERS'
CREATE TABLE [dbo].[USERS] (
    [id] int IDENTITY(1,1) NOT NULL,
    [firstname] varchar(50)  NULL,
    [lastname] varchar(50)  NULL,
    [emailid] varchar(50)  NULL,
    [address] varchar(50)  NULL,
    [dateofbirth] datetime  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [id] in table 'USERS'
ALTER TABLE [dbo].[USERS]
ADD CONSTRAINT [PK_USERS]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------