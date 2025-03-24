using ConsoleApp3;
using System;
using System.Collections.Immutable;

class Program
{
    static void Main(string[] args)
    {
        ArifmeticAmallar amal = new ArifmeticAmallar();

        var data2 = amal.AddNumber(2, 4);

        var data4 = amal.AddNumber(2, 4, 90, 22, 34, 4,3 ,3,4, 3,43,4);

    }

}

class  ArifmeticAmallar
{
    public ArifmeticAmallar()
    {

    }
    public string Name { get; set; }
    public ArifmeticAmallar(string nimadur)
    {
        Name = nimadur;
    }

    public int AddNumber(params int[] numbers)
    {
        // ildizdan chiqaradi

        
        Math.Sqrt(5);
        // darajaga oshiradi
        Math.Pow(5, 2);
        // minus sonni musbatga aylantirberadi
        Math.Abs(-34);
        return numbers.Sum();
    }

    

}