using CadastroDeUsuario.Data;
using CadastroDeUsuario.Interfaces;
using CadastroDeUsuario.Models;
using Microsoft.AspNetCore.Mvc;

namespace CadastroDeUsuario.Controllers
{
    [ApiController]
    [Microsoft.AspNetCore.Mvc.Route("[Controller]")]
    public class EncomendaController : ControllerBase
    {
        private readonly UsuarioContext _context;
        private readonly IEncomendaRepository _repository;

        public EncomendaController(UsuarioContext context, IEncomendaRepository repository)
        {
           _context = context;
            _repository = repository;
        }

        [HttpPost]

        public IActionResult CadastrarEncomenda([FromBody] Encomenda encomenda)
        {
            _repository.Cadastrar(encomenda);
            return Ok("Encomenda cadastrada com Sucesso!");

        }

        [HttpGet]
        public Task<IEnumerable<Encomenda>> ListarEncomenda([FromQuery] int skip = 0, [FromQuery] int take = 50)
        {
            return _repository.Listar();
        }


    }
}
