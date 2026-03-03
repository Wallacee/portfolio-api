namespace portfolio.Application.DTOs.Project;

public record UpdateProjectDto(
    string Title,
    string Description,
    string RepositoryUrl
);