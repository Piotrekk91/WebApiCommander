using AutoMapper;
using WebApiCommander.Dtos;

namespace WebApiCommander.Profiles
{
    public class CommandsProfile : Profile
    {
        public CommandsProfile()
        {
            CreateMap<CommandsProfile, CommandReadDto>();
        }
    }    
}
