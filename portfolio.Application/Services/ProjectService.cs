using AutoMapper;
using portfolio.Application.DTOs.Project;
using portfolio.Application.Interfaces;
using portfolio.Domain.Entities;
using portfolio.Domain.Interfaces;

namespace portfolio.Application.Services;

public class ProjectService(IProjectRepository repository, IMapper mapper) : IProjectService
{
    private readonly IProjectRepository _repository = repository;

    private readonly IMapper _mapper = mapper;

    public async Task<IEnumerable<ProjectDto>> GetAllAsync()
    {
        var projects = await _repository.GetAllAsync();

        return _mapper.Map<IEnumerable<ProjectDto>>(projects);
    }

    public async Task<ProjectDto> CreateAsync(CreateProjectDto dto)
    {

        var project = _mapper.Map<Project>(dto);
        
        await _repository.AddAsync(project);

        return _mapper.Map<ProjectDto>(project);
    }

    public async Task<ProjectDto> GetByIdAsync(Guid id)
    {
        var project = await _repository.GetByIdAsync(id);

        return _mapper.Map<ProjectDto>(project);
    }

    public async Task<ProjectDto?> UpdateAsync(UpdateProjectDto dto)
    {
        var project = await _repository.GetByIdAsync(dto.Id);

        if (project is null)
            return null;

        project.Update(
            dto.Name,
            dto.Description,
            dto.RepositoryUrl,
            dto.DemoUrl
        );

        await _repository.UpdateAsync(project);

        return _mapper.Map<ProjectDto>(project);
    }
}