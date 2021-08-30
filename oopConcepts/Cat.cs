using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopConcepts
{
    //encapsulation concept in oop 
    class Cat
    {
        private string mood;
        private bool hungry;
        private int energy;

        public int Energy
        {
            get
            {
                return energy;
            }

            set
            {
                energy = value;
            }
        }

        public bool Hungry
        {
            get
            {
                return hungry;
            }

            set
            {
                hungry = value;
            }
        }

        public string Mood
        {
            get
            {
                return mood;
            }

            set
            {
                mood = value;
            }
        }

        private static void meow()
        {
            Console.WriteLine("meow");
        }
        //virtual for polymorphism concept in oop
        public virtual int EnergyChanger()
        {
            return 0;
        }
        public virtual  bool  HungryChanger()
        {
            return false;
        }
        public virtual string MoodChanger()
        {
            return "good";
        }
    }
}
