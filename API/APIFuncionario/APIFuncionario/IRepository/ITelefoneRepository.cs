using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIFuncionario.IRepository
{
    public interface ITelefoneRepository
    {
        Task Incluir(string Ddd, string Celular, int idIdentity, string Residencial = null);
        Task Alterar(string Ddd, string Celular, int id, string Residencial = null);
    }
}
