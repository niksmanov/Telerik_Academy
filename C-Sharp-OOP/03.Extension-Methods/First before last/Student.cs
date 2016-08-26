using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_before_last
{
    public class Student
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public int Fn { get; set; }

        public string Email { get; set; }

        public List<Marks> Marks { get; set; }

        public int GroupNumber { get; set; }

        public Group Group { get; set; }
    }
}
