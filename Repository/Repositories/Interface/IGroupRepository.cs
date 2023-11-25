

namespace Repository.Repositories.Interface
{
    public interface IGroupRepository : IBaseRepository<Group>
    {
        public Group GetGroupByName(string name);

        bool UniqueName(string groupname);

        public Group CapacityOfGroup(int capacity);
    }

}
