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
    public class TelefoneRepository : ITelefoneRepository
    {
        string connStr = AppConfig.GetConnStr();
        public async Task Incluir(string Ddd, string Celular, int idIdentity, string Residencial = null) 
        {
            string sql = "INSERT INTO TB_TELEFONES (DDD ,CELULAR ,RESIDENCIAL ,ID_TB_DADOS_PESSOAIS) VALUES (@Ddd ,@Celular ,@Residencial ,@idIdentity)";
            using (var db = new SqlConnection(connStr))
            {
                int rowsAffected = db.Execute(sql, new { Ddd = Ddd, Celular = Celular, idIdentity = idIdentity, Residencial = Residencial });
            }
        }
        public async Task Alterar(string Ddd, string Celular, int id, string Residencial = null) 
        {
            string sql = "UPDATE TB_TELEFONES SET DDD = @Ddd ,CELULAR = @Celular ,RESIDENCIAL = @Residencial WHERE ID_TB_DADOS_PESSOAIS = @id";
            using (var db = new SqlConnection(connStr))
            {
                int rowsAffected = db.Execute(sql, new { Ddd = Ddd, Celular = Celular, id = id, Residencial = Residencial });
            }
        }
    }
}