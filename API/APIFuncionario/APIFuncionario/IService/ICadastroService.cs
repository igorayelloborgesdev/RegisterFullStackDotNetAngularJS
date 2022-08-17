using APIFuncionario.IModels;
using APIFuncionario.Models;
using APIFuncionario.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIFuncionario.IService
{
    public interface ICadastroService
    {
        Task<ResponseObject<IDadosPessoais>> Cadastrar();//Retorna funcionário criado
        Task<ResponseObject<IDadosPessoais>> Alterar();//Retorna funcionário alterado
        Task<ResponseObject<int>> Excluir(string cpf);//Retorna id do usuário excluído
        Task<ResponseObject<IEnumerable<IDadosPessoais>>> ConsultarTodos(int paginacaoInicial);//Retorna lista paginada de funcionários
        Task<ResponseObject<IDadosPessoais>> ConsultarPorId(int id);//Retorna funcionário pesquisado por id
        Task<ResponseObject<IDadosPessoais>> ConsultarPorCpf(string cpf);//Retorna funcionário pesquisado por cpf
    }
}
