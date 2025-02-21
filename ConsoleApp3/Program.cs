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
            Console.WriteLine("NIma gap");
 //cw   

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