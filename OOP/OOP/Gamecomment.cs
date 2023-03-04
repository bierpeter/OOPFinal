using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Gamecomment
    {
        private string comment;
        private GameList GL;
        public Gamecomment(string comment, GameList GL)
        {
            this.comment = comment;
            this.GL = GL;
        }
        public void setComment(string comment)
        {
            this.comment = comment;
        }
        public string getComment()
        {
            return comment;
        }
        public void setGameList(GameList GL)
        {
            this.GL = GL;
        }
        public GameList getGameList()
        {
            return GL;
        }
    }
}
