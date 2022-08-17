using APIFuncionario.IModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APIFuncionario.Models
{
    public class DadosPessoais : IDadosPessoais
    {
        public int Id { get; set; }
        public string Nome_Completo { get; set; }
        public string Nome_Social { get; set; }
        public string RG { get; set; }
        public string CPF { get; set; }
        public string Data_Nascimento { get; set; }
        public int Ativo { get; set; }
    }
}