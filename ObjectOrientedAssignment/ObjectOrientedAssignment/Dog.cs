using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedAssignment
{
    internal class Dog:Animal,ILand
    {
        private int NumberOfLegs;

        public Dog(EMood mood) : base(true, true, mood)
        {
            this.NumberOfLegs = 4;
        }
        public override void SayHello()
        {
            Console.WriteLine("wagging theirtails");
        }
        public override void SayHello(int mood)
        {
            Console.WriteLine(mood == 1 ? "bark loudly" : "whooping");
        }

        public int Number_of_legs() { return this.NumberOfLegs; }
    }
}
