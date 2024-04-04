using CadastroDeUsuario.Data;
using CadastroDeUsuario.Models;

namespace CadastroDeUsuario.Interfaces
{

    public interface ILoginRepository
    {
        Task<Usuario> BuscarUsuario(Login usuario);
    }
}
