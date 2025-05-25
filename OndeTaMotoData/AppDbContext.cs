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

        public DbSet<MotoModel> Motos { get; set; }
        public DbSet<UsuarioModel> Usuarios { get; set; }
    }
}
