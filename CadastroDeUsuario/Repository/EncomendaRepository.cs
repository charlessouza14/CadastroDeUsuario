using CadastroDeUsuario.Data;
using CadastroDeUsuario.Interfaces;
using CadastroDeUsuario.Models;
using Microsoft.EntityFrameworkCore;

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

        public async Task<IEnumerable<Encomenda>> Listar()
        {
            var buscar = await _context.Encomenda.ToListAsync<Encomenda>();
            return buscar;
        }
    }
}
