using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GLR_Backend_API_NET_CORE.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Course> Courses { set; get; }
        public Department department { set; get; }

    }
}
