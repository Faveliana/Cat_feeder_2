GO
CREATE DATABASE DataBaseCat

GO
USE DataBaseCat

CREATE TABLE [User]
(
[id] INT NOT NULL IDENTITY (0,1) CONSTRAINT PK_User PRIMARY KEY,
[login] NVARCHAR (15) NOT NULL,
[password] NVARCHAR (15) NOT NULL
);

CREATE TABLE [FeedType]
(
[id] INT NOT NULL IDENTITY (1,1) CONSTRAINT PK_FeedType PRIMARY KEY,
[name] NVARCHAR (MAX) NOT NULL
);

CREATE TABLE [FeederType]
(
[id] INT NOT NULL IDENTITY (0,1) CONSTRAINT PK_FeederType PRIMARY KEY,
[name] NVARCHAR (MAX) NOT NULL
);

CREATE TABLE [Feeder]
(
[id] INT NOT NULL IDENTITY (0,1) CONSTRAINT PK_Feeder PRIMARY KEY,
[type_id]	INT NOT NULL CONSTRAINT FK_Feeder_FeederType FOREIGN KEY  REFERENCES [FeederType]([id]) DEFAULT 0,
[status] INT NOT NULL DEFAULT 0
);

CREATE TABLE [UserFeeder]
(
[id] INT NOT NULL IDENTITY (0,1) CONSTRAINT PK_UserFeeder PRIMARY KEY,
[user_id] INT NOT NULL CONSTRAINT FK_UserFeeder_User FOREIGN KEY REFERENCES [User]([id]),
[feeder_id] INT NOT NULL CONSTRAINT FK_UserFeder_Feeder FOREIGN KEY REFERENCES [Feeder]([id]),
);

CREATE TABLE [Schedule]
(
[id] INT NOT NULL IDENTITY(1,1) CONSTRAINT PK_Schedule PRIMARY KEY,
[time] TIME NOT NULL,
[feed_type_id] INT NOT NULL CONSTRAINT FK_Schedule_FeedType FOREIGN KEY REFERENCES [FeedType]([id])
);

CREATE TABLE [FeederSchedule]
(
[id] INT NOT NULL IDENTITY (1,1) CONSTRAINT FK_FeederSchedule PRIMARY KEY,
[feeder_id] INT NOT NULL CONSTRAINT FK_FeederSchedule_Feeder FOREIGN KEY REFERENCES [Feeder](id),
[schedule_id] INT NOT NULL CONSTRAINT FK_FeederSchedule_Schedule FOREIGN KEY REFERENCES [Schedule](id),
)


GO
USE DataBaseCat;

DECLARE @user_id INT,
@feed_type_id INT,
@feeder_type_id INT,
@feeder_id INT,
@schedule_id INT

INSERT INTO [FeedType]([name]) VALUES ('корм 1'),('корм 2'),('корм 3');
SET @feed_type_id = @@IDENTITY
INSERT INTO [FeederType]([name]) VALUES ('кормушка тип 1'), ('кормушка тип 2');
SET @feeder_type_id = @@IDENTITY
INSERT INTO [Feeder]([type_id],[status]) VALUES (@feeder_type_id, 10);
SET @feeder_id = @@IDENTITY
INSERT INTO [User]([login],[password]) VALUES ('admin','admin');
SET @user_id = @@IDENTITY
INSERT INTO [UserFeeder]([user_id],[feeder_id]) VALUES (@user_id,@feeder_id)
INSERT INTO [Schedule]([time],[feed_type_id]) VALUES (CAST('12:00:00' AS TIME),@feed_type_id);
SET @schedule_id = @@IDENTITY
INSERT INTO [FeederSchedule]([feeder_id],[schedule_id]) VALUES (@feeder_id,@schedule_id)
INSERT INTO [Schedule]([time],[feed_type_id]) VALUES (CAST('13:00:00' AS TIME),@feed_type_id);
SET @schedule_id = @@IDENTITY
INSERT INTO [FeederSchedule]([feeder_id],[schedule_id]) VALUES (@feeder_id,@schedule_id)

GO
CREATE PROCEDURE SP_Authorize @login NVARCHAR(MAX), @password NVARCHAR(MAX)
AS
BEGIN
	DECLARE @id INT
	SELECT @id = [id] FROM [User] WHERE [login]=@login AND [password]=@password
	IF @id IS NOT NULL
		RETURN @id
	ELSE
		RETURN -1

END

GO
CREATE PROCEDURE SP_SelectUser @id INT
AS
BEGIN
	SELECT * FROM [User] WHERE [id]=@id
END

GO
CREATE PROCEDURE SP_SelectFeeder @id INT
AS
BEGIN
	SELECT * FROM [Feeder] WHERE [id]=@id
END

GO
CREATE PROCEDURE SP_SelectFeederSchedule @id INT
AS
BEGIN
	SELECT Sh.* FROM [FeederSchedule] 
	JOIN [Schedule] AS Sh ON [schedule_id] = Sh.id
	WHERE [feeder_id] = @id
END

GO
CREATE PROCEDURE SP_SelectUserFeeder @id INT
AS
BEGIN
	SELECT F.* FROM [UserFeeder]
	JOIN [Feeder] AS F ON F.id = [feeder_id]
	WHERE [user_id] = @id
END