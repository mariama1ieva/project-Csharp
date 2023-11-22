using Service.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Service.Services
{
    public class GroupService : IGroupService
    {
        private  readonly IGroupService _groupService;
        public GroupService()
        {
            _groupService = new GroupService();
        }
        void IGroupService.Create(Group group)
        {
            _groupService.Create(group);
        }

        void IGroupService.Delete(Group group)
        {
            _groupService.Delete(group);
        }

        void IGroupService.Edit(Group group)
        {
            _groupService.Edit(group);
        }

        List<Group> IGroupService.GetAll()
        {
           return _groupService.GetAll();
        }

        Group IGroupService.GetById(int id)
        {
            return _groupService.GetById(id);
        }

        Group IGroupService.SearchByName(string name)
        {
           return _groupService.SearchByName(name);
        }

        List<Group> IGroupService.SortingByCapacity(int capacity)
        {
           return _groupService.SortingByCapacity(capacity);
        }
    }
}
