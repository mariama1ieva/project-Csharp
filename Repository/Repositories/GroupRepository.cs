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


        public Group GetGroupByName(string name)
        {
            return AppDbContext<Group>.datas.FirstOrDefault(x => x.Name == name);
        }


        public bool UniqueName(string groupname)
        {
            return AppDbContext<Group>.datas.Any(x => x.Name != groupname);
        }
    }
}
