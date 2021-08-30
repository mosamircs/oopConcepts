using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopConcepts
{
    class Program
    {
        static void Main(string[] args)
        {
            //abstraction concept in oop
            Cat cat1 = new Cat();
            cat1.Energy=10;
            cat1.Hungry = true;
            cat1.Mood = "good";
            Console.WriteLine(cat1.Energy);
            Console.WriteLine(cat1.Hungry);
            Console.WriteLine(cat1.Mood);

        }
    }

}
