using CadastroContatos.Enums;
using System.ComponentModel.DataAnnotations;

namespace CadastroContatos.Models
{
    public class UsuarioModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome do usuário é de preenchimento obrigatório.")]
        public string Nome { get; set; }


        [Required(ErrorMessage = "O login do usuário é de preenchimento obrigatório.")]
        public string Login { get; set; }


        [Required(ErrorMessage = "O email do usuário é de preenchimento obrigatório.")]
        [EmailAddress(ErrorMessage = "Formato inválido de email, verifique a informação.")]
        public string Email { get; set; }

        public PerfilEnum Perfil { get; set; }

        [Required(ErrorMessage = "A senha do usuário é de preenchimento obrigatório.")]
        public string Senha { get; set; }

        public DateTime DataCadastro { get; set; }

        public DateTime? DataAlteracao { get; set; }
    }
}
