namespace portfolio.Application.DTOs.UserProfile;
public record UserProfileDto(Guid? Id,
                             string FullName,
                             string Headline,
                             string About,
                             string GithubUrl,
                             string LinkedinUrl,
                             string PhotoUrl,
                             Guid UserId);


