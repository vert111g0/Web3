using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahootContracts.DTO
{
    public interface IRoleRepository
    {
        Role GetRoleById(int id);

        List<Role> GetAllRoles();
        void CreateRole(Role role);

        void SaveChanges();

    }
}
