using System.Linq;
using Projeto_AspNetCore_xUnit_Moq.Core.Commands;
using Projeto_AspNetCore_xUnit_Moq.Core.Models;
using Projeto_AspNetCore_xUnit_Moq.Infrastructure;

namespace Projeto_AspNetCore_xUnit_Moq.Services.Handlers
{
    public class GerenciaPrazoDasTarefasHandler
    {
        IRepositorioTarefas _repo;

        public GerenciaPrazoDasTarefasHandler(IRepositorioTarefas repositorio)
        {
            _repo = repositorio;
        }

        public void Execute(GerenciaPrazoDasTarefas comando)
        {
            var agora = comando.DataHoraAtual;

            //pegar todas as tarefas não concluídas que passaram do prazo
            var tarefas = _repo
                .ObtemTarefas(t => t.Prazo <= agora && t.Status != StatusTarefa.Concluida)
                .ToList();

            //atualizá-las com status Atrasada
            tarefas.ForEach(t => t.Status = StatusTarefa.EmAtraso);

            //salvar tarefas
            _repo.AtualizarTarefas(tarefas.ToArray());
        }
    }
}
