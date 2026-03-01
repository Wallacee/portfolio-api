using portifolio.Domain.Entities;

namespace portifolio.Domain.Repositories;

public interface ISkillRepository
{
    Task<List<Skill>> GetAllAsync(CancellationToken cancellationToken);
}