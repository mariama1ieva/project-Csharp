

namespace Repository.Repositories.Interface
{
    public interface IGroupRepository : IBaseRepository<Group>
    {
        List<Group> GetGroupByName(string groupName);

        bool UniqueName(string groupname);

        List<Group> SortByCapacity(string text);
    }

}
