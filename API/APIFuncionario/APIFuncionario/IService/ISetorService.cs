using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIFuncionario.IService
{
    public interface ISetorService
    {
        Task<IEnumerable<T>> ConsultarSetores<T>();
    }
}
