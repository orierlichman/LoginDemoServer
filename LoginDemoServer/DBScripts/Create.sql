Drop database LoginDemoDB

Create Database LoginDemoDB
Go

select * from Grade
Go
Create Table Users (
	Email nvarchar(100) PRIMARY KEY,
	[Password] nvarchar(20) NOT NULL,
	PhoneNumber nvarchar(20) NULL,
	BirthDate DATETIME NULL,
	[Status] int NULL,
	[Name] nvarchar(50) NOT NULL
)
Go

Create Table Grade (
	[Date] DATETIME NOT NULL,
	SubjectName nvarchar(20) NOT NULL,
	TestGrade int NOT NULL,
	Email nvarchar(100) NOT NULL  FOREIGN KEY REFERENCES Users(Email)
)
Go

INSERT INTO dbo.Users VALUES ('ofer@ofer.com', '1234', '+972526344450','15-nov-1972',1,'Ofer Zadikario')
Go

INSERT INTO dbo.Grade VALUES ('20-nov-1988', 'math', 95,'ofer@ofer.com')
Go
INSERT INTO dbo.Grade VALUES ('22-nov-1988', 'english', 78,'ofer@ofer.com')
Go
INSERT INTO dbo.Grade VALUES ('27-nov-1988', 'history', 88,'ofer@ofer.com')
Go
INSERT INTO dbo.Grade VALUES ('30-nov-1988', 'sport', 100,'ofer@ofer.com')
Go

--scaffold-DbContext "Server = (localdb)\MSSQLLocalDB;Initial Catalog=LoginDemoDB;Integrated Security=True;Persist Security Info=False;Pooling=False;Multiple Active Result Sets=False;Encrypt=False;Trust Server Certificate=False;Command Timeout=0" Microsoft.EntityFrameworkCore.SqlServer -OutPutDir Models -Context LoginDemoDbContext -DataAnnotations -force