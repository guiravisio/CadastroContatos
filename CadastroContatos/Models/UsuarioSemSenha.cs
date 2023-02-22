using CadastroContatos.Enums;
using System.ComponentModel.DataAnnotations;

namespace CadastroContatos.Models
{
    public class UsuarioSemSenhaModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome do usuário é de preenchimento obrigatório.")]
        public string Nome { get; set; }


        [Required(ErrorMessage = "O login do usuário é de preenchimento obrigatório.")]
        public string Login { get; set; }


        [Required(ErrorMessage = "O email do usuário é de preenchimento obrigatório.")]
        [EmailAddress(ErrorMessage = "Formato inválido de email, verifique a informação.")]
        public string Email { get; set; }


        [Required(ErrorMessage = "O perfil do usuário é de preenchimento obrigatório.")]
        public PerfilEnum? Perfil { get; set; }

       
    }
}
