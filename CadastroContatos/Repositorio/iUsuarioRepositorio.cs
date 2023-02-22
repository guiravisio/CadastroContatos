using CadastroContatos.Models;

namespace CadastroContatos.Repositorio
{
    public interface IUsuarioRepositorio
    {
        UsuarioModel BuscarPorLogin(string login);
        
        UsuarioModel ListarPorId(int id);
        List<UsuarioModel> BuscarTodos();
        UsuarioModel Adicionar(UsuarioModel contato);

        UsuarioModel Atualizar(UsuarioModel contato);

        bool Apagar(int id);
    }
}
