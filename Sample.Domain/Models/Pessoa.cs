namespace Sample.Domain.Models
{
    public class Pessoa : BaseModel
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public int Idade { get; set; }
    }
}
