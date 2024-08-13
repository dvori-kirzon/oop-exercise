using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedAssignment
{
    internal class Frog : Animal, IWater, ILand
    {
        private int NumberOfLegs;

        public Frog(EMood mood) : base(false, false, mood)
        {
            this.NumberOfLegs = 4;
        }
        //public override void SayHello()
        //{
        //    Console.WriteLine("ribbit or croak");
        //}
        public override void SayHello(int mood)
        {
            Console.WriteLine(mood == 1 ? "quack quack quack" : "plop into the water");
        }

        public bool HasGills() { return false; }
        public bool HasLaysEggs() => true; 

        public int Number_of_legs() { return this.NumberOfLegs; }
    }
}
