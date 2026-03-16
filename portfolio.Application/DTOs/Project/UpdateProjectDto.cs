namespace portfolio.Application.DTOs.Project;

public class UpdateProjectDto
{
    public Guid Id { get; set; }
    public string Name { get; set; } = null!;
    public string Description { get; set; } = null!;
    public string RepositoryUrl { get; set; } = null!;
    public string? DemoUrl { get; set; }
}