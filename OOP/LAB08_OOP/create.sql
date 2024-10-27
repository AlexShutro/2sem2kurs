

-------------------------------------------------------

CREATE TABLE [dbo].[Title] (
                [id] INT IDENTITY (1, 1) NOT NULL,
                [BookName] NVARCHAR (50) NOT NULL,
                [PublDate] DATETIME NOT NULL,
                [UDC] NCHAR (15) NOT NULL,
                [ImageData] NVARCHAR(255) NULL,
                CONSTRAINT [PK__Title__3214EC071237FB30] PRIMARY KEY CLUSTERED ([Id] ASC));

-------------------------------------------------------
CREATE TABLE [dbo].[Book] (
            [id] INT IDENTITY (0, 1) NOT NULL,
            [TitleId] INT NOT NULL,
            [BookName] NVARCHAR (50) NOT NULL,
            [Publisher] NVARCHAR (50) NOT NULL,
            [sendDate] DATETIME NULL,
            [startSize] INT NULL,
            [Formate] NVARCHAR (10) NULL,
            CONSTRAINT [PK__Book__3214EC071237FB30] PRIMARY KEY CLUSTERED ([Id] ASC),
            CONSTRAINT [FK__Book__TitleId__267ABA7A] FOREIGN KEY ([TitleId]) REFERENCES [dbo].[Title] ([Id])
        );
-------------------------------------------------------




SELECT TOP 1 id
FROM Title
ORDER BY id DESC;

