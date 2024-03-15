using CadastroDeUsuario.Models;

namespace CadastroDeUsuario.Interfaces
{
    public interface IUsuarioRepository
    {
        void Adicionar(Usuario usuario);
        void Atualizar(Usuario usuario);
        void Deletar(int id);
        
        Task<Usuario> BuscarPorId(int id);
        Task<IEnumerable<Usuario>> BuscarUsuario();

    }
}
