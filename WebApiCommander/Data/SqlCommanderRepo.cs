using System.Collections.Generic;
using System.Linq;
using WebApiCommander.Models;

namespace WebApiCommander.Data
{
    public class SqlCommanderRepo : ICommanderRepo
    {
        private readonly CommanderContext _context;
        public SqlCommanderRepo(CommanderContext context)
        {
            _context = context;
        }
        IEnumerable<Command> ICommanderRepo.GetAllCommands()
        {
            return _context.Commands.ToList();
            
        }

        Command ICommanderRepo.GetCommandByID(int id)
        {
            return _context.Commands.FirstOrDefault(p => p.Id == id);
        }
    }
}
