using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace HockeyTeamSystem2
{
    public class Person
    {
        // Define an fully-implemented property with private set
        // for FullName
        //A private set property cannot be assigned a value 
        // in the constructor or an instance method
        public string FullName { get; set; }

        //Define a greedy constructor that takes a fullName as parameter
        //Constructors are used to create meaningful values to the fields/properties of the class

        public Person(string fullName)
        {
            //Validate that the fullName parameter is not null, whitespaces,
            //or an empty string.

            if (string.IsNullOrWhiteSpace(fullName))
            {
                throw new ArgumentNullException("Person FullName cannot be empty, null, or a whitespace");
            }

            //Validate that the fullName parameter contains only 
            //letters a-z and one or space character
            //@"" is literal string  where the characters have no meaning 
            // ^ start of input
            //$ end of input
            //[] range of characters
            //{3,} at least 3
            //{,2} up to 2
            var fullNameCheck = new Regex(@"^[a-zA-Z ]{3,}{,2}$");
            if(!fullNameCheck.IsMatch(fullName))
            {
                throw new ArgumentException("Person FullName must contain atleast 3 characters.");
            }

            //the this keyword refers to the current object 
            //and it is used to access a field or property
            //of the object
            this.FullName = fullName.Trim();
        }
    }
}
