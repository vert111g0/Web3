using KahootContracts.DTO;
using KahootInfrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace KahootInfrastructure.Repositories
{
    public class EFRoleRepository : IRoleRepository
    {
        private readonly KahootContext _dbContext;
        private readonly DbSet<KahootContracts.DTO.Role> _roles;

        public EFRoleRepository(KahootContext dbContext)
        {
            _dbContext = dbContext;
            _roles = _dbContext.Roles;
        }

        public List<Role> GetAllRoles()
        {
            return _roles.ToList();
        }

        public Role GetRoleById(int id)
        {
            return _roles.FirstOrDefault(x => x.Id == id);
        }

        public void CreateRole(Role role)
        {
            _roles.Add(role);
        }

        public void SaveChanges()
        {
            _dbContext.SaveChanges();
        }
    }
}
