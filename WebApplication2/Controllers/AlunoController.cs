using Microsoft.AspNetCore.Mvc;
using WebApplication2.Data.Repositorio;
using WebApplication2.Data.Repositorio.Interfaces;

namespace WebApplication2.Controllers
{
    public class AlunoController : Controller
    {
        private readonly IAlunoRepositorio _alunoRepositorio;
        public AlunoController(IAlunoRepositorio alunoRepositorio)
        {
            _alunoRepositorio = alunoRepositorio;
        }
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