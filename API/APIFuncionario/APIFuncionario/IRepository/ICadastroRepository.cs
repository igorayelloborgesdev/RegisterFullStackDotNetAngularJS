using APIFuncionario.IModels;
using APIFuncionario.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIFuncionario.IRepository
{
    public interface ICadastroRepository
    {
        Task Cadastrar();
        Task Alterar();
        Task Excluir(string cpf);
        Task<IEnumerable<DadosPessoais>> ConsultarTodos(int paginacaoInicial);
        Task<DadosPessoais> ConsultarPorId(int id);
        Task<DadosPessoais> ConsultarPorCpf(string cpf);
    }
}
