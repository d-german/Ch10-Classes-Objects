using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch10Examples
{
   public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        static public int Count { get; private set; } = 0;
        public Person(string firstName, string lastName):this()
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public Person()
        {
            Person.Increment();
        }

        private static void Increment()
        {            
            Count++;
        }

    }
}
