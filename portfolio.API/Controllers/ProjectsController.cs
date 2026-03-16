using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using portfolio.Application.DTOs.Project;
using portfolio.Application.Interfaces;

namespace portfolio.API.Controllers;

[Authorize]
[ApiController]
[Route("api/[controller]")]
public class ProjectsController(IProjectService service) : ControllerBase
{
    private readonly IProjectService _service = service;

    /// <summary>
    /// Retorna todos os projetos
    /// </summary>
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<IActionResult> GetAll()
    {
        var projects = await _service.GetAllAsync();
        return Ok(projects);
    }

    /// <summary>
    /// Retorna projeto por Id
    /// </summary>
    [HttpGet("{id:guid}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetById(Guid id)
    {
        var project = await _service.GetByIdAsync(id);

        if (project is null)
            return NotFound(new { message = "Project not found" });

        return Ok(project);
    }

    /// <summary>
    /// Cria um novo projeto
    /// </summary>
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Create([FromBody] CreateProjectDto dto)
    {
        var createdProject = await _service.CreateAsync(dto);

        return CreatedAtAction(
            nameof(GetById),
            new { id = createdProject.Id },
            createdProject);
    }

    /// <summary>
    /// Atualiza um projeto existente
    /// </summary>
    //[HttpPut("{id:guid}")]
    //[ProducesResponseType(StatusCodes.Status204NoContent)]
    //[ProducesResponseType(StatusCodes.Status404NotFound)]
    //public async Task<IActionResult> Update(Guid id, [FromBody] UpdateProjectDto dto)
    //{
    //    await _service.UpdateAsync(id, dto);
    //    return NoContent();
    //}

    /// <summary>
    /// Remove um projeto
    /// </summary>
    //[HttpDelete("{id:guid}")]
    //[ProducesResponseType(StatusCodes.Status204NoContent)]
    //public async Task<IActionResult> Delete(Guid id)
    //{
    //    await _service.DeleteAsync(id);
    //    return NoContent();
    //}
}