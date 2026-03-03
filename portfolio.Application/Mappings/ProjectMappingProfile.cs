using AutoMapper;
using portfolio.Application.DTOs.Project;
using portfolio.Domain.Entities;

namespace portfolio.Application.Mappings;

public class ProjectMappingProfile : Profile
{
    public ProjectMappingProfile()
    {
        CreateMap<Project, ProjectDto>();

        CreateMap<CreateProjectDto, Project>(MemberList.Source).ConstructUsing(dto =>
                new Project(
                    dto.Name,
                    dto.Description,
                    dto.RepositoryUrl,
                    dto.DemoUrl
                ));
    }
}