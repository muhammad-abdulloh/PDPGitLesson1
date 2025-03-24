using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Collectionss
{
    class Student
    {
        public Guid UniqueId { get; } = Guid.NewGuid(); //
        public string Name { get; set; }
        public int Age { get; set; }
        public string UniversityName { get; set; }
        public string Major { get; set; }
        public DateTime JoinDate  { get; set; } = DateTime.Now;
    }
}
