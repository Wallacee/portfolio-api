using portfolio.Domain.Entities;
using portfolio.Domain.Interfaces;

namespace portfolio.Infrastructure.Persistence.Repositories
{
    public class ProjectRepository(PortfolioDbContext context) : Repository<Project>(context), IProjectRepository
    {
        private readonly PortfolioDbContext _context = context;

    }
}
