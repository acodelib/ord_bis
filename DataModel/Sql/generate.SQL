/*
Created: 2/19/2017
Modified: 2/19/2017
Model: Microsoft SQL Server 2012
Database: MS SQL Server 2012
*/


-- Create tables section -------------------------------------------------

-- Table Connections

CREATE TABLE [Connections]
(
 [connection_id] Int IDENTITY NOT NULL,
 [name] Varchar(100) NOT NULL,
 [db_type_id] Int NOT NULL,
 [database_name] Varchar(256) NOT NULL,
 [default_schema] Varchar(128) NULL,
 [host] Varchar(512) NOT NULL,
 [db_user] Varchar(256) NOT NULL,
 [password] Varchar(2000) NOT NULL,
 [time_out] Int NULL,
 [connection_string] Varchar(6000) NULL
)
go

-- Create indexes for table Connections

CREATE INDEX [IX_Relationship1] ON [Connections] ([db_type_id])
go

-- Add keys for table Connections

ALTER TABLE [Connections] ADD CONSTRAINT [Key1] PRIMARY KEY ([connection_id])
go

-- Table Db_Types

CREATE TABLE [Db_Types]
(
 [db_type_id] Int IDENTITY NOT NULL,
 [name] Varchar(200) NULL,
 [version] Varchar(100) NULL
)
go

-- Add keys for table Db_Types

ALTER TABLE [Db_Types] ADD CONSTRAINT [Key2] PRIMARY KEY ([db_type_id])
go


