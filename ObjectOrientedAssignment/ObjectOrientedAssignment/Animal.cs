using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedAssignment
{
    enum EMood {MOOD_HAPPY = 1, MOOD_SCARE = 2 }
    internal abstract class Animal
    {
        protected bool Mammals;  //יונקים
        protected bool Carnivorous; //טורפים

        //public const int MOOD_HAPPY = 1; //מצב רוח שמח-מוגדר 1

        //public const int MOOD_SCARE = 2; //מצב רוח מפוחד-מוגדר 2

        protected EMood mood; //מצב רוח

        public Animal(bool mammals, bool carnivorous, EMood mood)
        {
            Mammals = mammals;
            Carnivorous = carnivorous;
            this.mood = mood;
        }

        public virtual void SayHello()
        {

        }

        public abstract void SayHello(int mood);
       
        
        public bool IsMammals()
        {
            return this.Mammals;
        }
        public void SetMammals(bool mammals)
        {
            this.Mammals = mammals;
        }
        public bool IsCarnivorous()
        {
            return this.Carnivorous;
        }
        public void SetCarnivorous(bool carnivorous)
        {
            this.Carnivorous = carnivorous;
        }
    }
}
