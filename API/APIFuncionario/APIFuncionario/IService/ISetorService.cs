using APIFuncionario.IModels;
using APIFuncionario.Models;
using APIFuncionario.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIFuncionario.IService
{
    public interface ISetorService
    {
        Task<ResponseObject<Setor>> ConsultarSetores();
    }
}
