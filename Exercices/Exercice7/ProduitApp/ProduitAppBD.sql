--DROP TABLE [tbProduit]
--drop Database [ProduitAppBD]
Create Database[ProduitAppBD]
Go
USE [ProduitAppBD]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbProduit](
[IdProduit] INT IDENTITY (1,1) NOT NULL,
[dblPrix] DECIMAL NOT NULL,
[strDesignation] VARCHAR (20) NOT NULL
);
