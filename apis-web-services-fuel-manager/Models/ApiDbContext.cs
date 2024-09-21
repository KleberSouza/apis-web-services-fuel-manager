using Microsoft.EntityFrameworkCore;

namespace apis_web_services_fuel_manager.Models
{
    public class ApiDbContext: DbContext
    {
        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options) { }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Veiculo> Veiculos { get; set; }
        public DbSet<Posto> Postos { get; set; }
        public DbSet<Consumo> Consumos { get; set; }        
    }    
}
