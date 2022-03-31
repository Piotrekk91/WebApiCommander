using Microsoft.EntityFrameworkCore;
using WebApiCommander.Models;

namespace WebApiCommander.Data
{
    public class CommanderContext : DbContext
    {
        public CommanderContext(DbContextOptions<CommanderContext> opt) : base(opt)
        {


        }
        public DbSet<Command> Commands { get; set; }

    }
}
