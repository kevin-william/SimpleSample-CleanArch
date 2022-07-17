using Microsoft.EntityFrameworkCore;
using Sample.Infra.Data.Entities;

namespace Sample.Infra.Data.Contexts
{
    public class OracleSampleContext : DbContext
    {
        public OracleSampleContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<PessoaEntity> Pessoa { get; set; }

    }
}
