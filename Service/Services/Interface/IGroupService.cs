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
        List<Group> GetGroupByCapacity();
        List<Group> GroupByCapacity();

        bool UniqueName(string groupname);

        Group CapacityOfGroup(int capacity);

    }
}
