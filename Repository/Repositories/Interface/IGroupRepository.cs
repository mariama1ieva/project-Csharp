

namespace Repository.Repositories.Interface
{
    public interface IGroupRepository:IBaseRepository<Group>
    {
        public Group GetGroupByName(string name);

        public List<Group> GetGroupByCapacity(int capacity);
    }
    
}
