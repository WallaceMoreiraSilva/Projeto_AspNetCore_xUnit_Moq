using System;
using System.Collections.Generic;
using Projeto_AspNetCore_xUnit_Moq.Core.Models;

namespace Projeto_AspNetCore_xUnit_Moq.Infrastructure
{
    public interface IRepositorioTarefas
    {
        void IncluirTarefas(params Tarefa[] tarefas);
        void AtualizarTarefas(params Tarefa[] tarefas);
        void ExcluirTarefas(params Tarefa[] tarefas);

        Categoria ObtemCategoriaPorId(int id);
        IEnumerable<Tarefa> ObtemTarefas(Func<Tarefa, bool> filtro);
    }
}
