using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ManagingSoftwareProject.WebApi.Entities;
using ManagingSoftwareProject.WebApi.Repositories;

namespace ManagingSoftwareProject.WebApi.Controllers
{
    [ApiController]
    [Route("MateriaPrima")]
    public class MateriasPrimasController : Controller
    {
        private readonly MateriaPrimaRepository _materiaPrimaRepository;

        public MateriasPrimasController(MateriaPrimaRepository materiaPrimaRepository)
        {
            _materiaPrimaRepository = materiaPrimaRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_materiaPrimaRepository.FindAll());
        }

        [HttpPost]
        public async Task<IActionResult> Post(MateriaPrima materiaPrima)
        {
            _materiaPrimaRepository.Save(materiaPrima);
            return Ok(await _materiaPrimaRepository.UnitOfWork.Commit());
        }
    }
}
