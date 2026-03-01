using portifolio.Domain.Entities;

namespace portifolio.Domain.Repositories;

public interface IProjectRepository
{
    Task<List<Project>> GetAllAsync(CancellationToken cancellationToken);
}