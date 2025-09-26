using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    public class AlunoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CadastrarAluno()
        {
            return View();
        }
    }
}
