using CadastroDeUsuario.Data;
using CadastroDeUsuario.Interfaces;
using CadastroDeUsuario.Models;

namespace CadastroDeUsuario.Repository
{
    public class EncomendaRepository : IEncomendaRepository
    {
        private readonly UsuarioContext _context;

        public EncomendaRepository(UsuarioContext context)
        {
            _context = context;
        }
        public void Cadastrar(Encomenda encomenda)
        {
            _context.Add(encomenda);
            _context.SaveChanges();
        }
    }
}
