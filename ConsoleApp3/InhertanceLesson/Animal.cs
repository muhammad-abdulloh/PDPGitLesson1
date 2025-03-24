using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.InhertanceLesson
{
    internal abstract class Animal : ICarDoorService
    {
        public void EshikOchish()
        {
            throw new NotImplementedException();
        }

        public void EshikYopish()
        {
            throw new NotImplementedException();
        }

        public abstract void OvozCHiqarish(string voice);
        
    }
}
