using APIFuncionario.IModels;
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
        Task<IEnumerable<IDadosPessoais>> ConsultarTodos(int paginacaoInicial);
        Task<IDadosPessoais> ConsultarPorId(int id);
        Task<IDadosPessoais> ConsultarPorCpf(string cpf);
    }
}
