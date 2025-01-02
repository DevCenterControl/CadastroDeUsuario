using CadastroDeUsuario_Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CadastroDeUsuario
{
    [ApiController]
    [Route("Controller")]
    public class  NoteController : Controller
    {
        #region Fields
        private readonly INoteService _notaService;
        #endregion

        #region Constructor
        public NoteController(INoteService notaService)
        {
            _notaService = notaService;
        }
        #endregion

        #region EndPoints
        

        #endregion
    }
}