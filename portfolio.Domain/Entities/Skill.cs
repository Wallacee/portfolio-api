using portfolio.Domain.Enums;
using portfolio.Domain.Exceptions;

namespace portfolio.Domain.Entities;

public class Skill
{
    public Guid Id { get; private set; }
    public string Name { get; private set; }
    public SkillCategory Category { get; private set; }
    public int Level { get; private set; }
    public Guid ExperienceId { get; private set; }
    public Experience Experience { get; private set; }

    private Skill() { }

    public Skill(string name, SkillCategory category, int level, Guid experienceId)
    {
        if (level < 1 || level > 5)
            throw new DomainException("Level must be between 1 and 5");

        Id = Guid.NewGuid();
        Name = name;
        Category = category;
        Level = level;
        ExperienceId = experienceId;
    }

    public void UpdateLevel(int level)
    {
        if (level < 1 || level > 5)
            throw new DomainException("Level must be between 1 and 5");

        Level = level;
    }
}