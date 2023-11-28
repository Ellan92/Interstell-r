namespace Interstellär.Data
{
    public class InterstellärUnitOfWork
    {
        private readonly InterstellärDbContext _context;

        public InterstellärUnitOfWork(InterstellärDbContext context)
        {
            _context = context;

            PlanetRepository = new(context);
            VisitRepository = new(context);
        }
        public PlanetRepository PlanetRepository { get; }
        public VisitRepository VisitRepository { get; }
        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
