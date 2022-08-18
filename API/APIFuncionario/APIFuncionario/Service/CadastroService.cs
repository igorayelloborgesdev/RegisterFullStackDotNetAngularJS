using APIFuncionario.IModels;
using APIFuncionario.IRepository;
using APIFuncionario.IService;
using APIFuncionario.Models;
using APIFuncionario.Repository;
using APIFuncionario.Request;
using APIFuncionario.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Transactions;
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

        private static IDadosPessoaisRepository _instanceDadosPessoais;
        public static IDadosPessoaisRepository GetInstanceDadosPessoais()
        {
            if (_instanceDadosPessoais == null)
            {
                _instanceDadosPessoais = new DadosPessoaisRepository();
            }
            return _instanceDadosPessoais;
        }

        private static ICargoRepository _instanceCargo;
        public static ICargoRepository GetInstanceCargo()
        {
            if (_instanceCargo == null)
            {
                _instanceCargo = new CargoRepository();
            }
            return _instanceCargo;
        }

        private static ITelefoneRepository _instanceTelefone;
        public static ITelefoneRepository GetInstanceTelefone()
        {
            if (_instanceTelefone == null)
            {
                _instanceTelefone = new TelefoneRepository();
            }
            return _instanceTelefone;
        }

        private static IEnderecoRepository _instanceEndereco;
        public static IEnderecoRepository GetInstanceEndereco()
        {
            if (_instanceEndereco == null)
            {
                _instanceEndereco = new EnderecoRepository();
            }
            return _instanceEndereco;
        }
        


        private ResponseObject<IDadosPessoais> responseObject = new ResponseObject<IDadosPessoais>();
        private ResponseObject<IEnumerable<IDadosPessoais>> responseObjectLista = new ResponseObject<IEnumerable<IDadosPessoais>>();        

        public CadastroService()
        {
            GetInstance();
            GetInstanceDadosPessoais();
            GetInstanceCargo();
            GetInstanceTelefone();
            GetInstanceEndereco();
        }

        public async Task<ResponseObject<IDadosPessoais>> Cadastrar(RequestObject requestObject)//Retorna funcionário criado
        {
            try
            {
                using (TransactionScope scope = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
                {
                    DadosPessoais dadosPessoais = await _instance.ConsultarPorCpf(requestObject.CPF);//Verificar se cpf já existe no banco
                    if (dadosPessoais != null)//Se cpf existir lançar exceção
                        throw new Exception("Funcionário já cadastrado");
                    //Cadastrar todas as tabelas
                    int idIdentity = await _instanceDadosPessoais.Incluir(requestObject.Nome_Completo, requestObject.Nome_Social, requestObject.RG, requestObject.CPF, requestObject.Data_Nascimento.ToString("yyyy-MM-dd"));
                    await _instanceCargo.Incluir(requestObject.Descricao, requestObject.Salario, requestObject.Data_Inicio.ToString("yyyy-MM-dd"), requestObject.setor, idIdentity, requestObject.Data_Encerramento);
                    await _instanceTelefone.Incluir(requestObject.Ddd, requestObject.Celular, idIdentity, requestObject.Residencial);
                    await _instanceEndereco.Incluir(requestObject.Logradouro, requestObject.Numero, requestObject.Cidade, requestObject.Cep, requestObject.Estado, idIdentity, requestObject.Complemento);
                    DadosPessoais dadosPessoaisRegistrados = await _instance.ConsultarPorCpf(requestObject.CPF);//Verificar se cpf foi cadastrado
                    if (dadosPessoaisRegistrados == null)//Se cpf não existir lançar exceção
                        throw new Exception("Funcionário já cadastrado");
                    //Retornar usuário cadastrado
                    scope.Complete();
                    return responseObject.SetSuccess(true).SetResponseObjDadosPessoais(dadosPessoaisRegistrados).Build();
                }                
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
                //DadosPessoais dadosPessoais = await _instance.ConsultarPorCpf(cpf);//Verificar se cpf já existe no banco
                //if (dadosPessoais == null)//Se cpf não existir lançar exceção
                //    throw new Exception("Funcionário não cadastrado");
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
        public async Task<ResponseObject<IDadosPessoais>> Excluir(string cpf)//Retorna id do usuário excluído
        {
            try
            {
                using (TransactionScope scope = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
                {
                    DadosPessoais dadosPessoais = await _instance.ConsultarPorCpf(cpf);//Verificar se cpf já existe no banco
                    if (dadosPessoais == null)//Se cpf não existir lançar exceção
                        throw new Exception("Funcionário não cadastrado");
                    await _instance.Excluir(cpf);//Excluir usuário
                    DadosPessoais dadosPessoaisExcluido = await _instance.ConsultarPorCpf(cpf);//Verificar se o registro foi excluído
                    if(dadosPessoaisExcluido != null)
                        throw new Exception("Não foi possível excluir o funcionário");
                    scope.Complete();
                    return responseObject.SetSuccess(true)
                        .SetResponseObjDadosPessoais(new DadosPessoais() { Id = dadosPessoais.Id })
                        .SetMessage($"Funcionário {dadosPessoais.Nome_Completo} excluído com sucesso")
                        .Build();//Retornar usuário excluído                                        
                }
            }
            catch (Exception ex)
            {
                return responseObject.SetSuccess(false).SetMessage("Erro ao excluir funcionário. " + ex.Message).Build();
            }
        }
        public async Task<ResponseObject<IEnumerable<IDadosPessoais>>> ConsultarTodos(int paginacaoInicial)//Retorna lista paginada de funcionários
        {
            try
            {
                IEnumerable<DadosPessoais> dadosPessoaisLista = await _instance.ConsultarTodos(paginacaoInicial);
                return responseObjectLista.SetSuccess(true).SetResponseObjDadosPessoaisList(dadosPessoaisLista.ToList()).SetMessage(dadosPessoaisLista.ToList().Count() == 0 ? "Pesquisa não retornou resultados" : "").Build();
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
                DadosPessoais dadosPessoais = await _instance.ConsultarPorId(id);
                return responseObject.SetSuccess(true).SetResponseObjDadosPessoais(dadosPessoais).Build();
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
                DadosPessoais dadosPessoais = await _instance.ConsultarPorCpf(cpf);
                return responseObject.SetSuccess(true).SetResponseObjDadosPessoais(dadosPessoais).SetMessage(dadosPessoais == null? "Pesquisa não retornou resultados" : "").Build();
            }
            catch (Exception ex)
            {
                return responseObject.SetSuccess(false).SetMessage("Erro ao consultar funcionário por cpf. " + ex.Message).Build();
            }
        }
    }
}