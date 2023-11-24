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

        void IGroupService.Edit(Group group)
        {
            _grouprepository.Edit(group);
        }

        List<Group> IGroupService.GetAll()
        {
            return _grouprepository.GetAll();
        }

        Group IGroupService.GetById(int id)
        {
            return _grouprepository.GetById(id);
        }

        Group IGroupService.GetGroupByName(string name)
        {
            return _grouprepository.GetGroupByName(name);
        }

        List<Group> IGroupService.GetGroupByCapacity()
        {
            return _grouprepository.GetGroupByCapacity();
        }

        public bool UniqueName(string groupname)
        {
            return _grouprepository.UniqueName(groupname);
        }

        public Group CapacityOfGroup(int capacity)
        {
            return _grouprepository.CapacityOfGroup(capacity);
        }

        public List<Group> GroupByCapacity()
        {
            return _grouprepository.GroupByCapacity();

        }
    }
}
