namespace portfolio.Domain.Entities;

public class UserProfile
{
    public Guid Id { get; private set; }
    public string FullName { get; private set; }
    public string Headline { get; private set; }
    public string About { get; private set; }
    public string GithubUrl { get; private set; }
    public string LinkedinUrl { get; private set; }
    public DateTime CreatedAt { get; private set; }

    private UserProfile() { } // EF

    public UserProfile(
        string fullName,
        string headline,
        string about,
        string githubUrl,
        string linkedinUrl)
    {
        Id = Guid.NewGuid();
        FullName = fullName;
        Headline = headline;
        About = about;
        GithubUrl = githubUrl;
        LinkedinUrl = linkedinUrl;
        CreatedAt = DateTime.UtcNow;
    }

    public void UpdateProfile(
        string fullName,
        string headline,
        string about,
        string githubUrl,
        string linkedinUrl)
    {
        FullName = fullName;
        Headline = headline;
        About = about;
        GithubUrl = githubUrl;
        LinkedinUrl = linkedinUrl;
    }
}