
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 08/13/2019 15:48:41
-- Generated from EDMX file: F:\c#代码\c#进阶学习\5、Asp.Net学习\5、MVC之EF\MVC之EF的解决方案\_07ModelFirst2\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [ModelFirst2];
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

-- Creating table 'Custom'
CREATE TABLE [dbo].[Custom] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(20)  NOT NULL,
    [Phone] nvarchar(11)  NULL
);
GO

-- Creating table 'Good'
CREATE TABLE [dbo].[Good] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(20)  NOT NULL,
    [CustomId] int  NOT NULL
);
GO

-- Creating table 'Product'
CREATE TABLE [dbo].[Product] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'GoodProduct'
CREATE TABLE [dbo].[GoodProduct] (
    [Good_Id] int  NOT NULL,
    [Product_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Custom'
ALTER TABLE [dbo].[Custom]
ADD CONSTRAINT [PK_Custom]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Good'
ALTER TABLE [dbo].[Good]
ADD CONSTRAINT [PK_Good]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Product'
ALTER TABLE [dbo].[Product]
ADD CONSTRAINT [PK_Product]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Good_Id], [Product_Id] in table 'GoodProduct'
ALTER TABLE [dbo].[GoodProduct]
ADD CONSTRAINT [PK_GoodProduct]
    PRIMARY KEY CLUSTERED ([Good_Id], [Product_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [CustomId] in table 'Good'
ALTER TABLE [dbo].[Good]
ADD CONSTRAINT [FK_CustomGood]
    FOREIGN KEY ([CustomId])
    REFERENCES [dbo].[Custom]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CustomGood'
CREATE INDEX [IX_FK_CustomGood]
ON [dbo].[Good]
    ([CustomId]);
GO

-- Creating foreign key on [Good_Id] in table 'GoodProduct'
ALTER TABLE [dbo].[GoodProduct]
ADD CONSTRAINT [FK_GoodProduct_Good]
    FOREIGN KEY ([Good_Id])
    REFERENCES [dbo].[Good]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Product_Id] in table 'GoodProduct'
ALTER TABLE [dbo].[GoodProduct]
ADD CONSTRAINT [FK_GoodProduct_Product]
    FOREIGN KEY ([Product_Id])
    REFERENCES [dbo].[Product]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_GoodProduct_Product'
CREATE INDEX [IX_FK_GoodProduct_Product]
ON [dbo].[GoodProduct]
    ([Product_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------