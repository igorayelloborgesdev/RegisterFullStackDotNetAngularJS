using APIFuncionario.IModels;
using APIFuncionario.IService;
using APIFuncionario.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace APIFuncionario.Service
{
    public class CadastroService : ICadastroService
    {
        private ResponseObject<IDadosPessoais> responseObject = new ResponseObject<IDadosPessoais>();
        private ResponseObject<IEnumerable<IDadosPessoais>> responseObjectLista = new ResponseObject<IEnumerable<IDadosPessoais>>();
        private ResponseObject<int> responseObjectExcluir = new ResponseObject<int>();
        public async Task<ResponseObject<IDadosPessoais>> Cadastrar()//Retorna funcionário criado
        {
            try
            {
             
                return responseObject.SetSuccess(true).Build();
            }
            catch (Exception ex)
            {
                return responseObject.SetSuccess(false).SetMessage("Erro ao cadastrar funcionário. " + ex.Message).Build();
            }
        }
        public async Task<ResponseObject<IDadosPessoais>> Alterar()//Retorna funcionário alterado
        {
            try
            {
                return responseObject.SetSuccess(true).Build();
            }
            catch (Exception ex)
            {
                return responseObject.SetSuccess(false).SetMessage("Erro ao alterar funcionário. " + ex.Message).Build();
            }
        }
        public async Task<ResponseObject<int>> Excluir(string cpf)//Retorna id do usuário excluído
        {
            try
            {

                return responseObjectExcluir.SetSuccess(true).Build();
            }
            catch (Exception ex)
            {
                return responseObjectExcluir.SetSuccess(false).SetMessage("Erro ao excluir funcionário. " + ex.Message).Build();
            }
        }
        public async Task<ResponseObject<IEnumerable<IDadosPessoais>>> ConsultarTodos(int paginacaoInicial)//Retorna lista paginada de funcionários
        {
            try
            {
                return responseObjectLista.SetSuccess(true).Build();
            }
            catch (Exception ex)
            {
                return responseObjectLista.SetSuccess(false).SetMessage("Erro ao consultar funcionários. " + ex.Message).Build();
            }
        }
        public async Task<ResponseObject<IDadosPessoais>> ConsultarPorId(int id)//Retorna funcionário pesquisado por id
        {
            try
            {
                return responseObject.SetSuccess(true).Build();
            }
            catch (Exception ex)
            {
                return responseObject.SetSuccess(false).SetMessage("Erro ao consultar funcionário. " + ex.Message).Build();
            }
        }
        public async Task<ResponseObject<IDadosPessoais>> ConsultarPorCpf(string cpf)//Retorna funcionário pesquisado por cpf
        {
            try
            {
                return responseObject.SetSuccess(true).Build();
            }
            catch (Exception ex)
            {
                return responseObject.SetSuccess(false).SetMessage("Erro ao consultar funcionário por cpf. " + ex.Message).Build();
            }
        }
    }
}