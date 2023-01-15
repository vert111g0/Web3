using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahootInfrastructure.Model
{
    public class UserCorrect
    {
        public int Id { get; set; }
        public string Score { get; set; }
        public Question Question { get; set; }
        public Answer Answer { get; set; }
        public User User { get; set; }
    }
}
