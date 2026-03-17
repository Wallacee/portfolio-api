namespace portfolio.Domain.Entities;

public class UserProfile
{
    public Guid Id { get; private set; }
    public string FullName { get; private set; }
    public string Headline { get; private set; }
    public string About { get; private set; }
    public string GithubUrl { get; private set; }
    public string LinkedinUrl { get; private set; }
    public string? PhotoUrl { get; private set; }
    public List<Experience> Experiences { get; private set; } = null!;
    public Guid UserId { get; private set; }
    public User User { get; private set; } = null!;
    public DateTime CreatedAt { get; private set; }

    private UserProfile() { } // EF

    public UserProfile(
        string fullName,
        string headline,
        string about,
        string githubUrl,
        string linkedinUrl,
        string? photoUrl,
        Guid userId)
    {
        Id = Guid.NewGuid();
        FullName = fullName;
        Headline = headline;
        About = about;
        GithubUrl = githubUrl;
        LinkedinUrl = linkedinUrl;
        PhotoUrl = photoUrl;
        CreatedAt = DateTime.UtcNow;
        UserId = userId;
    }

    public void UpdateProfile(
        string fullName,
        string headline,
        string about,
        string githubUrl,
        string linkedinUrl,
        string photoUrl)
    {
        FullName = fullName;
        Headline = headline;
        About = about;
        PhotoUrl = photoUrl;
        GithubUrl = githubUrl;
        LinkedinUrl = linkedinUrl;
    }
}