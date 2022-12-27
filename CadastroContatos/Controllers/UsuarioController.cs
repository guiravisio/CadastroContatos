using Microsoft.AspNetCore.Mvc;

namespace CadastroContatos.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
