using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Services
{
    internal class Shifrlash
    {
        public string ReverceLetterAndAddDD(string letter)
        {

            return new string(letter.ToCharArray().Reverse().ToArray()) + "DD";
        }
    }
}
