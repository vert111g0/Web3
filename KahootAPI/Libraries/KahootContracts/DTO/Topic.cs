﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahootContracts.DTO
{
    public class Topic 
    {
        public Topic() { }
        public int Id { get; set; }
        public string Description { get; set; }

        public ICollection<Quiz> Quizes { get; set; }


    }
}
