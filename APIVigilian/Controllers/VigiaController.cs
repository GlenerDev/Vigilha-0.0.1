using Microsoft.AspNetCore.Mvc;

namespace APIVigilian.Controllers
{
    [ApiController]
    [Route("Funcionario/")]
    public class VigiaController : ControllerBase
    {
        [HttpGet("/ObterFuncionarioPorID/")]
        public ActionResult ObterPorID(int id) 
        {
            try
            {
                
            }
            catch (Exception ex) { return NotFound(ex.Message); }
        }
    }
}
