using Projeto_AspNetCore_xUnit_Moq.Core.Models;
using Projeto_AspNetCore_xUnit_Moq.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projeto_AspNetCore_xUnit_Moq.Testes
{
    class RepositorioFake : IRepositorioTarefas
    {
        List<Tarefa> lista = new List<Tarefa>();

        public void IncluirTarefas(params Tarefa[] tarefas)
        {
            throw new Exception("Houve um erro ao incluir as tarefas.");
            tarefas.ToList().ForEach(t => lista.Add(t));
        }

        public IEnumerable<Tarefa> ObtemTarefas(Func<Tarefa, bool> filtro)
        {
            return lista.Where(filtro);
        }

        public void AtualizarTarefas(params Tarefa[] tarefas)
        {
            throw new NotImplementedException();
        }

        public void ExcluirTarefas(params Tarefa[] tarefas)
        {
            throw new NotImplementedException();
        }

        public Categoria ObtemCategoriaPorId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
