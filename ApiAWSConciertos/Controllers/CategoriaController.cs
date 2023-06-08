using ApiAWSConciertos.Models;
using ApiAWSConciertos.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiAWSConciertos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        private RepositoryConcierto repo;
        public CategoriaController(RepositoryConcierto repo)
        {
            this.repo = repo;
        }
        [HttpGet]
        public async Task<ActionResult<List<CategoriaEvento>>> GetCategorias()
        {
            return await this.repo.GetCategoriasAsync();
        }

    }
}
