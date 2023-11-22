using Domain.Models;
using Repository.Data;
using Repository.Repositories.Interface;


namespace Repository.Repositories
{
    public class AccountRepository : BaseRepository<User>, IAccountRepository
    {
        bool IAccountRepository.Login(string email, string password)
        {
            var result = AppDbContext<User>.datas;
            foreach(var item in result)
                if (item.Email == email && item.Password==password)
                {
                    return true;
                }
                return false;
            
           
        }

        void IAccountRepository.Register(User user)
        {
            AppDbContext<User>.datas.Add(user);
        }
    }
}
