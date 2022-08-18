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
    public class CargoRepository : ICargoRepository
    {
        string connStr = AppConfig.GetConnStr();
        public async Task Incluir(string Descricao, decimal Salario, string Data_Inicio, int setor, int idIdentity, string Data_Encerramento = null) {

            string sql = "INSERT INTO TB_CARGO (DESCRICAO ,SALARIO ,DATA_INICIO ,DATA_ENCERRAMENTO ,SETOR ,ID_TB_DADOS_PESSOAIS ,ID_TB_SETOR_REF) VALUES (@Descricao, @Salario, @Data_Inicio, @Data_Encerramento, @setor, @idIdentity ,@setor);";
            using (var db = new SqlConnection(connStr))
            {                
                int rowsAffected = db.Execute(sql, new { Descricao = Descricao, Salario = Salario, Data_Inicio = Data_Inicio, Data_Encerramento = Data_Encerramento, setor = setor, idIdentity = idIdentity });
            }
        }
        public async Task Alterar(string Descricao, decimal Salario, string Data_Inicio, int setor, int id, string Data_Encerramento = null) {
            string sql = "UPDATE TB_CARGO SET DESCRICAO = @Descricao ,SALARIO = @Salario ,DATA_INICIO = @Data_Inicio ,DATA_ENCERRAMENTO = @Data_Encerramento ,SETOR = @setor  WHERE ID_TB_DADOS_PESSOAIS = @id";
            using (var db = new SqlConnection(connStr))
            {
                int rowsAffected = db.Execute(sql, new { Descricao = Descricao, Salario = Salario, Data_Inicio = Data_Inicio, Data_Encerramento = Data_Encerramento, setor = setor, id = id });
            }
        }
    }
}