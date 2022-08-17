using APIFuncionario.IModels;
using APIFuncionario.IRepository;
using APIFuncionario.IService;
using APIFuncionario.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace APIFuncionario.Service
{
    public class SetorService : ISetorService
    {
        private static ISetorRepository _instance;
        public static ISetorRepository GetInstance()
        {
            if (_instance == null)
            {
                _instance = new SetorRepository();
            }
            return _instance;
        }

        public SetorService()
        {
            GetInstance();
        }

        public async Task<IEnumerable<T>> ConsultarSetores<T>() 
        {
            try
            {
                return await _instance.ConsultarSetores<T>();
            }
            catch(Exception ex)
            {
                return default(IEnumerable<T>);
            }
            
        }
    }
}