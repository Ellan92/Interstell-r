using Interstellär.Models;

namespace Interstellär.Data
{
    public class VisitRepository
    {
        public readonly InterstellärDbContext _context;

        public VisitRepository(InterstellärDbContext context)
        {
            _context = context;
        }

        public List<VisitModel> GetAll()
        {
            return _context.Visits.ToList();

        }

        public VisitModel? GetById(int id)
        {
            return _context.Visits.FirstOrDefault(p => p.VisitId == id);
        }

        public void Add(VisitModel visitModel)
        {
            _context.Visits.Add(visitModel);
        }

        public void Update(int id, VisitModel visitModel)
        {
            VisitModel? visitToUpdate = GetById(id);

            if (visitToUpdate != null)
            {
                visitToUpdate.Date = visitModel.Date;
                visitToUpdate.PlanetId = visitModel.PlanetId;
            }
        }

        public void Delete(int id)
        {
            VisitModel? visitToDelete = GetById(id);

            if (visitToDelete != null)
            {
                _context.Visits.Remove(visitToDelete);
            }
        }

        public void Complete()
        {
            _context.SaveChanges();
            //_context.Dispose();
        }
    }
}
