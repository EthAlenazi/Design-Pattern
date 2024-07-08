using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_Design_Pattern.Services
{
     class Male : Gender
    {
        public override void HandleMale()
        {
            Console.WriteLine("ConcreteStateA handles request1.");
            Console.WriteLine("ConcreteStateA wants to change the state of the context.");
            this.person.TransitionTo(new Female());
        }

        public override void HandleFemale()
        {
            Console.WriteLine("ConcreteStateA handles request2.");
        }
    }
}
