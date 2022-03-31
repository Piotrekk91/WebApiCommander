using System.Collections.Generic;
using WebApiCommander.Models;

namespace WebApiCommander.Data
{
    public interface ICommanderRepo
    {
      
            IEnumerable<Command> GetAllCommands();
            Command GetCommandByID(int id);
    }
}
