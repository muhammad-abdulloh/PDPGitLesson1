using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.OOPInheritance
{
    interface IAnimalService : IExternalInterface
    {
        public void MethodA();
        public void MethodB();
        public void MethodC(string nimadur);
    }
}
