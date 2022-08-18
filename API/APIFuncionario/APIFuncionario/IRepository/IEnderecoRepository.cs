using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIFuncionario.IRepository
{
    public interface IEnderecoRepository
    {
        Task Incluir(string Logradouro, string Numero, string Cidade, string Cep, string Estado, int idIdentity, string Complemento = null);
        Task Alterar(string Logradouro, string Numero, string Cidade, string Cep, string Estado, int id, string Complemento = null);
    }
}
