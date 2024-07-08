using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace State_Design_Pattern.Services
{
    internal class HandelReq
    {
        private string GetGender()
        {
            string data = string.Empty;
            do
            {
                Console.WriteLine("Please Enter your Gender {F} or {M}");
                data = Console.ReadLine();
            }
            while (!string.IsNullOrEmpty(data));

            return data;
        }

        public Person GetPersonGender()
        {
            try
            {
                var data = GetGender();
                //Avoid useing {ToUpper ||ToLower } when comparing string and use this way
                //better performance and accuracy
                if (data.Equals("F", StringComparison.OrdinalIgnoreCase))
                {
                    return new Person(new Female());
                }
                else if (data.Equals("M", StringComparison.OrdinalIgnoreCase))
                {
                    return new Person(new Female());
                }
                GetGender();
                return new Person(new Female());
            }
            catch {
                
                GetGender();
                return new Person(new Female());
            }


        }


    }
}
