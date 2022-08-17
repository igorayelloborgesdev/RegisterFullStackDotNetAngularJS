using APIFuncionario.IModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APIFuncionario.Models
{
    public class Telefones : ITelefones
    {
        public int Id { get; set; }
        public string Ddd { get; set; }
        public string Celular { get; set; }
        public string Residencial { get; set; }
    }
}