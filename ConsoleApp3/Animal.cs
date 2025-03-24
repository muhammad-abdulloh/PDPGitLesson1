using ConsoleApp3.AbstractionLesson;
using ConsoleApp3.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Animal 
    {
        public string Name { get; set; } = "Ot";
        public Gender AnimalGender { get; set; } = Gender.Male;
        public int Legs(int leg)
        {
            return leg;
        }


        public void Oziqlanish(string ovqatName)
        {
            //shu yerda

            Name = "Jayra";

            Console.WriteLine($"{Name} {ovqatName} bilan oziqlanadi");
        }

        public void Action(string action)
        {
            Console.WriteLine(action);
        }

    }
}
