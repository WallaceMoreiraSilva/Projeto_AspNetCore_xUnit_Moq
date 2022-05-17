using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto_AspNetCore_xUnit_Moq.Core.Models
{
    /// <summary>
    /// Indica o estado em que a <see cref="Tarefa"/> se encontra no presente.
    /// </summary>
    public enum StatusTarefa
    {
        Criada,
        Pendente,
        EmAtraso,
        Concluida
    }
}
