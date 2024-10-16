using Microsoft.AspNetCore.Mvc;
using WebApplication.Entity;
using WebApplication.Interface;

namespace WebApplication.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        public readonly IUsuarioRepository _repository;
        public UsuarioController(IUsuarioRepository repository)
        {
            _repository = repository;
        }
        [HttpGet]
        public async Task<IActionResult> getAll()
        {
            var items = await _repository.GetAll();
            return Ok(items);
        }
        [HttpPost]
        public async Task<IActionResult> setNew([FromBody] Usuario Usuario1)
        {
            return Ok(await _repository.Create(Usuario1));
        }

        
        [HttpPut("ruta")]
        public async Task<IActionResult> setUpdate([FromBody] Usuario Usuarioput)
        {
            try
            {
                return Ok(new { status = true, item = await _repository.Update(Usuarioput) });
            }
            catch (Exception ex)
            {
                return Ok(new { status = false, message = ex.Message });
            }
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> setUpdate(int id)
        {
            var item = await _repository.GetById(id);
            return Ok(await _repository.Delete(item));
        }
    }
}
