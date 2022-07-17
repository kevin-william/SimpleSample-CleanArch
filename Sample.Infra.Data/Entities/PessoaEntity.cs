using System.ComponentModel.DataAnnotations.Schema;

namespace Sample.Infra.Data.Entities
{
    [Table("USUARIO")]
    public class PessoaEntity : BaseEntity
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public int Idade { get; set; }
    }
}
