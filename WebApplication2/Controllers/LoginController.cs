using System.Linq.Expressions;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Data.Repositorio.Interfaces;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class LoginController : Controller
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;
        public LoginController(IUsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ValidaUsuario(Usuario usuario)
        {
            var retorno = _usuarioRepositorio.ValidaUsuario(usuario);

            try
            {
                if (retorno != null )
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ViewBag.Mensagem = "Usuário ou senha inválidos";
                    return View("Index");
                }
            }
            catch (Exception ex)
            {
                TempData["MsgErro"] = "Erro ao buscar dados do Usuário";

            }
            return View("Index");
        }

        public IActionResult Cadastro()
        {
            return View();
        }
        public IActionResult CadastrarUsuario(Usuario usuario)
        {
            try
            {
               _usuarioRepositorio.CadastrarUsuario(usuario);
                return RedirectToAction("Index", "Login");
            }
            catch (Exception ex)
            {
                TempData["MsgErro"] = "Erro ao cadastrar o Usuário";
                return RedirectToAction("Cadastro", "Login");
            }
            return View("Index");
        }
    }
}
