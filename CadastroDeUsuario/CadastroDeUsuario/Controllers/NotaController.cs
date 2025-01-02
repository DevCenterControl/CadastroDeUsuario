using CadastroDeUsuario_Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CadastroDeUsuario
{
    [ApiController]
    [Route("Controller")]
    public class  NotaController : Controller
    {
        #region Fields
        private readonly INotaService _notaService;
        #endregion

        #region Constructor
        public NotaController(INotaService notaService)
        {
            _notaService = notaService;
        }
        #endregion

        #region EndPoints
        

        #endregion
    }
}