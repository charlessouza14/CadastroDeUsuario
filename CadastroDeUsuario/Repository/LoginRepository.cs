using CadastroDeUsuario.Data;
using CadastroDeUsuario.Interfaces;
using CadastroDeUsuario.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CadastroDeUsuario.Repository
{
    public class LoginRepository : ILoginRepository
    {
        private readonly UsuarioContext _context;

        public LoginRepository(UsuarioContext context)
        {
            _context = context;
        }

        public async Task<Usuario>BuscarUsuario(Login usuario)
        {
            var buscar = await _context.Usuarios.FirstAsync(u => u.Email == usuario.Email && u.Senha == usuario.Senha);
            return buscar;
        }

        public void CriarConta(Usuario usuario)
        {
            _context.Usuarios.Add(usuario);
            _context.SaveChanges();
        }

       
    }
}
