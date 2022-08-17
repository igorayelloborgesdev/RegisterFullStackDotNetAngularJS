USE [fullstackDotNetAngularJS]
GO

INSERT INTO [dbo].[TB_TELEFONES]
           ([DDD]
           ,[CELULAR]           
           ,[ID_TB_DADOS_PESSOAIS])
     VALUES
           ('35'
           ,'11111111'           
           ,3)
GO

INSERT INTO [dbo].[TB_TELEFONES]
           ([DDD]
           ,[CELULAR]           
           ,[ID_TB_DADOS_PESSOAIS])
     VALUES
           ('21'
           ,'99999999'           
           ,4)

INSERT INTO [dbo].[TB_TELEFONES]
           ([DDD]
           ,[CELULAR]           
           ,[ID_TB_DADOS_PESSOAIS])
     VALUES
           ('23'
           ,'77777777'           
           ,5)

INSERT INTO [dbo].[TB_TELEFONES]
           ([DDD]
           ,[CELULAR]           
           ,[ID_TB_DADOS_PESSOAIS])
     VALUES
           ('43'
           ,'88888888'           
           ,6)

INSERT INTO [dbo].[TB_TELEFONES]
           ([DDD]
           ,[CELULAR]           
           ,[ID_TB_DADOS_PESSOAIS])
     VALUES
           ('11'
           ,'555555555'           
           ,7)

select * from [dbo].[TB_TELEFONES]