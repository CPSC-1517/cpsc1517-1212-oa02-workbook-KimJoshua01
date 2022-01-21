using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDemo02
{   // A static class prevents the creation of an object of the class
    // Consoloe.WriteLine(), Console.ReadLine()
    // Math.Round(), Math.Pow()
    internal class Utilities
    {
        public static bool IsValidNameLength(string name, int minLength)
        {
            bool isValid = false;
            if(string.IsNullOrEmpty(name) && name.Length >= minLength)
            {
                isValid = true;
            }
            return isValid;
        }
    }
}
