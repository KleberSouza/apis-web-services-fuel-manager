using apis_web_services_fuel_manager.Models;

namespace apis_web_services_fuel_manager.GraphQL
{
    public class Query
    {
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Usuario> Usuarios([Service] ApiDbContext _context)
        {
            return _context.Usuarios;
        }

        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Veiculo> Veiculos([Service] ApiDbContext _context)
        {
            return _context.Veiculos;
        }

        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Posto> Postos([Service] ApiDbContext _context)
        {
            return _context.Postos;
        }

        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Consumo> Consumos([Service] ApiDbContext _context)
        {
            return _context.Consumos;
        }
    }
}
