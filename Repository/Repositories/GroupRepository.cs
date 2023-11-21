using Repository.Data;
using Repository.Repositories.Interface;

namespace Repository.Repositories
{
    public class GroupRepository : BaseRepository<Group>, IGroupRepository
    {
        public string GetGroupByCapacity(int capacity)
        {
            return AppDbContext<Group>.datas.Where(x => x.Capacity == capacity).ToString();
        }

        public string GetGroupByName(string name)
        {
            return AppDbContext<Group>.datas.Where(x => x.Name == name).ToString();
        }
    }
}
