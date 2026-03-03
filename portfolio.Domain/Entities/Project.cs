namespace portfolio.Domain.Entities;

public class Project
{
    public Guid Id { get; private set; }
    public string Name { get; private set; }
    public string Description { get; private set; }
    public string RepositoryUrl { get; private set; }
    public string? DemoUrl { get; private set; }
    public DateTime CreatedAt { get; private set; }

    private Project() { }

    public Project(
        string name,
        string description,
        string repositoryUrl,
        string? demoUrl)
    {
        Id = Guid.NewGuid();
        Name = name;
        Description = description;
        RepositoryUrl = repositoryUrl;
        DemoUrl = demoUrl;
        CreatedAt = DateTime.UtcNow;
    }

    public void Update(
        string name,
        string description,
        string repositoryUrl,
        string? demoUrl)
    {
        Name = name;
        Description = description;
        RepositoryUrl = repositoryUrl;
        DemoUrl = demoUrl;
    }
}