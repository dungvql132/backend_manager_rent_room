namespace BusinessLayer.Interfaces
{
    public interface IService<TDTO,T>
    {
        public Task<List<TDTO>> GetAllAsync();
        public Task<TDTO> GetAsync(Guid id);
        public Task<TDTO> AddAsync(TDTO item);
        public Task UpdateAsync<TUpdateDTO>(TUpdateDTO updateDTO, Guid id);
        public Task DeleteAsync(Guid id);
    }
}
