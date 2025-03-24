using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.InhertanceLesson
{
    internal class User
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Role UserRole { get; set; }
    }

    internal enum Role
    {
        User, 
        Admin,
        Moderator,
        CallOperator,
        Officer,
        SuperAdmin
    }

    internal enum StatusCodes
    {
        Success = 0,
        NotFound = 1,
    }
}
