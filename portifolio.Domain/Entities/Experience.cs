using portifolio.Domain.Exceptions;

namespace portifolio.Domain.Entities;

public class Experience
{
    public Guid Id { get; private set; }
    public string Company { get; private set; }
    public string Role { get; private set; }
    public DateTime StartDate { get; private set; }
    public DateTime? EndDate { get; private set; }
    public string Description { get; private set; }

    public Guid UserProfileId { get; private set; }

    private Experience() { }

    public Experience(
        string company,
        string role,
        DateTime startDate,
        DateTime? endDate,
        string description,
        Guid userProfileId)
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
    }

    public void Update(
        string company,
        string role,
        DateTime startDate,
        DateTime? endDate,
        string description)
    {
        if (endDate.HasValue && endDate < startDate)
            throw new DomainException("EndDate cannot be earlier than StartDate");

        Company = company;
        Role = role;
        StartDate = startDate;
        EndDate = endDate;
        Description = description;
    }
}