using CadastroDeUsuario.Data;
using CadastroDeUsuario.Interfaces;
using CadastroDeUsuario.Models;
using Microsoft.AspNetCore.Mvc;

namespace CadastroDeUsuario.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {

        private readonly UsuarioContext _context;
        UsuarioRepository(UsuarioContext context)
        {
            _context = context;
        }

        public void Adicionar(Usuario usuario)
        {
            _context.Usuarios.Add(usuario);
            _context.SaveChanges();
        }

        public void Atualizar(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public Task<Usuario> BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Usuario>> BuscarUsuario()
        {
            throw new NotImplementedException();
        }

        public void Deletar(int id)
        {
            throw new NotImplementedException();
        }
    }

}  
