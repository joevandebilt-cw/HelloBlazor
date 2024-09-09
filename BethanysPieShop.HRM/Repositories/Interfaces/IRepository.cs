namespace BethanysPieShop.HRM.Repositories.Interfaces
{
    public interface IRepository<T>
    {
        Task<T> Get(int id);
        Task<IEnumerable<T>> GetAll();
        Task<T> Update(T entity);
        Task<bool> Delete(int id);
    }
}
