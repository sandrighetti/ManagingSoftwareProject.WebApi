using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ManagingSoftwareProject.WebApi.Entities;
using ManagingSoftwareProject.WebApi.Repositories;

namespace ManagingSoftwareProject.WebApi.Controllers
{
    [ApiController]
    [Route("Fornecedor")]
    public class FornecedoresController : Controller
    {
        private readonly FornecedorRepository _fornecedorRepository;

        public FornecedoresController(FornecedorRepository fornecedorRepository)
        {
            _fornecedorRepository = fornecedorRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_fornecedorRepository.FindAll());
        }

        [HttpPost]
        public async Task<IActionResult> Post(Fornecedor fornecedor)
        {
            _fornecedorRepository.Save(fornecedor);
            return Ok(await _fornecedorRepository.UnitOfWork.Commit());
        }
    }
}
