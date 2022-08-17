using APIFuncionario.IModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APIFuncionario.Models
{
    public class Endereco : IEndereco
    {
        public int Id { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Cidade { get; set; }
        public string Cep { get; set; }
        public string Complemento { get; set; }
        public string Estado { get; set; }
    }
}