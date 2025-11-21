IF NOT EXISTS(SELECT name
              FROM sys.databases
              WHERE name = N'TodoAppDb')
    BEGIN
        CREATE DATABASE TodoAppDb;
    END
GO

USE TodoAppDb;
GO

-- 1. Bảng Accounts
IF OBJECT_ID('dbo.Accounts', 'U') IS NULL
    BEGIN
        CREATE TABLE dbo.Accounts
        (
            Id       INT IDENTITY (1,1) PRIMARY KEY,
            Username NVARCHAR(100) NOT NULL,
            Password NVARCHAR(200) NOT NULL
        );
    END
GO

-- 2. Bảng Tags
IF OBJECT_ID('dbo.Tags', 'U') IS NULL
    BEGIN
        CREATE TABLE dbo.Tags
        (
            Id        INT IDENTITY (1,1) PRIMARY KEY,
            Name      NVARCHAR(100) NOT NULL,
            AccountId INT           NULL, -- Tag này thuộc về user nào
            CONSTRAINT FK_Tags_Accounts FOREIGN KEY (AccountId) REFERENCES dbo.Accounts (Id)
        );
    END
GO

-- 3. Bảng Todos (Sửa đổi lớn)
IF OBJECT_ID('dbo.Todos', 'U') IS NULL
    BEGIN
        CREATE TABLE dbo.Todos
        (
            Id          INT IDENTITY (1,1) PRIMARY KEY,
            Content     NVARCHAR(200) NOT NULL,
            Note        NVARCHAR(500) NULL,
            DueDate     DATETIME      NULL,
            IsDone      BIT           NOT NULL DEFAULT 0,
            IsImportant BIT           NOT NULL DEFAULT 0, -- Sửa từ Priority thành IsImportant theo ảnh
            ParentId    INT           NULL,               -- Thêm trường đệ quy theo ảnh

            -- Khóa ngoại đệ quy: ParentId tham chiếu chính Id của bảng Todos
            CONSTRAINT FK_Todos_Parent FOREIGN KEY (ParentId) REFERENCES dbo.Todos (Id)
        );
    END
GO

-- 4. Bảng trung gian TagTodo (Mới thêm vào theo ảnh)
-- Bảng này giải quyết quan hệ Many-to-Many
IF OBJECT_ID('dbo.TagTodo', 'U') IS NULL
    BEGIN
        CREATE TABLE dbo.TagTodo
        (
            TagId  INT NOT NULL,
            TodoId INT NOT NULL,
            -- Khóa chính phức hợp gồm 2 cột
            PRIMARY KEY (TagId, TodoId),

            CONSTRAINT FK_TagTodo_Tags FOREIGN KEY (TagId) REFERENCES dbo.Tags (Id) ON DELETE CASCADE,
            CONSTRAINT FK_TagTodo_Todos FOREIGN KEY (TodoId) REFERENCES dbo.Todos (Id) ON DELETE CASCADE
        );
    END
GO