using CadastroDeUsuario.Models;

namespace CadastroDeUsuario.Interfaces
{
    public interface IEncomendaRepository
    {
        void Cadastrar(Encomenda encomenda);

        Task<IEnumerable<Encomenda>> Listar();
    }
}
