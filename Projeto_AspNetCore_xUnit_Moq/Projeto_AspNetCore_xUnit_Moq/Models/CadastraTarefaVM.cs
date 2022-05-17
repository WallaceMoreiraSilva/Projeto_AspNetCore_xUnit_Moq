using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_AspNetCore_xUnit_Moq.WebApp.Models
{
    public class CadastraTarefaVM
    {
        public string Titulo { get; set; }
        public int IdCategoria { get; set; }
        public DateTime Prazo { get; set; }
    }
}
