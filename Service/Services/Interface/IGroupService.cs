namespace Service.Services.Interface
{
    public interface IGroupService
    {
        public void Create(Group group);
        public void Edit(Group group);
        public void Delete(Group group);
        Group GetById(int id);
        List<Group> GetAll();
        List<Group> GetGroupByName(string name);
        bool UniqueName(string groupname);
        List<Group> SortingByCapacity(string text);
        bool ExistId(int id);

        void Edit(int id, Group group);

    }
}
