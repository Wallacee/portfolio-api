namespace portfolio.Application.DTOs.Project;

public record CreateProjectDto(
    string Name,
    string Description,
    string RepositoryUrl,
    string? DemoUrl
);