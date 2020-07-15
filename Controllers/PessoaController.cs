using Microsoft.AspNetCore.Mvc;
using Webapi.Services.Interfaces;
using Webapi.ViewModel;

namespace Webapi.Controllers
{
    [Route("pessoa")]
    public class PessoaController: Controller
    {
        private readonly IPessoaService _Service;

        public PessoaController(IPessoaService Service)
        {
            _Service = Service;
        }

        [HttpPost("idade")]
        public JsonResult RetornaIdade([FromBody] PessoaViewModel viewModel) 
        {
            int idade = _Service.CalcularIdade(viewModel);
            return Json(new { 
                nome = viewModel.Nome,
                age = idade 
            });
        }
        
    }
}