using CadastroDeUsuario.Data;
using CadastroDeUsuario.Interfaces;
using CadastroDeUsuario.Models;
using Microsoft.AspNetCore.Mvc;

namespace CadastroDeUsuario.Controllers
{
    [ApiController]
    [Microsoft.AspNetCore.Mvc.Route("[Controller]")]
    public class LoginController : ControllerBase
    {
        private readonly UsuarioContext _context;
        private readonly ILoginRepository _repository;

        public LoginController(UsuarioContext context, ILoginRepository repository)
        {
            _context = context;
            _repository = repository;
        }

        [HttpGet]
        public Task<Usuario> Buscar([FromBody] Login login)
        {
            var buscar = _repository.BuscarUsuario(login);
            return buscar;  
        }


    }
}
