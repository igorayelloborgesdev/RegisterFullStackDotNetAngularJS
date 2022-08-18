using APIFuncionario.Config;
using APIFuncionario.IRepository;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace APIFuncionario.Repository
{
    public class DadosPessoaisRepository : IDadosPessoaisRepository
    {
        string connStr = AppConfig.GetConnStr();
        public Task<int> Incluir(string Nome_Completo, string Nome_Social, string RG, string CPF, string Data_Nascimento) 
        {
            int id = 0;
            string sql = "INSERT INTO TB_DADOS_PESSOAIS (NOME_COMPLETO ,NOME_SOCIAL ,RG ,CPF ,DATA_NASCIMENTO ,ATIVO) VALUES (@Nome_Completo, @Nome_Social, @RG, @CPF, @Data_Nascimento, 1); SELECT CAST(SCOPE_IDENTITY()as int);";
            using (var db = new SqlConnection(connStr))
            {
                id = db.QuerySingle<int>(sql, new { Nome_Completo = Nome_Completo, Nome_Social = Nome_Social, RG = RG, CPF = CPF, Data_Nascimento = Data_Nascimento });
            }
            return Task.FromResult(id);
        }
        public async Task Alterar(string Nome_Completo, string Nome_Social, string RG, string CPF, string Data_Nascimento, int id) 
        {
            string sql = "UPDATE TB_DADOS_PESSOAIS SET NOME_COMPLETO = @Nome_Completo ,NOME_SOCIAL = @Nome_Social ,RG = @RG ,CPF = @CPF ,DATA_NASCIMENTO = @Data_Nascimento  WHERE ID = @id";
            using (var db = new SqlConnection(connStr))
            {
                db.Execute(sql, new { Nome_Completo = Nome_Completo, Nome_Social = Nome_Social, RG = RG, CPF = CPF, Data_Nascimento = Data_Nascimento, id = id });
            }
        }
    }
}