using CadastroContatos.Models;
using CadastroContatos.Repositorio;
using Microsoft.AspNetCore.Mvc;

namespace CadastroContatos.Controllers
{
    public class LoginController : Controller
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;
        
        public LoginController(IUsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio= usuarioRepositorio;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Entrar(LoginModel loginModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    UsuarioModel usuario = _usuarioRepositorio.BuscarPorLogin(loginModel.Login);

                    if(usuario != null)
                    {
                        if (usuario.SenhaValida(loginModel.Senha)) 
                        {
                            return RedirectToAction("Index", "Home");
                        }

                        TempData["MensagemErro"] = $"Senha inválida. Por favor, tente novamente.";

                    }

                    TempData["MensagemErro"] = $"Usuário e/ou senha inválido(os). Por favor, tente novamente.";
                }

                return View("Index");
            }
            catch (Exception erro) 
            {
                TempData["MensagemErro"] = $"Não foi possível realizar o login, tente novamente. {erro.Message}";
                return RedirectToAction("Index");
            }
        }
    }
}
