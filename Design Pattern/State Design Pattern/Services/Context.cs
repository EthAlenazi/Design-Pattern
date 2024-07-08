using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_Design_Pattern.Services
{
    class Person
    {
        private Gender gender = null;

        public Person(Gender gender)
        {
            this.TransitionTo(gender);
        }

        public void TransitionTo(Gender sex)
        {
            Console.WriteLine($"Context: Transition to {sex.GetType().Name}.");
            this.gender = sex;
            this.gender.SetContext(this);
        }

        public void Request1()
        {
            this.gender.HandleFemale();
        }

        public void Request2()
        {
            this.gender.HandleMale();
        }

      
    }
}
