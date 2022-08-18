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
    public class EnderecoRepository : IEnderecoRepository
    {
        string connStr = AppConfig.GetConnStr();
        public async Task Incluir(string Logradouro, string Numero, string Cidade, string Cep, string Estado, int idIdentity, string Complemento = null) 
        {
            string sql = "INSERT INTO TB_ENDERECO (LOGRADOURO ,NUMERO ,CIDADE ,CEP ,ESTADO ,ID_TB_DADOS_PESSOAIS, COMPLEMENTO) VALUES (@Logradouro, @Numero, @Cidade, @Cep, @Estado, @idIdentity, @Complemento)";
            using (var db = new SqlConnection(connStr))
            {
                int rowsAffected = db.Execute(sql, new { Logradouro = Logradouro, Numero = Numero, Cidade = Cidade, Cep = Cep, Estado = Estado, idIdentity = idIdentity, Complemento = Complemento });
            }
        }
        public async Task Alterar(string Logradouro, string Numero, string Cidade, string Cep, string Estado, int id, string Complemento = null) 
        {
            string sql = "UPDATE TB_ENDERECO SET LOGRADOURO = @Logradouro ,NUMERO = @Numero ,CIDADE = @Cidade ,CEP = @Cep ,COMPLEMENTO = @Complemento ,ESTADO = @Estado  WHERE  ID_TB_DADOS_PESSOAIS = @id";
            using (var db = new SqlConnection(connStr))
            {
                int rowsAffected = db.Execute(sql, new { Logradouro = Logradouro, Numero = Numero, Cidade = Cidade, Cep = Cep, Estado = Estado, id = id, Complemento = Complemento });
            }
        }
    }
}