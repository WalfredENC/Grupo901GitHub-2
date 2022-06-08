using APIPelicula.Repository.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIPelicula.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriasController : Controller
    {
        private readonly ICategoriaRepository _ctRepo;
        public CategoriasController(ICategoriaRepository ctRepo)
        {
            _ctRepo = ctRepo;
        }
        public IActionResult GetAlLCategorias()
        {
            var listacategorias = _ctRepo.GetCategorias();
            return Ok(listacategorias);
        }
    }
}
