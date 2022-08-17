using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIFuncionario.IModels
{
    interface ICargo
    {
        int Id { get; set; }
        string Descricao { get; set; }
        decimal Salario { get; set; }
        string Data_Inicio { get; set; }
        string Data_Encerramento { get; set; }
        int setor { get; set; }
    }
}
