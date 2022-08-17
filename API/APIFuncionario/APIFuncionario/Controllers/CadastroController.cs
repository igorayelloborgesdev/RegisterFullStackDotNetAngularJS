using APIFuncionario.IModels;
using APIFuncionario.IService;
using APIFuncionario.Response;
using APIFuncionario.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace APIFuncionario.Controllers
{
    [RoutePrefix("api/cadastro")]
    public class CadastroController : ApiController
    {
        private static ICadastroService _instance;
        public static ICadastroService GetInstance()
        {
            if (_instance == null)
            {
                _instance = new CadastroService();
            }
            return _instance;
        }

        public CadastroController()
        {
            GetInstance();
        }
        //public void Cadastrar() //Retorna funcionário criado
        //{ }
        //public void Alterar()//Retorna funcionário alterado
        //{ }
        //public void Excluir(string cpf)//Retorna id do usuário excluído
        //{ }
        [Route("todos/{paginacaoInicial:int}")]
        [HttpGet]
        public async Task<ResponseObject<IEnumerable<IDadosPessoais>>> ConsultarTodos(int paginacaoInicial)//Retorna lista paginada de funcionários
        {
            return await _instance.ConsultarTodos(paginacaoInicial);            
        }
        //public void ConsultarPorId(int id)//Retorna funcionário pesquisado por id
        //{ }
        //void ConsultarPorCpf(string cpf)//Retorna funcionário pesquisado por cpf
        //{ }

    }
}
