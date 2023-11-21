

namespace Repository.Repositories.Interface
{
    public interface IGroupRepository:IBaseRepository<Group>
    {
        public string GetGroupByName(string name);

        public string GetGroupByCapacity(int capacity);
    }
    
}
