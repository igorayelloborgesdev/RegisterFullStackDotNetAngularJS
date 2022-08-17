using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIFuncionario.IModels
{
    interface ITelefones
    {
        int Id { get; set; }
        string Ddd { get; set; }
        string Celular { get; set; }
        string Residencial { get; set; }
    }
}
