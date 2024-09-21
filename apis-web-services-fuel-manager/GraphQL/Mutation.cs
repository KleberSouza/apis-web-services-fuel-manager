using apis_web_services_fuel_manager.Models;

namespace apis_web_services_fuel_manager.GraphQL
{
    public class Mutation
    {
        public async Task<Veiculo> AddVeiculo([Service] ApiDbContext _context, Veiculo model)
        {
            _context.Veiculos.Add(model);
            await _context.SaveChangesAsync();

            return model;
        }

        public async Task<Veiculo> UpdateVeiculo([Service] ApiDbContext _context, Veiculo model)
        {
            _context.Veiculos.Update(model);
            await _context.SaveChangesAsync();

            return model;
        }

        public async Task<Veiculo> DeleteVeiculo([Service] ApiDbContext _context, int id)
        {
            var model = await _context.Veiculos.FindAsync(id);
            _context.Veiculos.Remove(model);
            await _context.SaveChangesAsync();

            return model;
        }
    }
}
