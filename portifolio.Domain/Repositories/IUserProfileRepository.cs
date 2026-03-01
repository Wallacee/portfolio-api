using portifolio.Domain.Entities;

namespace portifolio.Domain.Repositories;

public interface IUserProfileRepository
{
    Task<UserProfile?> GetAsync(CancellationToken cancellationToken);
    Task AddAsync(UserProfile profile, CancellationToken cancellationToken);
    Task UpdateAsync(UserProfile profile, CancellationToken cancellationToken);
}