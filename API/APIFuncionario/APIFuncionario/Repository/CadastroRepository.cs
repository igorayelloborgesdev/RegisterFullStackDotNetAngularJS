using APIFuncionario.Config;
using APIFuncionario.IRepository;
using APIFuncionario.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace APIFuncionario.Repository
{
    public class CadastroRepository : ICadastroRepository
    {
        string connStr = AppConfig.GetConnStr();

        public async Task Cadastrar()
        { }
        public async Task Alterar()
        { }
        public async Task Excluir(string cpf)
        { }
        public async Task<IEnumerable<DadosPessoais>> ConsultarTodos(int paginacaoInicial)
        {
            IEnumerable<DadosPessoais> dadosPessoais;
            using (var db = new SqlConnection(connStr))
            {
                await db.OpenAsync();
                var query = "select dp.ID, dp.NOME_COMPLETO,dp.NOME_SOCIAL,dp.RG,dp.CPF,dp.DATA_NASCIMENTO, ca.DESCRICAO,ca.SALARIO,ca.DATA_INICIO, ca.ID, setRef.ID, setRef.DESCRICAO, endr.CEP, endr.CIDADE, endr.COMPLEMENTO, endr.ESTADO, endr.LOGRADOURO, endr.NUMERO, tel.CELULAR, tel.DDD, tel.RESIDENCIAL from TB_DADOS_PESSOAIS AS dp  inner join TB_CARGO AS ca on dp.ID = ca.ID_TB_DADOS_PESSOAIS  inner join TB_SETOR_REF AS setRef on ca.ID_TB_SETOR_REF = setRef.ID inner join TB_ENDERECO AS endr on dp.ID = endr.ID_TB_DADOS_PESSOAIS inner join TB_TELEFONES AS tel on dp.ID = tel.ID_TB_DADOS_PESSOAIS where dp.ATIVO = 1 order by dp.ID offset @PaginacaoInicial rows fetch next 2 rows only";
                dadosPessoais = await db.QueryAsync<DadosPessoais, Cargo, Setor, Endereco, Telefones, DadosPessoais>(query,
                    (dadosPessoal, cargo, setor, endereco, telefones) => 
                    {
                        dadosPessoal.cargo = cargo;
                        dadosPessoal.cargo.setorRef = setor;
                        dadosPessoal.endereco = endereco;
                        dadosPessoal.telefones = telefones;
                        return dadosPessoal;
                    },
                    param: new { PaginacaoInicial = paginacaoInicial },
                    splitOn: "DESCRICAO, ID, CEP, CELULAR"
                );
            }
            return dadosPessoais;
        }
        public async Task<DadosPessoais> ConsultarPorId(int id)
        {
            return null;
        }
        public async Task<DadosPessoais> ConsultarPorCpf(string cpf)
        {
            return null;
        }
    }
}