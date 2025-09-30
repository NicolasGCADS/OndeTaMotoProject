using Microsoft.EntityFrameworkCore;
using OndeTaMotoModel;

namespace OndeTaMotoData
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<MotoModel> Moto { get; set; }
        public DbSet<UsuarioModel> Usuario { get; set; }
        public DbSet<EstabelecimentoModel> Estabelecimento { get; set; }
        public DbSet<SetorModel> Setor { get; set; }
        public DbSet<DispositivoModel> Dispositivo { get; set; }
    }
}
