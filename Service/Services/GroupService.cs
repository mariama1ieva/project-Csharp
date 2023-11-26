using Repository.Repositories;
using Repository.Repositories.Interface;
using Service.Services.Interface;

namespace Service.Services
{
    public class GroupService : IGroupService
    {
        private readonly IGroupRepository _grouprepository;
        public GroupService()
        {
            _grouprepository = new GroupRepository();
        }
        void IGroupService.Create(Group group)
        {
            _grouprepository.Create(group);
        }

        void IGroupService.Delete(Group group)
        {
            _grouprepository.Delete(group);
        }

        List<Group> IGroupService.GetAll()
        {
            return _grouprepository.GetAll();
        }

        Group IGroupService.GetById(int id)
        {
            return _grouprepository.GetById(id);
        }

        public bool UniqueName(string groupname)
        {
            return _grouprepository.UniqueName(groupname);
        }

        public List<Group> GetGroupByName(string name)
        {
            return _grouprepository.GetGroupByName(name);
        }

        public List<Group> SortingByCapacity(string text)
        {
            return _grouprepository.SortByCapacity(text);
        }
        public void Edit(int id, Group group)
        {
            _grouprepository.Edit(id, group);
        }
    }
}
