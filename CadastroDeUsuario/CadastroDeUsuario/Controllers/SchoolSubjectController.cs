using CadastroDeUsuario_Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using CadastroDeUsuario_Services.Materia;
using CadastroDeUsuario_DTO.Request.Materia;
using CadastroDeUsuario_Services.User;

namespace CadastroDeUsuario;

[ApiController]
[Route("Controller")]
public class SchoolSubjectController : Controller
{
    #region Fields
    private readonly ISchoolSubjectService _schoolSubjectService;
    #endregion

    #region Constructor
    public SchoolSubjectController(ISchoolSubjectService SchoolSubjectService)
    {
        _schoolSubjectService = SchoolSubjectService;
    }
    #endregion


    #region EndPoints
    [HttpPost("CreateSchoolSubject")]
    public async Task<IActionResult> CreateSchoolSubject([FromBody] SchoolSubjectRequestDTO request)
    {
        var response = await _schoolSubjectService.CreateSchoolSubject(request);
        return Ok(response);
    }

    [HttpGet("GetAllSchoolSubjects")]
    public async Task<IActionResult> GetAllSchoolSubjects()
    {
        var response = await _schoolSubjectService.GetAllSchoolSubjects();
        return Ok(response);
    }

    [HttpDelete("DeleteAllSchoolSubjects")]
    public async Task<IActionResult> DeleteAllSchoolSubjects()
    {
        try
        {
            await _schoolSubjectService.DeleteAllSchoolSubjects();
            return Ok("Todos as materias foram deletadas.");
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }

    }

    #endregion
}
