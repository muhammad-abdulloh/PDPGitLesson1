using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.OOPInheritance
{
     class Animal : IAnimal, IAnimalService
    {
        public int AnimalLegCount()
        {
            // logika
            return 0;
        }

        public void MethodA()
        {
            throw new NotImplementedException();
        }

        public string MethodAB(string name)
        {
            throw new NotImplementedException();
        }

        public string MethodAC(string name)
        {
            throw new NotImplementedException();
        }

        public void MethodB()
        {
            throw new NotImplementedException();
        }

        public void MethodC(string nimadur)
        {
            throw new NotImplementedException();
        }
    }
}
