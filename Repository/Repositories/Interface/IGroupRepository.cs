

namespace Repository.Repositories.Interface
{
    public interface IGroupRepository : IBaseRepository<Group>
    {
        public Group GetGroupByName(string name);

        public List<Group> GetGroupByCapacity();

        public List<Group> GroupByCapacity();

        bool UniqueName(string groupname);

        public Group CapacityOfGroup(int capacity);
    }

}
