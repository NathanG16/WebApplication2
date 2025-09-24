using WebApplication2.Data.Repositorio.Interfaces;
using WebApplication2.Models;

namespace WebApplication2.Data.Repositorio
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {

        private readonly BancoContexto _bancoContexto;

        public UsuarioRepositorio(BancoContexto bancoContexto)
        {
            _bancoContexto = bancoContexto;
        }

        public void CadastrarUsuario(Usuario usuario)
        {
            _bancoContexto.Usuario.Add(usuario);
            _bancoContexto.SaveChanges();
        }
        public Usuario ValidaUsuario(Usuario usuario)
        {
            return _bancoContexto.Usuario.FirstOrDefault(u => u.Email == usuario.Email && u.Senha == usuario.Senha);
        }
    }
}
