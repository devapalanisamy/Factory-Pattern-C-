using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern_C_Sharp.Source
{
    class AnimalFactory
    {
        public Animal MakeAnimal(string animal)
        {
            if (animal.Equals("Lion"))
            {
                return new Lion();
            }
            else if (animal.Equals("Cat"))
            {
                return new Cat();
            }
            else if(animal.Equals("Dog"))
            {
                return new Dog();
            }
            else
            {
                return null;
            }
        }

    }
}
