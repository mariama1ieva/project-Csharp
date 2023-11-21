using Domain.Common;


namespace Repository.Repositories.Interface
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
        public void Create(T entity);
        public void Edit(T entity);
        public void Delete(T entity);
        T GetById(int id);
         List<T> GetAll();
    }
    
}
