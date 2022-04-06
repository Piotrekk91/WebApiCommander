using System.Collections.Generic;
using WebApiCommander.Models;

namespace WebApiCommander.Data
{
    public interface ICommanderRepo
    {
            bool SaveChanges(); 
      
            IEnumerable<Command> GetAllCommands();
            Command GetCommandByID(int id);
            void CreateCommand(Command cmd);
            void UpdateCommand(Command cmd);
            void DeleteCommand(Command cmd);
    }
}
