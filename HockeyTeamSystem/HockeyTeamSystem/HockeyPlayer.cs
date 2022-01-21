using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HockeyTeamSystem
{
    public class HockeyPlayer //class
    {
        private string _fullName; // Private backing field
        private int _primaryNumber;
        public PlayerPosition Position { get; private set; } 
        public int PrimaryNumber  // fully implemented Property
        { 
            get { return _primaryNumber; } 
            private set 
            {   
                //Validate PrimaryNumber is between 1 and 99

                if (value < 1 || value > 99 )
                throw new ArgumentException("HockeyPlayer PrimaryNumber must be between 1 and 99 ");

                _primaryNumber = value; 
            }
        }

        // Define an fully-implemenetd property for FullName
        // with readonly information
        // validate fullName is not null, not empty, abnd not a whitespace 
        // validate full name contains at minimum 3 characters


        public string FullName
        {
            get { return _fullName; }
            private set
            {
                if(string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("HockeyPlayer FullName must not be null and white spaces");
                }
                if(value.Trim().Length < 3)
                {
                    throw new ArgumentException("full name must contain minimum of 3 characters");
                }
                _fullName = value.Trim();
            }
        }

        // Define a greedy constructor 
        public HockeyPlayer(string fullName, int primaryNumber, PlayerPosition position)
        {
            FullName = fullName;
            PrimaryNumber = primaryNumber;
            Position = position;
        }

        // Override the ToString() method to return a CSV

        public override string ToString()
        {
            return $"{FullName}, {PrimaryNumber}, {Position}";
        }












    }

}
