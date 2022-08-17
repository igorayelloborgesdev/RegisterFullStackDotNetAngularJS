USE [fullstackDotNetAngularJS]
GO

INSERT INTO [dbo].[TB_CARGO]
           ([DESCRICAO]
           ,[SALARIO]
           ,[DATA_INICIO]           
           ,[SETOR]
           ,[ID_TB_DADOS_PESSOAIS]
           ,[ID_TB_SETOR_REF])
     VALUES
           ('Atacante'
           ,100000.00
           ,'2012-02-21T18:10:00'          
           ,1
           ,3
           ,1)
GO

INSERT INTO [dbo].[TB_CARGO]
           ([DESCRICAO]
           ,[SALARIO]
           ,[DATA_INICIO]           
           ,[SETOR]
           ,[ID_TB_DADOS_PESSOAIS]
           ,[ID_TB_SETOR_REF])
     VALUES
           ('Atacante'
           ,250000.00
           ,'2012-02-21T18:10:00'          
           ,2
           ,4
           ,2)

INSERT INTO [dbo].[TB_CARGO]
           ([DESCRICAO]
           ,[SALARIO]
           ,[DATA_INICIO]           
           ,[SETOR]
           ,[ID_TB_DADOS_PESSOAIS]
           ,[ID_TB_SETOR_REF])
     VALUES
           ('Atacante'
           ,50000.00
           ,'2012-02-21T18:10:00'          
           ,3
           ,5
           ,3)

INSERT INTO [dbo].[TB_CARGO]
           ([DESCRICAO]
           ,[SALARIO]
           ,[DATA_INICIO]           
           ,[SETOR]
           ,[ID_TB_DADOS_PESSOAIS]
           ,[ID_TB_SETOR_REF])
     VALUES
           ('Volante'
           ,125000.00
           ,'2012-02-21T18:10:00'          
           ,4
           ,6
           ,4)

INSERT INTO [dbo].[TB_CARGO]
           ([DESCRICAO]
           ,[SALARIO]
           ,[DATA_INICIO]           
           ,[SETOR]
           ,[ID_TB_DADOS_PESSOAIS]
           ,[ID_TB_SETOR_REF])
     VALUES
           ('Volante'
           ,100500.00
           ,'2012-02-21T18:10:00'          
           ,5
           ,7
           ,5)

select * from [dbo].[TB_CARGO]