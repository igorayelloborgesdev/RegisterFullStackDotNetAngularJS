using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIFuncionario.IRepository
{
    public interface ICargoRepository
    {
        Task Incluir(string Descricao, decimal Salario, string Data_Inicio, int setor, int idIdentity, string Data_Encerramento = null);
        Task Alterar(string Descricao, decimal Salario, string Data_Inicio, int setor, int id, string Data_Encerramento = null);
    }
}
