IF NOT EXISTS(SELECT name FROM sys.databases WHERE name = N'TodoAppDb')
BEGIN
    CREATE DATABASE TodoAppDb;
END
GO

USE TodoAppDb;
GO

IF OBJECT_ID('dbo.Accounts', 'U') IS NULL
BEGIN
    CREATE TABLE dbo.Accounts (
        Id INT IDENTITY(1,1) PRIMARY KEY,
        Username NVARCHAR(100) NOT NULL,
        Password NVARCHAR(200) NOT NULL
    );
END
GO

IF OBJECT_ID('dbo.Tags', 'U') IS NULL
BEGIN
    CREATE TABLE dbo.Tags (
        Id INT IDENTITY(1,1) PRIMARY KEY,
        Name NVARCHAR(100) NOT NULL,
        AccountId INT NULL,
        CONSTRAINT FK_Tags_Accounts FOREIGN KEY (AccountId) REFERENCES dbo.Accounts(Id)
    );
END
GO

IF OBJECT_ID('dbo.Todos', 'U') IS NULL
BEGIN
    CREATE TABLE dbo.Todos (
        Id INT IDENTITY(1,1) PRIMARY KEY,
        Content NVARCHAR(200) NOT NULL,
        Note NVARCHAR(500) NULL,
        DueDate DATETIME NULL,
        IsDone BIT NOT NULL DEFAULT 0,
        TagId INT NOT NULL,
        CONSTRAINT FK_Todos_Tags FOREIGN KEY (TagId) REFERENCES dbo.Tags(Id) ON DELETE CASCADE
    );
END
GO