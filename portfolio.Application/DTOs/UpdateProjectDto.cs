namespace portfolio.Application.DTOs;

public record UpdateProjectDto(
    string Title,
    string Description,
    string RepositoryUrl
);