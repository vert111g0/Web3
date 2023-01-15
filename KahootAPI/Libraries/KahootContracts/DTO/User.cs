using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahootContracts.DTO
{
    public class User 
    {
        public User() { }
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public Quiz Quiz { get; set; }
        public Role Role { get; set; }
    }
}
