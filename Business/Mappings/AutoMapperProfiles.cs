using AutoMapper;
using BusinessLayer.DTOs;
using DataLayer.Models;

namespace BusinessLayer.AutoMapper
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles(){
            CreateMap<UserDTO,User>().ReverseMap();
            CreateMap<HouseDTO,House>().ReverseMap();
            CreateMap<RoomDTO,Room>().ReverseMap();
            CreateMap<RateDTO,Rate>().ReverseMap();
        }
    }
}