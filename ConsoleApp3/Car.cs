using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ConsoleApp3
{
    internal abstract class Car
    {
        public abstract void Yurish(string avtoName);
        public abstract void Toxtash(string avtoName);
        public abstract void Probeg(string moyname);
        public abstract double YoqilgiSarfi100Km(string avtoName);
    }
}