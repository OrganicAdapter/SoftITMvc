
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server Compact Edition
-- --------------------------------------------------
-- Date Created: 08/24/2014 13:08:32
-- Generated from EDMX file: D:\SoftIT\SoftITMvc\SoftITMvc\Models\ProjectModel.edmx
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- NOTE: if the constraint does not exist, an ignorable error will be reported.
-- --------------------------------------------------

    ALTER TABLE [WorkflowSet] DROP CONSTRAINT [FK_ProjectWorkflow];
GO
    ALTER TABLE [ProjectSet] DROP CONSTRAINT [FK_ProjectEmployee];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- NOTE: if the table does not exist, an ignorable error will be reported.
-- --------------------------------------------------

    DROP TABLE [ProjectSet];
GO
    DROP TABLE [WorkflowSet];
GO
    DROP TABLE [EmployeeSet];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'ProjectSet'
CREATE TABLE [ProjectSet] (
    [ProjectId] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(4000)  NOT NULL,
    [Description] nvarchar(4000)  NOT NULL,
    [Price] smallint  NOT NULL,
    [Logo] nvarchar(4000)  NOT NULL,
    [State] int  NOT NULL,
    [Rating] nvarchar(4000)  NULL,
    [Deadline] nvarchar(4000)  NOT NULL,
    [ProcurerId] int  NOT NULL,
    [EmployeeId] int  NOT NULL
);
GO

-- Creating table 'WorkflowSet'
CREATE TABLE [WorkflowSet] (
    [WorkflowId] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(4000)  NOT NULL,
    [Date] nvarchar(4000)  NOT NULL,
    [ProjectId] int  NOT NULL
);
GO

-- Creating table 'EmployeeSet'
CREATE TABLE [EmployeeSet] (
    [EmployeeId] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(4000)  NOT NULL,
    [Email] nvarchar(4000)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [ProjectId] in table 'ProjectSet'
ALTER TABLE [ProjectSet]
ADD CONSTRAINT [PK_ProjectSet]
    PRIMARY KEY ([ProjectId] );
GO

-- Creating primary key on [WorkflowId] in table 'WorkflowSet'
ALTER TABLE [WorkflowSet]
ADD CONSTRAINT [PK_WorkflowSet]
    PRIMARY KEY ([WorkflowId] );
GO

-- Creating primary key on [EmployeeId] in table 'EmployeeSet'
ALTER TABLE [EmployeeSet]
ADD CONSTRAINT [PK_EmployeeSet]
    PRIMARY KEY ([EmployeeId] );
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [ProjectId] in table 'WorkflowSet'
ALTER TABLE [WorkflowSet]
ADD CONSTRAINT [FK_ProjectWorkflow]
    FOREIGN KEY ([ProjectId])
    REFERENCES [ProjectSet]
        ([ProjectId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProjectWorkflow'
CREATE INDEX [IX_FK_ProjectWorkflow]
ON [WorkflowSet]
    ([ProjectId]);
GO

-- Creating foreign key on [EmployeeId] in table 'ProjectSet'
ALTER TABLE [ProjectSet]
ADD CONSTRAINT [FK_ProjectEmployee]
    FOREIGN KEY ([EmployeeId])
    REFERENCES [EmployeeSet]
        ([EmployeeId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProjectEmployee'
CREATE INDEX [IX_FK_ProjectEmployee]
ON [ProjectSet]
    ([EmployeeId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------