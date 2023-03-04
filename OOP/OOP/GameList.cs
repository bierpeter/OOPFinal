using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class GameList
    {
        private int number;
        private List<Game> G = new List<Game>();
        public GameList(int number)
        {
            Console.WriteLine("Коллекция игр успешно создана");
            this.number = number;
        }

        public void GameListAdd(Game g)
        {
            G.Add(g);
        }
        public void GameListRemove(Game g)
        {
            G.Remove(g);
        }
        public void GameListClear(Game g)
        {
            G.Clear();
        }
    }
}
