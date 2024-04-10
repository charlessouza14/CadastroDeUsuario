using CadastroDeUsuario.Data;
using CadastroDeUsuario.Models;

namespace CadastroDeUsuario.Interfaces
{

    public interface ILoginRepository
    {
        public void CriarConta(Usuario usuario);
        Task<Usuario> BuscarUsuario(Login usuario);

    }
}
