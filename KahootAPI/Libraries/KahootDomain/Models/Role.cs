using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahootDomain.Models
{
    public class Role 
    {
        public Role() { }
        public int Id { get; set; }
        public string Host { get; set; }
        public string Player { get; set; }
        public int UserId { get; set; }
        public ICollection<User> Users { get; set; }

    }
}
