using Microsoft.AspNetCore.Mvc;
using study_this_framework.Dtos;
using study_this_framework.IBase;
using study_this_framework.IServices;
using study_this_framework.models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace study_this_framework.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EspecialidadController : ControllerBase
    {
        // GET: api/<EspecialidadController>
        private readonly IEspecialidadService _especialidadService;
        public EspecialidadController(IEspecialidadService especialidadService)
        {
            _especialidadService = especialidadService;
        }
        [HttpGet("GetAllItems")]
        public async Task <ActionResult> GetAll()
        {
            var response = await _especialidadService.ListaEspecialidades();
            if (response.Estado) {
                return Ok(new { Datos = response.Resultado, response.TotalItems });
            }else {
                ModelState.AddModelError("Error", string.Join(",", response.Errores));
                return BadRequest(ModelState);
            }
        }

        // GET api/<EspecialidadController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<EspecialidadController>
        [HttpPost("CreateSeveralEspecialtiesProcedure")]
        public async Task<ActionResult> CreateSeveralEspecialtiesProcedure([FromBody] GenericRequest<CrearEspecialidadDto> especialidad)
        {
            var response = await _especialidadService.CreateSeveralEspecialtiesProcedure(Especialties: especialidad.Inserts);
            if (response.Estado)
            {
                return Ok(new { Datos = response.Resultado, response.TotalItems });
            }
            else
            {
                ModelState.AddModelError("Error", string.Join(",", response.Errores));
                return BadRequest(ModelState);
            }

        }

        // PUT api/<EspecialidadController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<EspecialidadController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
