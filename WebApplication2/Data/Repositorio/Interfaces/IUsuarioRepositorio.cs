using WebApplication2.Models;

namespace WebApplication2.Data.Repositorio.Interfaces
{
    public interface IUsuarioRepositorio
    { 
        public void CadastrarUsuario(Usuario usuario);

        public Usuario ValidaUsuario(Usuario usuario);
    }
}
