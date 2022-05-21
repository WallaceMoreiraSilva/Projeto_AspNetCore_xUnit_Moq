using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto_AspNetCore_xUnit_Moq.Services.Handlers
{
    public class CommandResult
    {
        public CommandResult(bool success)
        {
            IsSuccess = success;
        }

        public bool IsSuccess { get; }
    }
}
