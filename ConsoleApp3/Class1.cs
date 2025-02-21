using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{

    internal class Class1
    {
        // protsedura
        // void method

        int number2 = 6;

        public int number3; // fields
        public string Name { get; set; } // property

        public void AddNumber(string name)
        {
            int number = 5;

            Console.WriteLine("RAqamlar qoshilsin");
        }
    

    int misol27()
        {
            int a;
            Console.Write("Soniya kiriting: ");
            a = Convert.ToInt32(Console.ReadLine());

            if (a >= 60)
            {
                if (a >= 3600)
                {
                    if (a >= 3600 * 24)
                    {

                        int days = a / (3600 * 24);
                        int hours = (a % (3600 * 24)) / 3600;
                        int minutes = (a % 3600) / 60;
                        int seconds = a % 60;

                        Console.WriteLine($"Kunlar: {days}, Soat: {hours}, Minut: {minutes}, Soniyalar: {seconds}");
                    }
                    else
                    {
                        int hours = a / 3600;
                        int minutes = (a % 3600) / 60;
                        int seconds = a % 60;

                        Console.WriteLine($"Soat: {hours}, Minut: {minutes}, Soniyalar: {seconds}");
                    }
                }
                else
                {

                    int minutes = a / 60;
                    int seconds = a % 60;

                    Console.WriteLine($"Minut: {minutes}, Soniyalar: {seconds}");
                }
            }
            else
            {
                Console.WriteLine($"Soniyalar: {a}");
            }

            return 0;
        }

    }
}