using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIFuncionario.IModels
{
    interface ISetor
    {
        int Id { get; set; }
        string Descricao { get; set; }
    }
}
