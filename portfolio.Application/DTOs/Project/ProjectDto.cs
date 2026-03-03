namespace portfolio.Application.DTOs.Project;

public record ProjectDto(
    Guid Id,
    string Name,
    string Description,
    DateTime CreatedAt
);