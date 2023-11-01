using BusinessLayer.DTOs;
using DataLayer.Models;

namespace BusinessLayer.Interfaces
{
    public interface IHouseService : IService<HouseDTO,House>
    {
    }
}
