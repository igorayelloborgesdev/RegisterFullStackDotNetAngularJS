using APIFuncionario.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIFuncionario.IResponse
{
    interface IResponseObject<T>
    {
        string Message { get; set; }
        bool Success { get; set; }
        T responseObj { get; set; }
        IEnumerable<T> responseObjList { get; set; }
        IEnumerable<DadosPessoais> responseObjDadosPessoaisList { get; set; }
    }
}
