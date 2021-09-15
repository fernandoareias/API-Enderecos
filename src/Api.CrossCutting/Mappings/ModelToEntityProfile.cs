



using Api.Domain.DTOs.User;
using Api.Domain.Entities;
using Api.Domain.Models;
using AutoMapper;

namespace Api.Crosscutting.Mappings
{
    public class ModelToEntityProfile : Profile
    {
        public ModelToEntityProfile()
        {
            CreateMap<UserEntity, UserModel>().ReverseMap();
        }
    }
}