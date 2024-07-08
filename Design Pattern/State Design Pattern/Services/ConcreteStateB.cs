using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_Design_Pattern.Services
{
    class Female : Gender
    {
        public override void HandleFemale()
        {
            Console.Write("ConcreteStateB handles request1.");
        }

        public override void HandleMale()
        {
            Console.WriteLine("ConcreteStateB handles request2.");
            Console.WriteLine("ConcreteStateB wants to change the state of the context.");
            this.person.TransitionTo(new Male());
        }
    }
}
