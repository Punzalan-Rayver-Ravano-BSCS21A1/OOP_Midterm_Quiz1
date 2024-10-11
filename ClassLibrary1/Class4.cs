using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Mammal
    {
        public string Eat()
        {
            return "Animal is eating.";
        }
        public string Talk()
        {
            return "Human is talking.";
        }
    }

    public class Human : Mammal 
    {
        public string GiveBirth()
        {
            return "Mammal is giving birth.";
        }
    }
}
