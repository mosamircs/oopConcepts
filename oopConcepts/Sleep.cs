using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopConcepts
{
    //inheritance concept in oop
    class Sleep:Cat
    {
        //polymorphism concept in oop
        override
        public int EnergyChanger()
        {
            Energy++;
            return Energy;
        }
        override
        public bool HungryChanger()
        {
            Hungry = true;
            return Hungry;
        }
    }
}
