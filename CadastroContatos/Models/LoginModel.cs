using System.ComponentModel.DataAnnotations;

namespace CadastroContatos.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Informe o login do usuário para continuar")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Digite sua senha")]
        public string Senha { get; set; }
    }
}
