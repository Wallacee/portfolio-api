using AutoMapper;
using portfolio.Application.DTOs.UserProfile;
using portfolio.Application.Interfaces;
using portfolio.Domain.Interfaces;

namespace portfolio.Application.Services
{
    public class UserProfileService(IMapper mapper, IUserProfileRepository userProfileRepository) : IUserProfileService
    {
        private readonly IMapper _mapper = mapper;

        private readonly IUserProfileRepository _userProfileRepository = userProfileRepository;
        public async Task<UserProfileDto> GetByIdAsync(Guid id)
        {
            var userProfile = await _userProfileRepository.GetByIdAsync(id);
            
            return _mapper.Map<UserProfileDto>(userProfile);
        }
    }
}
