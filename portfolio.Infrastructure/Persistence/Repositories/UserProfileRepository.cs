using portfolio.Domain.Entities;
using portfolio.Domain.Interfaces;

namespace portfolio.Infrastructure.Persistence.Repositories
{
    public class UserProfileRepository(PortfolioDbContext context) : Repository<UserProfile>(context), IUserProfileRepository
    {
        private readonly PortfolioDbContext _context = context;
    }
}
