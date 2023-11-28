using Interstellär.Models;
using Microsoft.EntityFrameworkCore;

namespace Interstellär.Data
{
    public class PlanetRepository
    {
        public readonly InterstellärDbContext _context;
        public PlanetRepository(InterstellärDbContext context)
        {
            _context = context;
        }

        public async Task<List<PlanetModel>> GetAllAsync()
        {
            return await _context.Planets.ToListAsync();

        }

        public PlanetModel? GetById(int id)
        {
            return _context.Planets.FirstOrDefault(p => p.PlanetId == id);
        }

        public void Add(PlanetModel planetModel)
        {
            _context.Planets.Add(planetModel);
        }

        public void Update(int id, PlanetModel planetModel)
        {
            PlanetModel? planetToUpdate = GetById(id);

            if (planetToUpdate != null)
            {
                planetToUpdate.Name = planetModel.Name;
                planetToUpdate.Description = planetModel.Description;
                planetToUpdate.DistanceFromEarth = planetModel.DistanceFromEarth;
            }
        }

        public void Delete(int id)
        {
            PlanetModel? planetToDelete = GetById(id);

            if (planetToDelete != null)
            {
                _context.Planets.Remove(planetToDelete);
            }
        }

        public void Complete()
        {
            _context.SaveChanges();
            //_context.Dispose();
        }
    }
}
