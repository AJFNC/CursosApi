using CursosApi.Models;
using CursosApi.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;


namespace CursosApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CursosController : ControllerBase
    {
        private readonly CursoService _cursoService;

        public CursosController(CursoService cursoService)
        {
            _cursoService = cursoService;
        }

        [HttpGet]
        public ActionResult<List<Curso>> Get() =>
            _cursoService.Get();

        [HttpGet("{id:length(24)}", Name = "GetCurso")]
        public ActionResult<Curso> Get(string id)
        {
            var curso = _cursoService.Get(id);

            if (curso == null)
            {
                return NotFound();
            }

            return curso;
        }

        [HttpPost]
        public ActionResult<Curso> Create(Curso curso)
        {
            _cursoService.Create(curso);

            return CreatedAtRoute("GetCurso", new { id = curso.Id.ToString() }, curso);
        }

        [HttpPut("{id:length(24)}")]
        public IActionResult Update(string id, Curso cursoIn)
        {
            var curso = _cursoService.Get(id);

            if (curso == null)
            {
                return NotFound();
            }

            _cursoService.Update(id, cursoIn);

            return NoContent();
        }

        [HttpDelete("{id:length(24)}")]
        public IActionResult Delete(string id)
        {
            var curso = _cursoService.Get(id);

            if (curso == null)
            {
                return NotFound();
            }

            _cursoService.Remove(curso.Id);

            return NoContent();
        }
    }
}
