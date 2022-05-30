CREATE DATABASE account
GO
USE account
GO

CREATE TABLE accounts(
username VARCHAR(50) PRIMARY KEY,
password VARCHAR(50)
)
GO

INSERT INTO dbo.accounts
(
    username,
    password
)
VALUES
(   'admin', -- username - varchar(50)
    'admin'  -- password - varchar(50)
    ),
	(   'admin1', -- username - varchar(50)
    'admin1'  -- password - varchar(50)
    ),
	(   'admin2', -- username - varchar(50)
    'admin2'  -- password - varchar(50)
    ),
	(   'admin3', -- username - varchar(50)
    'admin3'  -- password - varchar(50)
    )

