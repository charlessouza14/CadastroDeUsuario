using CadastroDeUsuario.Data;
using CadastroDeUsuario.Models;
using CadastroDeUsuario.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;

namespace CadastroDeUsuario.Controllers
{
    [ApiController]
    [Microsoft.AspNetCore.Mvc.Route("[Controller]")]
    public class UsuarioController : ControllerBase
    {

        private readonly UsuarioContext _context;
        private readonly UsuarioRepository _repository;
        UsuarioController(UsuarioContext context, UsuarioRepository repository)
        {
            _context = context;
            _repository = repository;
        }

        [HttpPost]
        public IActionResult AdicionaUsuario([FromBody] Usuario usuario)
        {

            _repository.Adicionar(usuario);
            return Ok(usuario);

            //_context.Usuarios.Add(usuario);
            //_context.SaveChanges();
            //return Ok(usuario);
        }

        [HttpGet]

        public IEnumerable<Usuario> ListarUsuario([FromQuery] int skip = 0, [FromQuery] int take = 50)
        {           
             return _context.Usuarios.ToList<Usuario>();
        }

        [HttpGet("{id}")]

        public IActionResult ListarUsuarioPorId ([FromQuery] int id)
        {
            if(id <= 0)
            {
                return BadRequest("Id inválido!");
            }
            var usuario = _context.Usuarios.FirstOrDefault(usario => usario.Id == id);

            return Ok(usuario);
        }

        [HttpPut("{id}")]

        public IActionResult AtualizaUsuarioPorId([FromBody] Usuario usuario)
        {
           
            var atualizar = _context.Usuarios.FirstOrDefault( u => u.Id == usuario.Id );
            atualizar.Senha = usuario.Senha;
            atualizar.Email = usuario.Email;
            atualizar.Nome = usuario.Nome;
            _context.Usuarios.Update(atualizar);
            _context.SaveChanges();
            return Ok(atualizar);
        }

        [HttpDelete("{id}")]

        public IActionResult RemoverUsuario([FromQuery] int id)
        {
            if (id <= 0)
            {
                return BadRequest("Id inválido!");
            }

            var usuario = _context.Usuarios.FirstOrDefault( usuario => usuario.Id == id);
            _context.Remove(usuario);
            _context.SaveChanges();
            return Ok(usuario);

        }



    }
}
