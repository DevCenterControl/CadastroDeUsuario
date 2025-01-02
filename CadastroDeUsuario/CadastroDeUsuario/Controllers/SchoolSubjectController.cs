using CadastroDeUsuario_Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using CadastroDeUsuario_Services.Materia;
using CadastroDeUsuario_DTO.Request.Materia;

namespace CadastroDeUsuario;

[ApiController]
[Route("Controller")]
public class SchoolSubjectController : Controller
{
    #region Fields
    private readonly ISchoolSubjectService _materiaService;
    #endregion

    #region Constructor
    public SchoolSubjectController(ISchoolSubjectService materiaService)
    {
        _materiaService = materiaService;
    }
    #endregion


    #region EndPoints
    [HttpPost("CreateSchoolSubject")]
    public async Task<IActionResult> CreateSchoolSubject([FromBody] MateriaRequestDTO request)
    {
        var response = await _materiaService.CreateSchoolSubject(request);
        return Ok(response);
    }

    [HttpGet("GetAllMaterias")]
    public async Task<IActionResult> GetAllMaterias()
    {
        var response = await _materiaService.GetAllMaterias();
        return Ok(response);
    }

    #endregion
}
