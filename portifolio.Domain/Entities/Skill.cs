using portifolio.Domain.Enums;
using portifolio.Domain.Exceptions;

namespace portifolio.Domain.Entities;

public class Skill
{
    public Guid Id { get; private set; }
    public string Name { get; private set; }
    public SkillCategory Category { get; private set; }
    public int Level { get; private set; }

    private Skill() { }

    public Skill(string name, SkillCategory category, int level)
    {
        if (level < 1 || level > 5)
            throw new DomainException("Level must be between 1 and 5");

        Id = Guid.NewGuid();
        Name = name;
        Category = category;
        Level = level;
    }

    public void UpdateLevel(int level)
    {
        if (level < 1 || level > 5)
            throw new DomainException("Level must be between 1 and 5");

        Level = level;
    }
}