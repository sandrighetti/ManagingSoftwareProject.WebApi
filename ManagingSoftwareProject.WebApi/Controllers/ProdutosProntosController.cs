using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ManagingSoftwareProject.WebApi.Entities;
using ManagingSoftwareProject.WebApi.Repositories;

namespace ManagingSoftwareProject.WebApi.Controllers
{
    [ApiController]
    [Route("ProdutoPronto")]
    public class ProdutosProntosController : Controller
    {
        private readonly ProdutoProntoRepository _produtoProntoRepository;

        public ProdutosProntosController(ProdutoProntoRepository produtoProntoRepository)
        {
            _produtoProntoRepository = produtoProntoRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_produtoProntoRepository.FindAll());
        }

        [HttpPost]
        public async Task<IActionResult> Post(ProdutoPronto produtoPronto)
        {
            _produtoProntoRepository.Save(produtoPronto);
            return Ok(await _produtoProntoRepository.UnitOfWork.Commit());
        }
    }
}
