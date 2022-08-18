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
        [Route("excluirPorCPF/{cpf}")]
        [HttpDelete]
        public async Task<ResponseObject<IDadosPessoais>> Excluir(string cpf)//Retorna id do usuário excluído
        {
            return await _instance.Excluir(cpf);
        }
        [Route("todos/{paginacaoInicial:int}")]
        [HttpGet]
        public async Task<ResponseObject<IEnumerable<IDadosPessoais>>> ConsultarTodos(int paginacaoInicial)//Retorna lista paginada de funcionários
        {
            return await _instance.ConsultarTodos(paginacaoInicial);            
        }
        [Route("porId/{id:int}")]
        [HttpGet]
        public async Task<ResponseObject<IDadosPessoais>> ConsultarPorId(int id)//Retorna funcionário pesquisado por id
        {
            return await _instance.ConsultarPorId(id);
        }
        [Route("porCPF/{cpf}")]
        [HttpGet]
        public async Task<ResponseObject<IDadosPessoais>> ConsultarPorCpf(string cpf)//Retorna funcionário pesquisado por cpf
        {
            return await _instance.ConsultarPorCpf(cpf);
        }

    }
}
