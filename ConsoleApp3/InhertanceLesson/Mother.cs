using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.InhertanceLesson
{
    internal class Mother : Father
    {
        public void GetMotherName()
        {
            Console.WriteLine("Otasini ismi: ");
            GetName();  
            Console.WriteLine("Kimdur") ;
        }
    }
}
