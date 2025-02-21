using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Homeworks
{
    internal class HomeworkMethod20
    {
        public int Task2(int number)
        {
            return number * 2;
        }

        public void Task3(double number)
        {
            if (number > 0)
            {
                Console.WriteLine("Musbat son");
            }
            else if (number == 0)
            {
                Console.WriteLine("Neytral son yoki Manfiy ham emas Musbat ham emas");
            }
            else
            {
                Console.WriteLine("Manfiy son");
            }
        }

        public double Task4(double number)
        {
            return Math.Round(number);
        }

        public double Task5(double number)
        {
            return number * number;
            Console.WriteLine("NIma gap kalla pishtimi");
            return Math.Pow(number, 2);
        }

        public void SayHello(string name, int age)
        {
            Console.WriteLine($"Salom {name}, {age} yoshing bilan tabriklaymiz");
        }

        public void Task9()
        {
            while (true)
            {
                Console.Write("Passwordni kiriting: ");
                // qaysidur son oraligidagi son bo'lishi mumkin
                // imnnoy password  1234zz
                var password = Console.ReadLine();

                if (password == null || password != "S1234zz")
                {
                    Console.WriteLine("Siz notog'ri parol kiritdingiz! ");
                } 
                else if (password == "1234zz")
                {
                    Console.WriteLine("Tizimga hush kelibsiz! ");
                    break;
                }
            }
        }

        public int SumNumbers(int[] array)
        {
            // logika
            return array[0];
        }

        public int Task10(int[] numbers)
        {
            int number = numbers[0];

            foreach (int i in numbers)
            {
                if(number >= i) number = i; 
            }

            return number;
        }

        public int Task11(int[][] numbers)
        {
            

            return numbers.Length;
        }

    }
}
