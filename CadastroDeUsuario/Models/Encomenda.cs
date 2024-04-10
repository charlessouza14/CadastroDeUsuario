namespace CadastroDeUsuario.Models
{
    public class Encomenda
    {
        public int Id { get; set; }
        public string Recebedor { get; set; }
        public string Destinatario {  get; set; }
        public DateTime DataDoRecebimento { get; set; }

    }
}
