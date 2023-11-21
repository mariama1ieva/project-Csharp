using Domain.Common;
using Repository.Data;
using Repository.Repositories.Interface;

namespace Repository.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        private static int _id = 1;
      
        public void Create(T entity)
        {
            entity.Id = _id++;
            AppDbContext<T>.datas.Add(entity);
        }

        public void Delete(T entity)
        {
           AppDbContext<T>.datas.Remove(entity);
        }

        public void Edit(T entity)
        {
            throw new NotImplementedException();
        }

        public List<T> GetAll()
        {
           return AppDbContext<T>.datas.ToList();
        }

        public T GetById(int id)
        {
            return AppDbContext<T>.datas.FirstOrDefault(x => x.Id == id);
        }
    }
}
