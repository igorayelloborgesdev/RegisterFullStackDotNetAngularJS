using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace APIFuncionario.Request
{
    public class RequestObject
    {
        [Required(ErrorMessage = "Campo Nome_Completo é obrigatório")]
        [StringLength(255)]
        public string Nome_Completo { get; set; }
        public string Nome_Social { get; set; }
        [Required(ErrorMessage = "Campo RG é obrigatório")]
        [StringLength(9, ErrorMessage = "RG deve ter no máximo 9 caracteres")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "RG Somente números")]
        public string RG { get; set; }
        [Required(ErrorMessage = "Campo CPF é obrigatório")]
        [StringLength(11, ErrorMessage = "CPF deve ter no máximo 11 caracteres")]        
        [RegularExpression("^[0-9]*$", ErrorMessage = "CPF Somente números")]
        public string CPF { get; set; }
        [Required(ErrorMessage = "Campo Data_Nascimento é obrigatório")]
        [DataType(DataType.Date, ErrorMessage = "Data inválida")]
        public DateTime Data_Nascimento { get; set; }
        [Required(ErrorMessage = "Campo Descricao é obrigatório")]
        [StringLength(255)]
        public string Descricao { get; set; }
        [Required(ErrorMessage = "Campo Salario é obrigatório")]
        public decimal Salario { get; set; }
        [Required(ErrorMessage = "Campo Data_Inicio é obrigatório")]
        [DataType(DataType.Date, ErrorMessage = "Data inválida")]
        public DateTime Data_Inicio { get; set; }
        public string Data_Encerramento { get; set; }
        [Required(ErrorMessage = "Campo setor é obrigatório")]        
        public int setor { get; set; }
        [Required(ErrorMessage = "Campo Logradouro é obrigatório")]
        [StringLength(255)]
        public string Logradouro { get; set; }
        [Required(ErrorMessage = "Campo Numero é obrigatório")]
        [StringLength(10, ErrorMessage = "Número deve ter no máximo 10 caracteres")]        
        [RegularExpression("^[0-9]*$", ErrorMessage = "Número da residência Somente números")]
        public string Numero { get; set; }
        [Required(ErrorMessage = "Campo Cidade é obrigatório")]
        [StringLength(255)]
        public string Cidade { get; set; }
        [Required(ErrorMessage = "Campo Cep é obrigatório")]
        [StringLength(8, ErrorMessage = "CEP deve ter no máximo 8 caracteres")]        
        [RegularExpression("^[0-9]*$", ErrorMessage = "CEP Somente números")]
        public string Cep { get; set; }
        public string Complemento { get; set; }
        [Required(ErrorMessage = "Campo Estado é obrigatório")]
        [StringLength(2, ErrorMessage = "Estado deve ter no máximo 2 caracteres")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Somente letras na sigla do estado")]
        public string Estado { get; set; }
        [Required(ErrorMessage = "Campo Ddd é obrigatório")]
        [StringLength(2, ErrorMessage = "DDD deve ter no máximo 2 caracteres")]       
        [RegularExpression("^[0-9]*$", ErrorMessage = "DDD Somente números")]
        public string Ddd { get; set; }
        [Required(ErrorMessage = "Campo Celular é obrigatório")]
        [StringLength(9, MinimumLength = 8, ErrorMessage = "Campo celular deve ter entre 8 ou 9 caracteres")]        
        [RegularExpression("^[0-9]*$", ErrorMessage = "Celular Somente números")]
        public string Celular { get; set; }
        [StringLength(8, ErrorMessage = "Campo residencial deve ter entre 8 caracteres")]        
        [RegularExpression("^[0-9]*$", ErrorMessage = "Residencial Somente números")]
        public string Residencial { get; set; }
    }
}