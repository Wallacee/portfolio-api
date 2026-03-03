namespace portfolio.Application.DTOs;

public record CreateProjectDto(
    string Name,
    string Description,
    string RepositoryUrl,
    string? DemoUrl
);