using AutoMapper;
using BusinessLayer.DTOs;
using BusinessLayer.Interfaces;
using DataLayer.Interfaces;
using DataLayer.Models;

namespace BusinessLayer.Services
{
    public class HouseService : Service<HouseDTO, House>, IHouseService
    {
        private readonly IHouseRepository _houseRepository;
        private readonly IUserRepository _userRepository;
        public HouseService(
            IDataRepository<House> dataRepository, 
            IMapper mapper,
            IHouseRepository houseRepository,
            IUserRepository userRepository
            ) : base(dataRepository, mapper)
        {
            _houseRepository = houseRepository;
            _userRepository = userRepository;
        }

        public async Task<List<HouseDTO>> GetAllAsync(FilterHouseDTO filterHouseDTO)
        {
            var houses = await _houseRepository.GetAll(filterHouseDTO);
            return _mapper.Map<List<HouseDTO>>(houses);
        }

        public async Task UpdateAsync(HouseUpdateDTO houseUpdateDTO, Guid id, string email)
        {
            User user = await _userRepository.Find(email);
            House house = await _houseRepository.Get(id);
            if(house == null) throw new Exception("cannot find the house!");
            if(user == null) throw new Exception("cannot find the user!");

            if(house.LandLordId != user.Id) throw new UnauthorizedAccessException("Only the landlord can modified the data!");
            await this.UpdateAsync<HouseUpdateDTO>(houseUpdateDTO, id);
        }
    }
}
