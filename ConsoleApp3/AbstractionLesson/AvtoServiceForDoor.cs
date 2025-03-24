using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.AbstractionLesson
{
    internal interface AvtoServiceForDoor : MyAvtoMotorService
    {
        public void EshikOchish();
        public void EshikYopish();
        public void OynaOchish();
        public void OynaYopish();
    }
}
