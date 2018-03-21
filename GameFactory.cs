//Branch_1
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

//example for step 10
namespace GameLibrary
{
    public class GameFactory
    {
        StreamWriter sw;
        XmlSerializer serial;
        List<Game> GameSchedule;
        const string Game_Data = @"..\..\games.xml";

        public void CreateGameList()
        {
            GameSchedule = new List<Game>();

            Game g = new Game("Miami Heat", 106, "New York Knicks", 98);
            GameSchedule.Add(g);

            g = new Game("Portland Trailblazers", 123, "New Jersey Nets", 105);
            GameSchedule.Add(g);

            g = new Game("Saints", 24, "Vikings", 29);
            GameSchedule.Add(g);

            g = new Game("Jaguars", 45, "Steelers", 42);
            GameSchedule.Add(g);

            g = new Game("Red Sox", 7, "Yankees", 11);
            GameSchedule.Add(g);

            g = new Game("Marlins", 6, "Cubs", 12);
            GameSchedule.Add(g);

            serial = new XmlSerializer(GameSchedule.GetType());
            sw = new StreamWriter(Game_Data);
            serial.Serialize(sw, GameSchedule);
            sw.Close();
        }

        public List<Game> De_Serialize()
        {
            GameSchedule = new List<Game>();
            StreamReader sr = new StreamReader(Game_Data);
            serial = new XmlSerializer(GameSchedule.GetType());
            GameSchedule = (List<Game>)serial.Deserialize(sr);
            sr.Close();
            return GameSchedule;
        }
    }
}
