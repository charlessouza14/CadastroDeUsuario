using CadastroDeUsuario.Data;
using CadastroDeUsuario.Models;
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
        public UsuarioController(UsuarioContext context)
        {
            _context = context;            
        }

        [HttpPost]

        public IActionResult AdicionaUsuario([FromBody] Usuario usuario)
        {
            _context.Usuarios.Add(usuario);
            _context.SaveChanges();
            return Ok(usuario);
        }

        [HttpGet]

        public IEnumerable<Usuario> ListarUsuario([FromQuery] int skip = 0, [FromQuery] int take = 50)
        {
            return _context.Usuarios.ToList<Usuario>();
        }

        [HttpGet("{id}")]

        public IActionResult ListarUsuarioPorId (int id)
        {
            if(id == null)
            {
                return BadRequest();
            }
            var usuario = _context.Usuarios.FirstOrDefault(usario => usario.Id == id);

            return Ok(usuario);
        }

        [HttpPut("{id}")]

        public IActionResult AtualizaUsuarioPorId([FromBody]int id)
        {
            if(id == null) 
            { 
                return NotFound();
            }
            var usuario = _context.Usuarios.FirstOrDefault(usuario => usuario.Id == id);           
            _context.Usuarios.Update(usuario);
            _context.SaveChanges();
            return NoContent();
        }

        [HttpDelete("{id}")]

        public IActionResult RemoverUsuario(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usuario = _context.Usuarios.FirstOrDefault( usuario => usuario.Id == id);
            _context.Remove(usuario);
            _context.SaveChanges();
            return NoContent();

        }



    }
}
