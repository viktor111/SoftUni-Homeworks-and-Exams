using System;
using System.Collections.Generic;
using System.Text;

namespace _04Concatenate_Data
{
   public class Person
    {
        string firstName;
        string lastName;
        int age;
        string town;

        public Person(string aFirstName, string aLastName, int aAge, string aTown)
        {
            firstName = aFirstName;
            lastName = aLastName;
            age = aAge;
            town = aTown;
        }
    }
}
