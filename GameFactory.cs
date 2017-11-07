using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using Lab2Game;

namespace GameFactory
{
    public class GameFactory
    {

        StreamWriter se;
        XmlSerializer serial;
        List<Game> gameList;
        public string FilePath = @"..\..\game.xml";

        public void CreateGameList()
        {

            gameList = new List<Game>();

            Game P = new Game("Heat", "90", "Hornets", "79");
            gameList.Add(P);
            P = new Game("Spurs", "110", "Lakers", "88");
            gameList.Add(P);
            P = new Game("Celtics", "55", "Caveliers", "70");
            gameList.Add(P);
            P = new Game("OKC", "120", "Phoenix", "90");
            gameList.Add(P);
            P = new Game("Knicks", "80", "Clippers", "77");
            gameList.Add(P);
            P = new Game("76ers", "89", "Spurs", "125");
            gameList.Add(P);



        }

        public void SerializeGameList()
        {


            serial = new XmlSerializer(gameList.GetType());
            se = new StreamWriter(FilePath);
            serial.Serialize(se, gameList);
            se.Close();


        }


        public List<Game> DeserializeGameList(out string resultMessage)
        {
            try
            {
                gameList = new List<Game>();

                StreamReader sr = new StreamReader(FilePath);
                serial = new XmlSerializer(gameList.GetType());
                gameList = (List<Game>)serial.Deserialize(sr);
                sr.Close();

                resultMessage = "success";
                return gameList;


            }

            catch (Exception ex)
            {
                resultMessage = "Exception Thrown: " + ex.Message;
                return null;

            }



        }



    }
}
