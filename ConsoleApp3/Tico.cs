using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Tico : Car, ICarDoorService
    {

        public string CarName { get; set; } = "Tico";
        public string[] Cars { get; set; } = ["Tico", "Nexia", "Damas", "Malibu"];
        public string[] MoyNames { get; set; } = ["Moy1", "Moy3", "Moy4", "Moy5"];

        public Tico() { }

        public Tico(string name) 
        {
        }


        public void EshikOchish()
        {
            Console.WriteLine("Eshik ochildi");
        }

        public void EshikYopish()
        {
            // logic
        }

        public override void Probeg(string moyname)
        {

            Console.WriteLine(CarName);

            Tico tico1 = new Tico();

            var data = tico1.YoqilgiSarfi100Km("Moy3");

            for (int i = 0; i < Cars.Length; i++)
            {
                if(MoyNames[i] == moyname)
                {
                    Console.WriteLine($"{Cars[i]} - {MoyNames[i]} ");
                }
                
            }
        }

        public override void Toxtash(string avtoName)
        {
            // logic
        }

        public override double YoqilgiSarfi100Km(string avtoName)
        {
            return 34;
        }

        public override void Yurish(string avtoName)
        {
            // logic
        }


    }
}
