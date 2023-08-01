using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TarefasAppBlazor.Services.Models.Requests
{
    /// <summary>
    /// Modelo de dados para a requisição de recuperação de senha de usuários
    /// </summary>
    public class RecuperarSenhaRequestModel
    {
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Entre com o seu email:", Prompt = "Ex: joaodasilva@gmail.com")]
        [EmailAddress(ErrorMessage = "Por favor, informe um endereço de email válido.")]
        [Required(ErrorMessage = "Por favor, informe seu email de acesso.")]
        public string? Email { get; set; }
    }
}
