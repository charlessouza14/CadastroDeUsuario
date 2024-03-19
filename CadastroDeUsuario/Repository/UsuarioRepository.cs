using CadastroDeUsuario.Data;
using CadastroDeUsuario.Interfaces;
using CadastroDeUsuario.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
            var atualizar = _context.Usuarios.FirstOrDefault(u => u.Id == usuario.Id);
            atualizar.Senha = usuario.Senha;
            atualizar.Email = usuario.Email;
            atualizar.Nome = usuario.Nome;
            _context.Usuarios.Update(atualizar);
            _context.SaveChanges();
        }

        public async Task<Usuario> BuscarPorId(int id)
        {
            throw new NotImplementedException();

            //var usuario = await _context.Usuarios.FirstOrDefaultAsync(usario => usario.Id == id);
            //return usuario;
        }

        public Task<IEnumerable<Usuario>> BuscarUsuario()
        {
            throw new NotImplementedException();
        }

        public void Deletar(int id)
        {
            var usuario = _context.Usuarios.FirstOrDefault(usuario => usuario.Id == id);
            _context.Remove(usuario);
            _context.SaveChanges();
        }
    }

}  
