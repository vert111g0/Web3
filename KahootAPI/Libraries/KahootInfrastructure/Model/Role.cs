using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahootInfrastructure.Model
{
    public class Role
    {
        public int Id { get; set; }
        public string Host { get; set; }
        public string Player { get; set; }
        public int UserId { get; set; }
        public ICollection<User> Users { get; set; }
    }
}
