using System.ComponentModel.DataAnnotations;

namespace CadastroContatos.Models
{
    public class ContatoModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="O nome do contato é de preenchimento obrigatório.")]
        public string Nome { get; set; }
        
        [Required(ErrorMessage = "O email do contato é de preenchimento obrigatório.")]
        [EmailAddress(ErrorMessage = "Formato inválido de email, verifique a informação.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O celular do contato é de preenchimento obrigatório.")]
        [Phone(ErrorMessage = "Formato inválido de telefone, informe o telefone completo com DDD.")]
        public string Celular { get; set; }
    }
}
