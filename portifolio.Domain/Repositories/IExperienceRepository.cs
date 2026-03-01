using portifolio.Domain.Entities;

namespace portifolio.Domain.Repositories;

public interface IExperienceRepository
{
    Task<List<Experience>> GetAllAsync(CancellationToken cancellationToken);
}