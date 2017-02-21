/*
Created: 19.02.2017
Modified: 21.02.2017
Model: Microsoft SQL Server 2012
Database: MS SQL Server 2012
*/


-- Drop tables section ---------------------------------------------------

DROP TABLE [AccessRequests]
go
DROP TABLE [Users]
go
DROP TABLE [Db_Types]
go
DROP TABLE [Connections]
go

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

-- Table Db_Types

CREATE TABLE [Db_Types]
(
 [db_type_id] Int IDENTITY NOT NULL,
 [name] Varchar(200) NULL,
 [version] Varchar(100) NULL
)
go

-- Table Users

CREATE TABLE [Users]
(
 [UserId] Int IDENTITY NOT NULL,
 [UserName] Varchar(100) NOT NULL,
 [first_name] Varchar(100) NULL,
 [surname] Varchar(100) NULL,
 [email] Varchar(300) NULL,
 [manager_id] Int NULL
)
go

-- Table AccessRequests

CREATE TABLE [AccessRequests]
(
 [request_id] Int IDENTITY NOT NULL,
 [for_user_name] Varchar(100) NULL,
 [for_surname] Varchar(100) NULL,
 [for_email] Varchar(300) NULL,
 [requsestor_id] Int NULL,
 [message] Varchar(max) NULL
)
go


