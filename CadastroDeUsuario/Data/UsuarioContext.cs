using CadastroDeUsuario.Models;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;

namespace CadastroDeUsuario.Data
{
    public class UsuarioContext : DbContext
    {
        public UsuarioContext(DbContextOptions<UsuarioContext> opts) : base(opts)
        {
            
        }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Encomenda> Encomenda { get; set; }

    }
}
