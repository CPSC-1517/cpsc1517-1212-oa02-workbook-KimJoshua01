using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HockeyTeamSystem2
{
    public class HockeyPlayer : Person //class
    {
        private int _primaryNumber;
        public PlayerPosition Position { get; private set; }
        public int PrimaryNumber  // fully implemented Property
        {
            get { return _primaryNumber; }
            private set
            {
                //Validate PrimaryNumber is between 1 and 99

                if (value < 1 || value > 99)
                    throw new ArgumentException("HockeyPlayer PrimaryNumber must be between 1 and 99 ");

                _primaryNumber = value;
            }
        }

        // Define a greedy constructor 
        public HockeyPlayer(string fullName, int primaryNumber, PlayerPosition position)
            : base(fullName)
        {
            PrimaryNumber = primaryNumber;
            Position = position;
        }

        // Override the ToString() method to return a CSV

        public override string ToString()
        {
            return $"{FullName},{PrimaryNumber},{Position}";
        }












    }

}
