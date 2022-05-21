using Xunit;
using Moq;
using Projeto_AspNetCore_xUnit_Moq.Infrastructure;
using Projeto_AspNetCore_xUnit_Moq.Core.Commands;
using Projeto_AspNetCore_xUnit_Moq.Services.Handlers;

namespace Projeto_AspNetCore_xUnit_Moq.Testes
{
    public class ObtemCategoriaPorIdExecute
    {
        [Fact]
        public void QuandoForChamadoDeveInvocarObtemCategoriaPorIdNoRepositorio()
        {
            //arrange
            var idCategoria = 20;

            var mock = new Mock<IRepositorioTarefas>();
            var repo = mock.Object;

            var comando = new ObtemCategoriaPorId(idCategoria);
            var handler = new ObtemCategoriaPorIdHandler(repo);

            //act
            handler.Execute(comando);

            //assert
            mock.Verify(r => r.ObtemCategoriaPorId(idCategoria), Times.Once());
        }
    }
}
