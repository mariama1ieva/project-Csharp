using Repository.Data;
using Repository.Repositories.Interface;

namespace Repository.Repositories
{
    public class GroupRepository : BaseRepository<Group>, IGroupRepository
    {
        public Group CapacityOfGroup(int capacity)
        {
            return AppDbContext<Group>.datas.FirstOrDefault(x => x.Capacity == capacity);
        }

        public List<Group> GetGroupByCapacity(int capacity)
        {

            return AppDbContext<Group>.datas.OrderByDescending(x => x.Capacity == capacity).ToList();
        }

        public Group GetGroupByName(string name)
        {
            return AppDbContext<Group>.datas.FirstOrDefault(x => x.Name == name);
        }

        public List<Group> GroupByCapacity(int capacity)
        {
            return AppDbContext<Group>.datas.OrderBy(x => x.Capacity == capacity).ToList();

        }

        public bool UniqueName(string groupname)
        {
            return AppDbContext<Group>.datas.Any(x => x.Name != groupname);
        }
    }
}
