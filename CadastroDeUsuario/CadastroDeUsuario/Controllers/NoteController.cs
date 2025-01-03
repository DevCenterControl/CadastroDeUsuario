using CadastroDeUsuario_DTO.Request.Note;
using CadastroDeUsuario_Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CadastroDeUsuario
{
    [ApiController]
    [Route("Controller")]
    public class  NoteController : Controller
    {
        #region Fields
        private readonly INoteService _noteService;
        #endregion

        #region Constructor
        public NoteController(INoteService noteService)
        {
            _noteService = noteService;
        }
        #endregion

        #region EndPoints
        [HttpPost("CreateNote")]
        public async Task<IActionResult> CreateNote([FromBody] NoteRequestDTO request)
        {
            try
            {
                var result = await _noteService.CreateNote(request);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("GetNotesByUserId")]
        public async Task<IActionResult> GetNotesByUserId(int Id)
        {
            try
            {
                var note = await _noteService.GetNoteByUserId(Id);
                if (note == null)

                {
                    return NotFound("Nenhuma nota encontrada para o usuario informado");
                }
                return Ok(note);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        #endregion
    }
}