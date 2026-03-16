using portfolio.Application.DTOs.Auth;
using portfolio.Application.Interfaces;
using portfolio.Domain.Entities;
using portfolio.Domain.Interfaces;

namespace portfolio.Application.Services
{
    public class AuthService(
        IRepository<User> userRepository,
        IRepository<UserProfile> profileRepository,
        TokenService tokenService) : IAuthService
    {
        private readonly IRepository<User> _userRepository = userRepository;
        private readonly IRepository<UserProfile> _profileRepository = profileRepository;
        private readonly TokenService _tokenService = tokenService;

        public async Task<AuthResponseDto> RegisterAsync(RegisterDto dto)
        {
            // Verifica se já existe
            var existingUser = await _userRepository
                .FirstOrDefaultAsync(u => u.Email == dto.Email);

            if (existingUser != null)
                throw new Exception("Email already registered");

            // Hash da senha
            var passwordHash = BCrypt.Net.BCrypt.HashPassword(dto.Password);

            var user = new User(dto.Email, passwordHash);

            await _userRepository.AddAsync(user);

            var profile = new UserProfile(
                dto.FullName,
                "",
                "",
                "",
                "",
                user.Id
            );

            await _profileRepository.AddAsync(profile);

            var token = _tokenService.GenerateToken(
                user.Id.ToString(),
                user.Email
            );

            return new AuthResponseDto(token, user.Email);
        }

        public async Task<AuthResponseDto> LoginAsync(LoginDto dto)
        {
            var user = await _userRepository
                .FirstOrDefaultAsync(u => u.Email == dto.UserLogin);

            if (user is null)
                throw new Exception("Invalid credentials");

            var validPassword = BCrypt.Net.BCrypt
                .Verify(dto.Password, user.PasswordHash);

            if (!validPassword)
                throw new Exception("Invalid credentials");

            var token = _tokenService.GenerateToken(
                user.Id.ToString(),
                user.Email
            );

            return new AuthResponseDto(token, user.Email);
        }
    }
}
