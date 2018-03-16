using Microsoft.EntityFrameworkCore;

namespace EstudioAC.Model
{
    public class EacContexto : DbContext
    {
        public EacContexto(DbContextOptions<EacContexto> options)
            : base(options)
        { }
        public DbSet<Servico> Servico { get; set; }
    }
}