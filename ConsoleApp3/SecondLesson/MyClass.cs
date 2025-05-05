using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.SecondLesson
{
    class MyClass : MyAbstractClass
    {
        public override void Add()
        {
            //sdfhsgjksd
        }

        public override void Add2(int number)
        {
            Console.WriteLine("asdads");
        }
    }

    abstract class MyAbstractClass()
    {
        // gdg
        public abstract void Add();
        public abstract void Add2(int number);
        public virtual void Add3(int number)
        {
            Console.WriteLine("fsdfsn");
        }
    }
}
