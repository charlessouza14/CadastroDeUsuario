using CadastroDeUsuario.Data;
using CadastroDeUsuario.Interfaces;
using CadastroDeUsuario.Models;
using CadastroDeUsuario.Repository;
using Microsoft.AspNetCore.Http.HttpResults;
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
        private readonly IUsuarioRepository _repository;
        public UsuarioController(UsuarioContext context, IUsuarioRepository repository)
        {
            _context = context;
            _repository = repository;
        }
       
        [HttpPost]
        public IActionResult AdicionaUsuario([FromBody] Usuario usuario)
        {

            _repository.Adicionar(usuario);
            return Ok("Criado com sucesso");

        }

        [HttpGet]

        public Task<IEnumerable<Usuario>> ListarUsuario ([FromQuery] int skip = 0, [FromQuery] int take = 50)
        {
            return _repository.BuscarUsuario();            
        }

        [HttpGet("{id}")]

        public Task<Usuario> ListarUsuarioPorId ([FromQuery] int id)
        {
            if(id <= 0)
            {
                BadRequest("Id inválido!");
            }

           return  _repository.BuscarPorId(id);
        }

        [HttpPut("{id}")]

        public IActionResult AtualizaUsuarioPorId([FromBody] Usuario usuario)
        {
            _repository.Atualizar(usuario);
            return Ok(usuario);
        }

        [HttpDelete("{id}")]

        public IActionResult RemoverUsuario([FromQuery] int id)
        {
            if (id <= 0)
            {
                return BadRequest("Id inválido!");
            }
            
            _repository.Deletar(id);
            return Ok("Deletado com sucesso");
        }



    }
}
