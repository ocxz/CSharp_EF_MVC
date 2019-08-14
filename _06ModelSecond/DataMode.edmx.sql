
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 08/13/2019 15:37:49
-- Generated from EDMX file: F:\c#代码\c#进阶学习\5、Asp.Net学习\5、MVC之EF\MVC之EF的解决方案\_06ModelSecond\DataMode.edmx
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

-- Creating table 'StudentSet'
CREATE TABLE [dbo].[StudentSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [StuName] nvarchar(10)  NOT NULL,
    [StuAge] int  NULL
);
GO

-- Creating table 'ClassesSet'
CREATE TABLE [dbo].[ClassesSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [ClassName] nvarchar(10)  NOT NULL,
    [StudentId] int  NOT NULL
);
GO

-- Creating table 'GradeSet'
CREATE TABLE [dbo].[GradeSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Sorce] int  NOT NULL
);
GO

-- Creating table 'StudentGrade'
CREATE TABLE [dbo].[StudentGrade] (
    [Student_Id] int  NOT NULL,
    [Grade_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'StudentSet'
ALTER TABLE [dbo].[StudentSet]
ADD CONSTRAINT [PK_StudentSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ClassesSet'
ALTER TABLE [dbo].[ClassesSet]
ADD CONSTRAINT [PK_ClassesSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'GradeSet'
ALTER TABLE [dbo].[GradeSet]
ADD CONSTRAINT [PK_GradeSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Student_Id], [Grade_Id] in table 'StudentGrade'
ALTER TABLE [dbo].[StudentGrade]
ADD CONSTRAINT [PK_StudentGrade]
    PRIMARY KEY CLUSTERED ([Student_Id], [Grade_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [StudentId] in table 'ClassesSet'
ALTER TABLE [dbo].[ClassesSet]
ADD CONSTRAINT [FK_StudentClasses]
    FOREIGN KEY ([StudentId])
    REFERENCES [dbo].[StudentSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_StudentClasses'
CREATE INDEX [IX_FK_StudentClasses]
ON [dbo].[ClassesSet]
    ([StudentId]);
GO

-- Creating foreign key on [Student_Id] in table 'StudentGrade'
ALTER TABLE [dbo].[StudentGrade]
ADD CONSTRAINT [FK_StudentGrade_Student]
    FOREIGN KEY ([Student_Id])
    REFERENCES [dbo].[StudentSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Grade_Id] in table 'StudentGrade'
ALTER TABLE [dbo].[StudentGrade]
ADD CONSTRAINT [FK_StudentGrade_Grade]
    FOREIGN KEY ([Grade_Id])
    REFERENCES [dbo].[GradeSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_StudentGrade_Grade'
CREATE INDEX [IX_FK_StudentGrade_Grade]
ON [dbo].[StudentGrade]
    ([Grade_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------