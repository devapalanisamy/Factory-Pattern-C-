using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factory_Pattern_C_Sharp.Source;

namespace Factory_Pattern_C_Sharp
{
    class Program
    {
         static void Main(string[] args)
        {
            AnimalFactory animalFactory = new AnimalFactory();
            Animal Dog = animalFactory.MakeAnimal("Cat");
            Console.WriteLine("Aniaml" + Dog.speak() );
        }
    }
}
