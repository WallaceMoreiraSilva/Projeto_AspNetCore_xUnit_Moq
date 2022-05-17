using Projeto_AspNetCore_xUnit_Moq.Core.Commands;
using Projeto_AspNetCore_xUnit_Moq.Core.Models;
using Projeto_AspNetCore_xUnit_Moq.Infrastructure;

namespace Projeto_AspNetCore_xUnit_Moq.Services.Handlers
{
    public class ObtemCategoriaPorIdHandler
    {
        IRepositorioTarefas _repo;

        public ObtemCategoriaPorIdHandler()
        {
            _repo = new RepositorioTarefa();
        }
        public Categoria Execute(ObtemCategoriaPorId comando)
        {
            return _repo.ObtemCategoriaPorId(comando.IdCategoria);
        }
    }
}
