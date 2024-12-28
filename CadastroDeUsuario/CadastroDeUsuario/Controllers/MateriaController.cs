using CadastroDeUsuario_Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using CadastroDeUsuario_Services.Materia;
using CadastroDeUsuario_DTO.Request.Materia;

namespace CadastroDeUsuario;

[ApiController]
[Route("Controller")]
public class MateriaController : BaseController
{
    #region Fields
    private readonly IMateriaService _materiaService;
    #endregion

    #region Constructor
    public MateriaController(IMateriaService materiaService)
    {
        _materiaService = materiaService;
    }
    #endregion


    #region EndPoints
    [HttpPost("CreateMateria")]
    public async Task<IActionResult> CreateMateria([FromBody] MateriaRequestDTO request)
    {
        var response = await _materiaService.CreateMateria(request);
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
