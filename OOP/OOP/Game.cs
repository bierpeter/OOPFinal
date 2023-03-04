using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Game
    {
        protected string GameName = "!";
        protected string GameVersion = "";
        protected string GameType = "";
        
        public void DevSetting(string GN, string GV, string GT)
        {
            GameName = GN;
            GameVersion = GV;
            GameType = GT;
        }

        public string GetName()
        {
            return GameName;
        }

        public string GetVersion()
        {
            return GameVersion;
        }
        public string GetType()
        {
            return GameType;
        }

        public virtual void GameHelloCW()
        {
            Console.WriteLine("Приветствуем вас на арене смерти");
        }

        public virtual void GameInformation()
        {
            Console.WriteLine("Победитель определяется по количеству очков");
            Console.WriteLine("Ваше очко уходит в зрительный зал");
        }

        private List<Gamecomment> Gc = new List<Gamecomment>();
        public void setGamecomment(Gamecomment gc)
        {
            Gc.Add(gc);
        }
        public List<Gamecomment> getGamecomment()
        {
            return Gc;
        }
        public void delPastJob(Gamecomment gc)
        {
            Gc.Remove(gc);
        }
    }
}
