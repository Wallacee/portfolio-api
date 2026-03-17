using portfolio.Application.DTOs.UserProfile;

namespace portfolio.Application.Interfaces
{
    public interface IUserProfileService
    {
        Task<UserProfileDto> GetByIdAsync(Guid id);
    }
}
