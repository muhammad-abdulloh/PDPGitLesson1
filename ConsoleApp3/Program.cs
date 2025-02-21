using ConsoleApp3;
using ConsoleApp3.Homeworks;
using ConsoleApp3.Services;
using System.Diagnostics;
using System.Net.WebSockets;
using System.Text;

public class Program
{
    public static void Main(string[] args)
    {

        try
        {
            int[] numbers = new int[5];

            for (int i = 0; i < numbers.Length; i++)
            {
                Random random = new Random();

                numbers[i] = random.Next(1, 5);
            }


            bool youWin = true;

            while (youWin)
            {
                Console.Write("O'ylagan sonni kiriting: ");
                int number = int.Parse(Console.ReadLine());

                foreach (int x in numbers)
                {
                    if (number == x)
                    {
                        Console.WriteLine("Siz yutdingiz! ");
                        youWin = false;
                        break;
                    }
                }
                //
            }

            while (youWin)
            {
                Console.Write("O'ylagan sonni kiriting: ");
                int number = int.Parse(Console.ReadLine());

                foreach (int x in numbers)
                {
                    if (number == x)
                    {
                        Console.WriteLine("Siz yutdingiz! ");
                        youWin = false;
                        break;
                    }
                }
                //
            }

        }
        catch (Exception ex) 
        {
            Console.WriteLine("Qandaydur xatolik chiqdi: ");
        }

    }

    // clientilarni ismlari
    public static void Main2(string[] ismlar)
    {
        for(int i = 0; i < ismlar.Length; i++)
        {
            Random rand = new Random(); 
            Console.WriteLine(ismlar[i] + $" {rand.Next(50, 200)}");
        }
    }
}