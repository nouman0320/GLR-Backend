using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GLR_Backend_API_NET_CORE.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Course> Courses { get; set; }
        public ICollection<Teacher> Teachers { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}
