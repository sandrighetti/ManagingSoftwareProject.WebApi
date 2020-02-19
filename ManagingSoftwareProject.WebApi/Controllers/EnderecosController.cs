using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ManagingSoftwareProject.WebApi.Entities;
using ManagingSoftwareProject.WebApi.Repositories;

namespace ManagingSoftwareProject.WebApi.Controllers
{
    [ApiController]
    [Route("Endereco")]
    public class EnderecosController : Controller
    {
        private readonly EnderecoRepository _enderecoRepository;

        public EnderecosController(EnderecoRepository enderecoRepository)
        {
            _enderecoRepository = enderecoRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_enderecoRepository.FindAll());
        }

        [HttpPost]
        public async Task<IActionResult> Post(Endereco endereco)
        {
            _enderecoRepository.Save(endereco);
            return Ok(await _enderecoRepository.UnitOfWork.Commit());
        }
    }
}
