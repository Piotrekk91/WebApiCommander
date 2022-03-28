using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApiCommander.Data;
using WebApiCommander.Models;

namespace WebApiCommander.Controllers
{
    //api/commands 
    [Route("api/commands")]
    [ApiController]
    public class CommandsController : ControllerBase
    {
        private readonly ICommanderRepo _repository;

        public CommandsController(ICommanderRepo repository)
        {
            _repository = repository;
        }

        //private readonly MockCommanderRepo _repository = new MockCommanderRepo();
        //Get api/commands
        [HttpGet]
        public ActionResult <IEnumerable<Command>> GetAllCommands()
        {

            var commandItems = _repository.GtAppCommands();

            return Ok(commandItems);

        }

        //Get ap/commands/{id}

        [HttpGet("{id}")]
        public ActionResult <Command> GetCommandById(int id)
        {
            
            {
                var commandItem= _repository.GetCommandByID(id);
                return Ok(commandItem);
            }

        }

        
    }
}
