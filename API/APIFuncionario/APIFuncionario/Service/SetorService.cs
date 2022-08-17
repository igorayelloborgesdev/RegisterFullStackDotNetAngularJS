using APIFuncionario.IModels;
using APIFuncionario.IRepository;
using APIFuncionario.IService;
using APIFuncionario.Models;
using APIFuncionario.Repository;
using APIFuncionario.Response;
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
        private ResponseObject<Setor> responseObject = new ResponseObject<Setor>();
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

        public async Task<ResponseObject<Setor>> ConsultarSetores() 
        {
            try
            {
                IEnumerable<Setor> setorList = await _instance.ConsultarSetores();                
                return responseObject.SetSuccess(true).SetResponseObjList(setorList).Build();
            }
            catch(Exception ex)
            {
                return responseObject.SetSuccess(false).SetMessage("Erro ao consultar setores. " + ex.Message).Build();
            }
            
        }
    }
}