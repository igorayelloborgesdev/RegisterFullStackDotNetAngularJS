using APIFuncionario.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIFuncionario.IRepository
{
    public interface ISetorRepository
    {
         Task<IEnumerable<Setor>> ConsultarSetores();
    }
}
