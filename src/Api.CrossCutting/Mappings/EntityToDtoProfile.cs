using Api.Domain.DTOs.User;
using Api.Domain.Entities;
using Api.Domain.Models;
using AutoMapper;

namespace Api.Crosscutting.Mappings
{
    public class EntityToDtoProfile : Profile
    {
        public EntityToDtoProfile()
        {
            CreateMap<UserDTO, UserEntity>().ReverseMap();
            CreateMap<UserDTOCreatedResult, UserEntity>().ReverseMap();
            CreateMap<UserDTOUpdateResult, UserEntity>().ReverseMap();

        }
    }
}