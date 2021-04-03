using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructorOverloading
{
    class Person
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }

        public Person(string firstName, string middleName, string lastName)
        {
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
        }

        public Person(string middleName, string lastName)
        {
            MiddleName = middleName;
            LastName = lastName;
        }

        public Person()
        {
            //this is default constructor
        }

        public string getFullName()
        {
            string myName=FirstName+" "+MiddleName+" "+LastName;
            return myName;
        } 
    }
}
