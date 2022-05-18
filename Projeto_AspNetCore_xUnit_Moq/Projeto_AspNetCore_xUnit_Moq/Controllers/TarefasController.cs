using Microsoft.AspNetCore.Mvc;
using Projeto_AspNetCore_xUnit_Moq.WebApp.Models;
using Projeto_AspNetCore_xUnit_Moq.Core.Commands;
using Projeto_AspNetCore_xUnit_Moq.Services.Handlers;
using Projeto_AspNetCore_xUnit_Moq.Infrastructure;

namespace Projeto_AspNetCore_xUnit_Moq.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TarefasController : ControllerBase
    {
        [HttpPost]
        public IActionResult EndpointCadastraTarefa(CadastraTarefaVM model)
        {
            var cmdObtemCateg = new ObtemCategoriaPorId(model.IdCategoria);
            var categoria = new ObtemCategoriaPorIdHandler().Execute(cmdObtemCateg);
            if (categoria == null)
            {
                return NotFound("Categoria não encontrada");
            }

            var comando = new CadastraTarefa(model.Titulo, categoria, model.Prazo);
            
            var repo = new RepositorioTarefa();
            var handler = new CadastraTarefaHandler(repo); 
            handler.Execute(comando);

            return Ok();
        }
    }
}
