using Repository.Data;
using Repository.Repositories.Interface;

namespace Repository.Repositories
{
    public class GroupRepository : BaseRepository<Group>, IGroupRepository
    {

        public bool UniqueName(string groupname)
        {
            return AppDbContext<Group>.datas.Any(x => x.Name.Contains(groupname));
        }

        public List<Group> GetGroupByName(string groupName)
        {
            return AppDbContext<Group>.datas.Where(x => x.Name.ToLower().Contains(groupName)).ToList();
        }

        public List<Group> SortByCapacity(string text)
        {
            if (text == "asc")
            {
                return AppDbContext<Group>.datas.OrderBy(x => x.Capacity).ToList();
            }
            else if (text == "desc")
            {
                return AppDbContext<Group>.datas.OrderByDescending(x => x.Capacity).ToList();
            }

            return null;
        }
        public void Edit(int id, Group group)
        {

            Group ExistGroup = AppDbContext<Group>.datas.FirstOrDefault(x => x.Id == id);

            if (!string.IsNullOrWhiteSpace(group.Name))
            {
                ExistGroup.Name = group.Name;
            }

            if (group.Capacity != null)
                ExistGroup.Capacity = group.Capacity;
        }
    }
}
