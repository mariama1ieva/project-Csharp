using Repository.Data;
using Repository.Repositories.Interface;

namespace Repository.Repositories
{
    public class GroupRepository : BaseRepository<Group>, IGroupRepository
    {
        public List<Group> GetGroupByCapacity(int capacity)
        {
            
            return AppDbContext<Group>.datas.OrderByDescending(x => x.Capacity == capacity).ToList();
        }

        public Group GetGroupByName(string name)
        {
            return AppDbContext<Group>.datas.FirstOrDefault(x => x.Name == name);
        }
    }
}
