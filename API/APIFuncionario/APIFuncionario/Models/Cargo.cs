using APIFuncionario.IModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APIFuncionario.Models
{
    public class Cargo : ICargo
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public decimal Salario { get; set; }
        public string Data_Inicio { get; set; }
        public string Data_Encerramento { get; set; }
        public int setor { get; set; }
    }
}