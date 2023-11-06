using AutoMapper;
using BusinessLayer.DTOs;
using BusinessLayer.Interfaces;
using DataLayer.Interfaces;
using DataLayer.Models;

namespace BusinessLayer.Services
{
    public class RateService : Service<RateDTO, Rate>, IRateService
    {
        public RateService(IDataRepository<Rate> dataRepository, IMapper mapper) : base(dataRepository, mapper)
        {
        }
    }
}
