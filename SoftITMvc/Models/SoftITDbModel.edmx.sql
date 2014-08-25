
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server Compact Edition
-- --------------------------------------------------
-- Date Created: 08/25/2014 21:19:17
-- Generated from EDMX file: E:\GitHub\SoftITMvc\SoftITMvc\Models\SoftITDbModel.edmx
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- NOTE: if the constraint does not exist, an ignorable error will be reported.
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- NOTE: if the table does not exist, an ignorable error will be reported.
-- --------------------------------------------------

    DROP TABLE [EmployeeSet];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'EmployeeSet'
CREATE TABLE [EmployeeSet] (
    [EmployeeId] int IDENTITY(1,1) NOT NULL,
    [FullName] nvarchar(4000)  NOT NULL,
    [Email] nvarchar(4000)  NOT NULL,
    [Skype] nvarchar(4000)  NOT NULL,
    [Tel] nvarchar(4000)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [EmployeeId] in table 'EmployeeSet'
ALTER TABLE [EmployeeSet]
ADD CONSTRAINT [PK_EmployeeSet]
    PRIMARY KEY ([EmployeeId] );
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------