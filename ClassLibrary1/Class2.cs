using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Dog
    {
        public string Name{ get; set;}
        public int Age {  get; set;}
        public string Breed { get; set;}
        public string MakeSound()
        {
            return "Woof!";
        }
    }
    public class Cat
    {
        public string MakeSound()
        {
            return "Meow!";
        }
    }
    public class Animal
    {
        public string MakeSound()
        {
            return "Generic animal sound";
        }
    }

}
