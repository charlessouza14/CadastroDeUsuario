namespace CadastroDeUsuario.Data
{
    public class ValidadorCPF
    {
        public string Numero { get; set; }

        public static bool Validar (string cpf)
        {
            bool cpfValido = true; 

            // verificar se o cpf tem 11 dígitos
            if(cpf.Length != 11)
            {
                cpfValido = false;
            }
            else
            {
                // verificar se todos os caracteres de cpf são dígitos numéricos
                for (int i = 0; i < cpf.Length; i++)
                {
                    if (!Char.IsDigit(cpf[i]))
                    {
                        cpfValido = false;
                        break;
                    }
                }
            }

            return cpfValido;
        }

    }
}
