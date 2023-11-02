using AutoMapper;
using BusinessLayer.DTOs;
using BusinessLayer.Interfaces;
using DataLayer.Interfaces;
using DataLayer.Models;

namespace BusinessLayer.Services
{
    public class RoomService : Service<RoomDTO, Room>, IRoomService
    {
        private readonly IRoomRepository _roomRepository;
        private readonly IUserRepository _userRepository;
        private readonly IHouseRepository _houseRepository;
        public RoomService(
            IDataRepository<Room> dataRepository, 
            IMapper mapper,
            IRoomRepository roomRepository,
            IUserRepository userRepository,
            IHouseRepository houseRepository
            ) : base(dataRepository, mapper)
        {
            _roomRepository = roomRepository;
            _userRepository = userRepository;
            _houseRepository = houseRepository;
        }

        public async Task<RoomDTO> AddAsync(RoomDTO item, string email)
        {
            User user = await _userRepository.Find(email);
            House house = await _houseRepository.Get(item.HouseId);
            if(house.LandLordId != user.Id) throw new UnauthorizedAccessException("Only the landlord can add room to this house the data!");

            return await this.AddAsync(item);
        }

        public async Task DeleteAsync(Guid id, string email)
        {
            User user = await _userRepository.Find(email);
            Room room = await _roomRepository.Get(id);
            if(room == null) throw new Exception("cannot find the room!");
            if(user == null) throw new Exception("cannot find the user!");

            if(room.House.LandLordId != user.Id) throw new UnauthorizedAccessException("Only the landlord can delete the data!");
            await this.DeleteAsync(id);
        }

        public async Task<List<RoomDTO>> GetAllAsync(FilterRoomDTO filterRoomDTO)
        {
            var rooms = await _roomRepository.GetAll(filterRoomDTO);
            return _mapper.Map<List<RoomDTO>>(rooms);
        }

        public async Task UpdateAsync(RoomUpdateDTO roomUpdateDTO, Guid id, string email)
        {
            User user = await _userRepository.Find(email);
            Room room = await _roomRepository.Get(id);
            if(room == null) throw new Exception("cannot find the room!");
            if(user == null) throw new Exception("cannot find the user!");

            if(room.House.LandLordId != user.Id) throw new UnauthorizedAccessException("Only the landlord can modified the data!");
            System.Console.WriteLine("room.House.LandLordId : "+room.House.LandLordId);
            System.Console.WriteLine("room.House.LandLordId : "+room.House.LandLordId);
            await this.UpdateAsync<RoomUpdateDTO>(roomUpdateDTO, id);
        }
    }
}
