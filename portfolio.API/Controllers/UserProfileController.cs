using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using portfolio.Application.Interfaces;

namespace portfolio.API.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class UserProfileController(IUserProfileService userProfileService) : ControllerBase
    {
        private readonly IUserProfileService _userProfileService = userProfileService;
        /// <summary>
        /// Retorna usuario profile por Id
        /// </summary>
        [HttpGet("{id:guid}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetById(Guid id)
        {
            var userProfile = await _userProfileService.GetByIdAsync(id);

            if (userProfile is null)
                return NotFound(new { message = "Project not found" });

            return Ok(userProfile);
        }
    }
}
