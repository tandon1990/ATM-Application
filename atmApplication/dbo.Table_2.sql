CREATE TABLE [dbo].[Table] (
    [AccNum]     VARCHAR (50) NOT NULL,
    [First Name] VARCHAR (50) NOT NULL,
    [Last Name]  VARCHAR (50) NOT NULL,
    [DOB]        VARCHAR(50)  NOT NULL,
    [Phone]      VARCHAR (15) NOT NULL,
    [Address]    VARCHAR (50) NOT NULL,
	[PIN]    INT          NOT NULL,
    [Balance]    INT          NOT NULL,
    PRIMARY KEY CLUSTERED ([AccNum] ASC)
);

