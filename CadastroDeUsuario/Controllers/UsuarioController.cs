using CadastroDeUsuario.Data;
using CadastroDeUsuario.Models;
using Microsoft.AspNetCore.Mvc;

namespace CadastroDeUsuario.Controllers
{
    public class UsuarioController : ControllerBase
    {
        private UsuarioContext _context;

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
    }
}
