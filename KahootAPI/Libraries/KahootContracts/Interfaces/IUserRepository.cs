using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahootContracts.DTO
{
    public interface IUserRepository
    {
        User GetUserById(int id);
        List<User> GetAllUsers();

        List<User> GetPlayers(); //GetPlayers where roleId = 1

        List<User> GetHosts(); //GetHosts where roleId = 0


        void CreateUser(User user);
        void SaveChanges();
    }
}
