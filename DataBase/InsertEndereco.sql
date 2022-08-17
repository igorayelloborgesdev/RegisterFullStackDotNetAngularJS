USE [fullstackDotNetAngularJS]
GO

INSERT INTO [dbo].[TB_ENDERECO]
           ([LOGRADOURO]
           ,[NUMERO]
           ,[CIDADE]
           ,[CEP]           
           ,[ESTADO]
           ,[ID_TB_DADOS_PESSOAIS])
     VALUES
           ('Jão Januário'
           ,1989
           ,'Rio de Janeiro'
           ,09090123           
           ,'RJ'
           ,3)
GO

INSERT INTO [dbo].[TB_ENDERECO]
           ([LOGRADOURO]
           ,[NUMERO]
           ,[CIDADE]
           ,[CEP]           
           ,[ESTADO]
           ,[ID_TB_DADOS_PESSOAIS])
     VALUES
           ('São Cristovão'
           ,1970
           ,'Rio de Janeiro'
           ,'09090123'
           ,'RJ'
           ,4)

INSERT INTO [dbo].[TB_ENDERECO]
           ([LOGRADOURO]
           ,[NUMERO]
           ,[CIDADE]
           ,[CEP]           
           ,[ESTADO]
           ,[ID_TB_DADOS_PESSOAIS])
     VALUES
           ('Barradão'
           ,1964
           ,'Salvador'
           ,'09090000'           
           ,'BA'
           ,5)

INSERT INTO [dbo].[TB_ENDERECO]
           ([LOGRADOURO]
           ,[NUMERO]
           ,[CIDADE]
           ,[CEP]           
           ,[ESTADO]
           ,[ID_TB_DADOS_PESSOAIS])
     VALUES
           ('Beira Rio'
           ,1965
           ,'Porto Alegre'
           ,'12390123'
           ,'RS'
           ,6)

INSERT INTO [dbo].[TB_ENDERECO]
           ([LOGRADOURO]
           ,[NUMERO]
           ,[CIDADE]
           ,[CEP]           
           ,[ESTADO]
           ,[ID_TB_DADOS_PESSOAIS])
     VALUES
           ('São Paulo'
           ,1967
           ,'São Paulo'
           ,'01020123'
           ,'SP'
           ,7)

select * from [dbo].[TB_ENDERECO]