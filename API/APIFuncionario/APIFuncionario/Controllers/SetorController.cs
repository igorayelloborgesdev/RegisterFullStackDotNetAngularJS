using APIFuncionario.IModels;
using APIFuncionario.IService;
using APIFuncionario.Models;
using APIFuncionario.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace APIFuncionario.Controllers
{
    public class SetorController : ApiController
    {
        private static ISetorService _instance;
        public static ISetorService GetInstance()
        {
            if (_instance == null)
            {
                _instance = new SetorService();
            }
            return _instance;
        }

        public SetorController()
        {
            GetInstance();
        }

        public IEnumerable<ISetor> GetAllSetor()
        {            
            return (IEnumerable<ISetor>)_instance.ConsultarSetores<IEnumerable<ISetor>>();
        }
    }
}
