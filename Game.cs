using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Test Modified 11/7/17

namespace Lab2Game
{
    public class Game
    {

       public string Team1 { get; set; }
       public string Team1Score { get; set; }
       public string Team2 { get; set; }
       public string Team2Score { get; set; }

        public Game() { }

        public Game( string Team1,  string Team1Score, string Team2, string Team2Score)
        {

            this.Team1 = Team1;
            this.Team1Score = Team1Score;
            this.Team2 = Team2;        
            this.Team2Score = Team2Score;

            


        }

        

        public override string ToString()
        {

            return Team1 + " " + " " + "(" + Team1Score+")"  +" " + " - " + " "+ Team2 + " " + " " + "("+ Team2Score+")";
        }



    }
}
