﻿using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApiCommander.Data;
using WebApiCommander.Dtos;
using WebApiCommander.Models;

namespace WebApiCommander.Controllers
{
    //api/commands 
    [Route("api/commands")]
    [ApiController]
    public class CommandsController : ControllerBase
    {
        private readonly ICommanderRepo _repository;
        private readonly IMapper _mapper;

        public CommandsController(ICommanderRepo repository, IMapper mapper)
        {
            
            _repository = repository;
            _mapper = mapper;
        }

        //Get api/commands/
        [HttpGet]
        public ActionResult <IEnumerable<CommandReadDto>> GetAllCommands()
        {

            var commandItems = _repository.GetAllCommands();

            return Ok(_mapper.Map<IEnumerable<CommandReadDto>>(commandItems));

        }

        //Get ap/commands/{id}

        [HttpGet("{id}")]
        public ActionResult <CommandReadDto> GetCommandById(int id)
        {
            
            {
                var commandItem= _repository.GetCommandByID(id);
                if(commandItem != null)
                {
                    return Ok(_mapper.Map<CommandReadDto>(commandItem));
                }
                return NotFound();
            }

        }

        
    }
}
