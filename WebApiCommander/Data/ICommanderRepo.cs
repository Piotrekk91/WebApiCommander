using System.Collections.Generic;
using WebApiCommander.Models;

namespace WebApiCommander.Data
{
    public interface ICommanderRepo
    {
            IEnumerable<Command> GtAppCommands();
            Command GetCommandByID(int id);
    }
}
