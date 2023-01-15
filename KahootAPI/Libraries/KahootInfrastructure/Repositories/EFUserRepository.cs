using KahootContracts.DTO;
using KahootInfrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace KahootInfrastructure.Repositories
{
    public class EFUserRepository : IUserRepository
    {
        private readonly KahootContext _dbContext;
        private readonly DbSet<KahootContracts.DTO.User> _users;

        public EFUserRepository(KahootContext dbContext)
        {
            _dbContext = dbContext;
            _users = _dbContext.Users;
        }

        public List<User> GetAllUsers()
        {
            return _users.ToList();
        }

        public List<User> GetHosts()
        {
            throw new NotImplementedException();
        }

        public List<User> GetPlayers()
        {
            throw new NotImplementedException();
        }

        public User GetUserById(int id)
        {
            throw new NotImplementedException();
        }

        public void CreateUser(User user)
        {
            
        }

        public void SaveChanges()
        {
            _dbContext.SaveChanges();
        }
    }
}
