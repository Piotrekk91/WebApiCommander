﻿using System.Collections.Generic;
using WebApiCommander.Models;

namespace WebApiCommander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public Command GetCommandByID(int id)
        {
            return new Command {Id = 0, HowTo = "Boil an egg", Line = "Boil water", Platform = "Kettle & Pan" };
        }

        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
            {
                new Command { Id = 0, HowTo = "Boil an egg", Line = "Boil water", Platform = "Kettle & Pan" },
                new Command { Id = 1, HowTo = "Cut bread", Line = "Get a knife", Platform = "knife & chopping boadr" },
                new Command { Id = 2, HowTo = "Make cup of tea", Line = "Place teabag in cup", Platform = "Kettle & Pan" }
            };
            return commands;
        }
    }
}
