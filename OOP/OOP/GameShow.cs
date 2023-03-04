using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class GameShow
    {
        private int i;
        public void listTutors(List<Game> G)
        {
            Console.WriteLine("Список игр:");
            for (i = 0; i < G.Count; i++)
            {
                Console.WriteLine(G[i].GetName());
            }
        }
    }
}
