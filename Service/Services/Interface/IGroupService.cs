using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Service.Services.Interface
{
    public interface IGroupService
    {
        public void Create(Group group);
        public void Edit(Group group);
        public void Delete(Group group);
        Group GetById(int id);
        List<Group> GetAll();
        Group GetGroupByName(string name);
        List<Group> GetGroupByCapacity(int capacity);

        bool UniqueName(string groupname);

    }
}
