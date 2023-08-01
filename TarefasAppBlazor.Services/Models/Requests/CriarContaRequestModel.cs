using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarefasAppBlazor.Services.Models.Requests
{
    /// <summary>
    /// Modelo de dados para a requisição de criação de conta de usuários
    /// </summary>
    public class CriarContaRequestModel
    {
        [DataType(DataType.Text)]
        [Display(Name = "Entre com o seu nome:", Prompt = "Ex: João da Silva")]
        [MinLength(8, ErrorMessage = "Por favor, informe no mínimo 8 caracteres.")]
        [Required(ErrorMessage = "Por favor, informe o seu nome.")]
        public string? Nome { get; set; }

        [DataType(DataType.EmailAddress)]
        [Display(Name = "Entre com o seu email:", Prompt = "Ex: joaodasilva@gmail.com")]
        [EmailAddress(ErrorMessage = "Por favor, informe um endereço de email válido.")]
        [Required(ErrorMessage = "Por favor, informe seu email de acesso.")]
        public string? Email { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Entre com a sua senha:")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$", 
            ErrorMessage = "Por favor, informe uma senha forte (letras maiúsculas, letras minúsculas, números, símbolos e pelo menos 8 caracteres).")]
        [Required(ErrorMessage = "Por favor, informe sua senha de acesso.")]
        public string? Senha { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirme a sua senha:")]
        //[Compare("Senha", ErrorMessage = "Senhas não conferem.")]
        [Required(ErrorMessage = "Por favor, confirme sua senha de acesso.")]
        public string? SenhaConfirmacao { get; set; }
    }
}
