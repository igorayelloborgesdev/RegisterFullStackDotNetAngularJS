using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIFuncionario.IRepository
{
    public interface IDadosPessoaisRepository
    {
        Task<int> Incluir(string Nome_Completo, string Nome_Social, string RG, string CPF, string Data_Nascimento);
        Task Alterar(string Nome_Completo, string Nome_Social, string RG, string CPF, string Data_Nascimento, int id);
    }
}
