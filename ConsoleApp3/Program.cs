using ConsoleApp3;
using ConsoleApp3.Collectionss;
using ConsoleApp3.InhertanceLesson;
using System.Collections;
using System.Data;

class Program
{
    
    static void Main(string[] args)
    {
        // sortedlist bilan ishlash
        // tartiblab
        SortedList<string, string> numbers = new SortedList<string, string>();
        
        // tartib 

        numbers.Add("D", "Four");
        numbers.Add("A", "Three");
        numbers.Add("C", "One");
        numbers.Add("B", "Two");

        Console.WriteLine(numbers["C"]);

        //foreach (var item in numbers)
        //{
        //    System.Console.WriteLine(item.Key + " " + item.Value);
        //}
        Console.WriteLine("So'zni kiriting: ");
        var data = Console.ReadLine();
        CHeckLAtter(data);

    }

    static void CHeckLAtter(string value)
    {
        Dictionary<string, string> sozlar = new Dictionary<string, string>()
        {
            { "olma", "Apple" },
            { "uzum", "Grapes" },
            { "banan", "Banana" },
        };

        foreach(var item in sozlar)
        {
            if(item.Key == value)
            {
                Console.WriteLine(item.Value);
            }
        }
    }
}