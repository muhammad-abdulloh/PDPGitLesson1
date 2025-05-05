using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.SecondLesson
{
    class User<T>
    {
        public int Id { get; set; }
        public T Name { get; set; }
        public string Password { get; set; }

        public const string Email = "mail@sdfsdf.com";
        public Gender Gender { get; set; }
    }



}
