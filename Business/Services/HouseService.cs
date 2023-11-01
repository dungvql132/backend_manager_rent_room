using AutoMapper;
using BusinessLayer.DTOs;
using BusinessLayer.Interfaces;
using DataLayer.Interfaces;
using DataLayer.Models;

namespace BusinessLayer.Services
{
    public class HouseService : Service<HouseDTO, House>, IHouseService
    {
        public HouseService(IDataRepository<House> dataRepository, IMapper mapper) : base(dataRepository, mapper)
        {
        }
    }
}
