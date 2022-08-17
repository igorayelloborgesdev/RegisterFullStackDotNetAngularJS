using APIFuncionario.IModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APIFuncionario.Models
{
    public class Setor : ISetor
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
    }
}