using System.ComponentModel.DataAnnotations;

namespace CadastroDeUsuario.Models
{
    public class Usuario
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage ="Este campo é obrigatório, por favor digite seu nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório, por favor digite seu e-mail")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório, por favor digite sua senha")]
        public string Senha { get; set; }
        public DateTime DataCadastro { get; set; } = DateTime.Now;
    }
}
