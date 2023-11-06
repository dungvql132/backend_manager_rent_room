using AutoMapper;
using BusinessLayer.DTOs;
using BusinessLayer.Interfaces;
using DataLayer.Interfaces;
using DataLayer.Models;

namespace BusinessLayer.Services
{
    public class Service<TDTO, T> : IService<TDTO, T>
    where TDTO : BaseModelDTO
    where T : BaseModel
    {
        protected readonly IDataRepository<T> _dataRepository;
        protected readonly IMapper _mapper;

        public Service(IDataRepository<T> dataRepository, IMapper mapper)
        {
            _dataRepository = dataRepository;
            _mapper = mapper;
        }

        public virtual async Task<TDTO> AddAsync(TDTO item)
        {
            T data = _mapper.Map<T>(item);
            await _dataRepository.Add(data);
            await _dataRepository.Save();
            return _mapper.Map<TDTO>(data);
        }

        public virtual async Task DeleteAsync(Guid id)
        {
            TDTO itemDTO = await GetAsync(id);
            T item = _mapper.Map<T>(itemDTO);
            await _dataRepository.Delete(item);
        }

        public virtual async Task<List<TDTO>> GetAllAsync()
        {
            List<T> rs = await _dataRepository.GetAll();
            return _mapper.Map<List<TDTO>>(rs);
        }

        public virtual async Task<TDTO> GetAsync(Guid id)
        {
            T item = await _dataRepository.Get(id);
            return _mapper.Map<TDTO>(item);
        }

        public virtual async Task UpdateAsync<TUpdateDTO>(TUpdateDTO updateDTO, Guid id)
        {
            T item = await _dataRepository.Get(id);

            if (item == null)
            {
                // Handle the case where the item with the given ID is not found.
                // You can return an error or take appropriate action.
                return;
            }

            // Get the properties of the updateDTO and item
            var updateDTOProperties = typeof(TUpdateDTO).GetProperties();
            var itemProperties = typeof(T).GetProperties();

            // Loop through the properties and copy values from updateDTO to item
            foreach (var updateDTOProperty in updateDTOProperties)
            {
                // Find the corresponding property in item
                var itemProperty = itemProperties.FirstOrDefault(p => p.Name == updateDTOProperty.Name);

                if (itemProperty != null && itemProperty.CanWrite)
                {
                    // Get the value from updateDTO property
                    var value = updateDTOProperty.GetValue(updateDTO);

                    // Check if the value is not null before updating item property
                    if (value != null)
                    {
                        itemProperty.SetValue(item, value);
                    }
                }
            }

            // Save the updated item
            await _dataRepository.Update(item);
        }

    }
}
