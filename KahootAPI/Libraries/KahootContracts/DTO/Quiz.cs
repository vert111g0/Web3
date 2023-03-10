using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahootContracts.DTO
{
    public class Quiz 
    {
        public Quiz() { }
        public int Id { get; set; }
        public int PinCode { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public int TopicId { get; set; }
        public Topic Topic { get; set; }
        public ICollection<Question> Questions { get; set; }

        public int UserId { get; set; }
        public ICollection<User> Users { get; set; }


    }
}
