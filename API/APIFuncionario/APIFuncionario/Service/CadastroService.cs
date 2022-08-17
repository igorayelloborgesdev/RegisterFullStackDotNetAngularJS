using APIFuncionario.IModels;
using APIFuncionario.IRepository;
using APIFuncionario.IService;
using APIFuncionario.Models;
using APIFuncionario.Repository;
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
        private static ICadastroRepository _instance;
        public static ICadastroRepository GetInstance()
        {
            if (_instance == null)
            {
                _instance = new CadastroRepository();
            }
            return _instance;
        }
        private ResponseObject<IDadosPessoais> responseObject = new ResponseObject<IDadosPessoais>();
        private ResponseObject<IEnumerable<IDadosPessoais>> responseObjectLista = new ResponseObject<IEnumerable<IDadosPessoais>>();
        private ResponseObject<int> responseObjectExcluir = new ResponseObject<int>();

        public CadastroService()
        {
            GetInstance();
        }

        public async Task<ResponseObject<IDadosPessoais>> Cadastrar()//Retorna funcionário criado
        {
            try
            {
                //Verificar se cpf já existe no banco
                //Se cpf existir lançar exceção
                //Verificar dados obrigatórios                
                //Verificar somente números/ Retirar caracteres especiais
                //Verificar somente sigla
                //Verificar número máximo de carateres
                //Cadastrar todas as tabelas
                //Retornar usuário cadastrado

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
                //Verificar se cpf já existe no banco
                //Se cpf não existir lançar exceção
                //Verificar dados obrigatórios                
                //Verificar somente números/ Retirar caracteres especiais
                //Verificar somente sigla
                //Verificar número máximo de carateres
                //Alterar todas as tabelas
                //Retornar usuário alterado
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
                //Verificar se cpf já existe no banco
                //Se cpf não existir lançar exceção                
                //Excluir usuário
                //Retornar usuário excluído
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
                IEnumerable<DadosPessoais> dadosPessoaisLista = await _instance.ConsultarTodos(paginacaoInicial);
                return responseObjectLista.SetSuccess(true).SetResponseObjDadosPessoaisList(dadosPessoaisLista.ToList()).Build();
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