using ApiAWSConciertos.Models;
using ApiAWSConciertos.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiAWSConciertos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventoController : ControllerBase
    {
        private RepositoryConcierto repo;
        public EventoController(RepositoryConcierto repo)
        {
            this.repo = repo;
        }
        [HttpGet]
        public async Task<ActionResult<List<Evento>>> GetEventos()
        {
            return await this.repo.GetEventosAsync();
        }
        [HttpGet("{id}")]
        
        public async Task<ActionResult<List<Evento>>> GetEventosCategoria(int id)
        {
            return await this.repo.GetEventosCategoriaAsync(id);
        }
        [HttpPost]
        public async Task<ActionResult>InsertarEvento(Evento e)
        {
            await this.repo.InsertarEvento(e.Nombre, e.Artista, e.IdCategoria, e.Imagen);
            return Ok();
        }
    }
}
