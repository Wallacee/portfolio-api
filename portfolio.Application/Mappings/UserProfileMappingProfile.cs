using AutoMapper;
using portfolio.Application.DTOs.UserProfile;
using portfolio.Domain.Entities;

namespace portfolio.Application.Mappings
{
    public class UserProfileMappingProfile:Profile
    {
        public UserProfileMappingProfile()
        {
            CreateMap<UserProfile, UserProfileDto>();

            CreateMap<UserProfileDto, UserProfile>(MemberList.Source).ConstructUsing(dto => new UserProfile(dto.FullName, dto.Headline, dto.About, dto.GithubUrl, dto.LinkedinUrl,dto.PhotoUrl, dto.UserId));
        }
        
    }
}
