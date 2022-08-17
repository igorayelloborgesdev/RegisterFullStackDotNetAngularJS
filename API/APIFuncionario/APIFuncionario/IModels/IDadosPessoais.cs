using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIFuncionario.IModels
{
    public interface IDadosPessoais
    {
        int Id { get; set; }
        string Nome_Completo { get; set; }
        string Nome_Social { get; set; }
        string RG { get; set; }
        string CPF { get; set; }
        string Data_Nascimento { get; set; }
        int Ativo { get; set; }
    }
}
