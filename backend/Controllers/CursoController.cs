using Microsoft.AspNetCore.Mvc;
using UdemyCloneBackend.Data;
using UdemyCloneBackend.Models;
using System.Linq;

namespace UdemyCloneBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CursoController : ControllerBase
    {
        private readonly AppDbContext _context;

        public CursoController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetCursos()
        {
            var cursos = _context.Cursos.ToList();
            return Ok(cursos);
        }

        [HttpPost]
        public IActionResult AddCurso(Curso curso)
        {
            _context.Cursos.Add(curso);
            _context.SaveChanges();
            return Ok(curso);
        }
    }
}
