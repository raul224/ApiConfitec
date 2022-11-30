using ApiConfitec.Core.DTO;

namespace ApiConfitec.Core.Entidades
{
    public class Usuario
    {
        private int Id { get; set; }
        private string Nome { get; set; }
        private string SobreNome { get; set; }
        private string Email { get; set; }
        private DateTime DataNascimento { get; set; }
        private Escolaridade Escolaridade { get; set; }
    }
}
