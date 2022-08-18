USE [fullstackDotNetAngularJS]
GO

INSERT INTO [dbo].[TB_DADOS_PESSOAIS]
           ([NOME_COMPLETO]
           ,[NOME_SOCIAL]
           ,[RG]
           ,[CPF]
           ,[DATA_NASCIMENTO]
           ,[ATIVO])
     VALUES
           ('Romário Faria Filho'
           ,'Romário'
           ,'123456789'
           ,'01234567890'
           ,'2012-02-21T18:10:00'
           ,1)
GO

INSERT INTO [dbo].[TB_DADOS_PESSOAIS]
           ([NOME_COMPLETO]
           ,[NOME_SOCIAL]
           ,[RG]
           ,[CPF]
           ,[DATA_NASCIMENTO]
           ,[ATIVO])
     VALUES
           ('Ronaldo Nazário'
           ,'Ronaldo'
           ,'000000009'
           ,'00000000009'
           ,'2012-02-21T18:10:00'
           ,2)

INSERT INTO [dbo].[TB_DADOS_PESSOAIS]
           ([NOME_COMPLETO]           
           ,[RG]
           ,[CPF]
           ,[DATA_NASCIMENTO]
           ,[ATIVO])
     VALUES
           ('Bebeto'           
           ,'000000007'
           ,'00000000007'
           ,'2012-02-21T18:10:00'
           ,3)

INSERT INTO [dbo].[TB_DADOS_PESSOAIS]
           ([NOME_COMPLETO]           
           ,[RG]
           ,[CPF]
           ,[DATA_NASCIMENTO]
           ,[ATIVO])
     VALUES
           ('Dunga'           
           ,'000000008'
           ,'00000000008'
           ,'2012-02-21T18:10:00'
           ,4)

INSERT INTO [dbo].[TB_DADOS_PESSOAIS]
           ([NOME_COMPLETO]           
           ,[RG]
           ,[CPF]
           ,[DATA_NASCIMENTO]
           ,[ATIVO])
     VALUES
           ('Mauro Silva'           
           ,'000000005'
           ,'00000000005'
           ,'2012-02-21T18:10:00'
           ,5)

select * from [dbo].[TB_DADOS_PESSOAIS] where ATIVO = 1