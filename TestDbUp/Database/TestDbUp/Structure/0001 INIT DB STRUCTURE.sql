/****************************
*
*	INITIAL PROJECT DATABASE STRUTURE
*
*************************************************/

/* CUSTOMERS TABLE */
IF NOT EXISTS (SELECT * FROM sysobjects WHERE [name]='CUSTOMERS' and xtype='U')
BEGIN  
	CREATE TABLE [dbo].[Customers](
		[Id] int PRIMARY KEY IDENTITY NOT NULL,
		[FirstName] varchar(50) NOT NULL,
		[LastName] varchar(50) NOT NULL,
	) ON [PRIMARY]
END