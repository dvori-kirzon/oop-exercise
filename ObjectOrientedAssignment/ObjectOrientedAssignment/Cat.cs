using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedAssignment
{
    internal class Cat : Animal, ILand
    {
        private int NumberOfLegs;

        public Cat(EMood mood) : base(true, true, mood)
        {
            this.NumberOfLegs = 4;
        }
        public override void SayHello()
        {
            Console.WriteLine("meow~");
        }
        public override void SayHello(int mood)
        {
            Console.WriteLine(mood == 1 ? "purr, purr" : "hiss");
        }

        public int Number_of_legs() { return this.NumberOfLegs; }
    }
}
