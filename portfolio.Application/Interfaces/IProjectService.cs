using portfolio.Application.DTOs.Project;

namespace portfolio.Application.Interfaces
{
    public interface IProjectService
    {
        Task<IEnumerable<ProjectDto>> GetAllAsync();

        Task<ProjectDto> CreateAsync(CreateProjectDto dto);

        Task<ProjectDto> GetByIdAsync(Guid id);

    }
}
