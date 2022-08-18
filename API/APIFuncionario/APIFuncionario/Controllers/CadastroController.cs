using APIFuncionario.IModels;
using APIFuncionario.IService;
using APIFuncionario.Request;
using APIFuncionario.Response;
using APIFuncionario.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;

namespace APIFuncionario.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
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
        [Route("cadastrar")]
        [HttpPost]
        public async Task<ResponseObject<IDadosPessoais>> Cadastrar([FromBody] RequestObject requestObject) //Retorna funcionário criado
        {
            if (!ModelState.IsValid)
            {
                string messages = string.Join(" | ", ModelState.Values
                                        .SelectMany(x => x.Errors)
                                        .Select(x => x.ErrorMessage));

                var errors = ModelState.Select(x => x.Value.Errors).Where(y => y.Count > 0).ToList();
                return new ResponseObject<IDadosPessoais>().SetMessage($"Encontrados {errors} erros: {messages} ").SetSuccess(false);
            }            
            return await _instance.Cadastrar(requestObject);
        }
        [Route("Alterar")]
        [HttpPut]
        public async Task<ResponseObject<IDadosPessoais>> Alterar([FromBody] RequestObject requestObject)//Retorna funcionário alterado
        {
            if (!ModelState.IsValid)
            {
                string messages = string.Join(" | ", ModelState.Values
                                        .SelectMany(x => x.Errors)
                                        .Select(x => x.ErrorMessage));

                var errors = ModelState.Select(x => x.Value.Errors).Where(y => y.Count > 0).ToList();
                return new ResponseObject<IDadosPessoais>().SetMessage($"Encontrados {errors} erros: {messages} ").SetSuccess(false);
            }
            return await _instance.Alterar(requestObject);
        }
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
