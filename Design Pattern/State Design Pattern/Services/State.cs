using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_Design_Pattern.Services
{
    abstract class Gender
    {
        protected Person person;

        public void SetContext(Person person)
        {
            this.person = person;
        }

        public abstract void HandleFemale();

        public abstract void HandleMale();

      
    }
}
