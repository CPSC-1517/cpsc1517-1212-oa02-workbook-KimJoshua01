using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListManipulationDemo
{
    public class HockeyTeam
    {
        public string TeamName { get; private set; }
        public List<HockeyPlayer> Players { get; } = new List<HockeyPlayer>();

        
        public HockeyTeam (string teamName)
        {
            TeamName = teamName;
            Players = new List<HockeyPlayer>
            {
                new HockeyPlayer{PlayerName="Leon Draisatil", GamesPlayed=46,Goals=33,Assists=32},          //index 0
                new HockeyPlayer{PlayerName="Connor McDavid", GamesPlayed=45,Goals=40,Assists=40},          //index 1
                new HockeyPlayer{PlayerName="Ryan Nugent-Hopkins", GamesPlayed=39,Goals=6,Assists=28},      //index 2
                new HockeyPlayer{PlayerName="Zach Hyman", GamesPlayed=30,Goals=14,Assists=13},              //index 3
                new HockeyPlayer{PlayerName="Jesse Puljujarvi", GamesPlayed=44,Goals=11,Assists=15},        //index 4
                new HockeyPlayer{PlayerName="Evan Bouchard", GamesPlayed=46,Goals=9,Assists=17},            //index 5
                new HockeyPlayer{PlayerName="Darnell Nurse", GamesPlayed=39,Goals=5,Assists=15},            //index 6
                new HockeyPlayer{PlayerName="Tyson Barrie", GamesPlayed=40,Goals=3,Assists=14},             //index 7
            };
        }
        public List<HockeyPlayer>Split(int startIndex)
        {
            List<HockeyPlayer> splittedPlayers = new();
            for(int index = startIndex; index < Players.Count; index ++)
            {
                splittedPlayers.Add(Players[index]);
            }
            Players.RemoveRange(startIndex,Players.Count - startIndex + 1);
            return splittedPlayers;
           
        }
        //create a new hockeyteam instance
        //display all the players in the team
        //remove players left in the team
        //display all the players left in the team
        //display all the players removed from the team
    }
}
