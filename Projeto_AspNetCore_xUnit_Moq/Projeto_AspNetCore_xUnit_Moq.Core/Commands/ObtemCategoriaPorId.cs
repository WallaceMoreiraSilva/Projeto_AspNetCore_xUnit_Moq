using Projeto_AspNetCore_xUnit_Moq.Core.Models;
using MediatR;

namespace Projeto_AspNetCore_xUnit_Moq.Core.Commands
{
    public class ObtemCategoriaPorId : IRequest<Categoria>
    {
        public ObtemCategoriaPorId(int idCategoria)
        {
            IdCategoria = idCategoria;
        }

        public int IdCategoria { get; }
    }
}
