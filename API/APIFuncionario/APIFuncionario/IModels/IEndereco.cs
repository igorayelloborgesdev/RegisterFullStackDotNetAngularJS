using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIFuncionario.IModels
{
    interface IEndereco
    {
        int Id { get; set; }
        string Logradouro { get; set; }
        string Numero { get; set; }
        string Cidade { get; set; }
        string Cep { get; set; }
        string Complemento { get; set; }
        string Estado { get; set; }
    }
}
