using portfolio.Domain.Exceptions;

namespace portfolio.Domain.Entities;

public class Experience
{
    public Guid Id { get; private set; }
    public string Company { get; private set; }
    public string Role { get; private set; }
    public DateTime StartDate { get; private set; }
    public DateTime? EndDate { get; private set; }
    public string Description { get; private set; }
    public List<Skill> Skills { get; private set; } = null!;
    public Guid UserProfileId { get; private set; }
    public UserProfile? UserProfile { get; private set; }

    private Experience() { }

    public Experience(
        string company,
        string role,
        DateTime startDate,
        DateTime? endDate,
        string description,
        Guid userProfileId,
        List<Skill> skills)
    {
        if (endDate.HasValue && endDate < startDate)
            throw new DomainException("EndDate cannot be earlier than StartDate");

        Id = Guid.NewGuid();
        Company = company;
        Role = role;
        StartDate = startDate;
        EndDate = endDate;
        Description = description;
        UserProfileId = userProfileId;
        Skills = skills;
    }

    public void Update(
        string company,
        string role,
        DateTime startDate,
        DateTime? endDate,
        string description,
        List<Skill> skills)
    {
        if (endDate.HasValue && endDate < startDate)
            throw new DomainException("EndDate cannot be earlier than StartDate");

        Company = company;
        Role = role;
        StartDate = startDate;
        EndDate = endDate;
        Description = description;
        Skills = skills;
    }
}