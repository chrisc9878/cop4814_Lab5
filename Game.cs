using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary
{
    public class Game
    {
        //Properties 
        public string team1Name { get; set; }
        public string team2Name { get; set; }
        public int team1score { get; set; }
        public int team2score { get; set; }

        //Default constructor
        public Game()
        {

        }

        //Constructor with 4 parameters that initializes the class properties from the parameter values
        public Game(string team1, int team1score, string team2, int team2score)
        {
            this.team1Name = team1;
            this.team1score = team1score;
            this.team2Name = team2;
            this.team2score = team2score;
        }

        //Add a public ToString method to  display the info of the teams 
        public override string ToString()
        {
            //use string.format method
            return string.Format("{0} ({1}) - {2} ({3})",
                team1Name, team1score, team2Name, team2score);
        }
    }
}
