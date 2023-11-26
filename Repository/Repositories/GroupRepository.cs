using Repository.Data;
using Repository.Repositories.Interface;

namespace Repository.Repositories
{
    public class GroupRepository : BaseRepository<Group>, IGroupRepository
    {

        public bool UniqueName(string groupname)
        {
            return AppDbContext<Group>.datas.Any(x => x.Name != groupname);
        }

        public List<Group> GetGroupByName(string groupName)
        {
            return AppDbContext<Group>.datas.Where(x => x.Name.ToLower().Contains(groupName)).ToList();
        }

        public List<Group> SortByCapacity(string text)
        {
            if (text == "acs")
            {
                return AppDbContext<Group>.datas.OrderBy(x => x.Capacity).ToList();
            }
            else if (text == "desc")
            {
                return AppDbContext<Group>.datas.OrderByDescending(x => x.Capacity).ToList();
            }

            return null;
        }
    }
}
