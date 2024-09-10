using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UdemyCloneBackend.Data;
using UdemyCloneBackend.Models;
using UdemyCloneBackend.Models.DTO;

namespace UdemyCloneBackend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CursoController : ControllerBase
    {
        private readonly AppDbContext _context;

        public CursoController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        [Authorize]  // Adiciona a autorização
        public async Task<IActionResult> CreateCurso([FromBody] CursoCreateDTO cursoDto)
        {
            var curso = new Curso
            {
                Nome = cursoDto.Nome,
                Descricao = cursoDto.Descricao,
                Preco = cursoDto.Preco
            };

            _context.Cursos.Add(curso);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetCurso), new { id = curso.Id }, curso);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Curso>> GetCurso(int id)
        {
            var curso = await _context.Cursos.FindAsync(id);

            if (curso == null)
            {
                return NotFound();
            }

            return curso;
        }
    }
}
