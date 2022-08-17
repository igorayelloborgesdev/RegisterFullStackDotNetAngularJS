using APIFuncionario.Config;
using APIFuncionario.IModels;
using APIFuncionario.IRepository;
using APIFuncionario.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace APIFuncionario.Repository
{
    public class SetorRepository : ISetorRepository
    {
        string connStr = AppConfig.GetConnStr();
        public async Task<IEnumerable<Setor>> ConsultarSetores()
        {
            IEnumerable<Setor> setores;
            using (var db = new SqlConnection(connStr))
            {
                await db.OpenAsync();
                var query = "SELECT ID, DESCRICAO FROM TB_SETOR_REF";
                setores = await db.QueryAsync<Setor>(query);                
            }
            return setores;
        }
    }
}