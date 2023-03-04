using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Pasyans : Game, IPasyans
    {
        private int cards;
        private Rights R;
        private List<Session> S;
        public string ratecard;
        public bool flag;
        private string www;

        public Pasyans(string www, string ratecard, bool flag)
        {
            this.www = www;
            this.ratecard = ratecard;
            this.flag = flag;
        }
        public override void GameInformation()
        {
            Console.WriteLine("Плотно задеплоил игру в прод");
        }

        public void setRights(Rights r)
        {
            R = r;
        }
        public Rights getRights()
        {
            return R;
        }

        public void SetS(Session s)
        {
            S.Add(s);
        }
        public void RemS(Session s)
        {
            S.Remove(s);
        }
        public void ClearS()
        {
            S.Clear();
        }

        public List<Session> GetSessions()
        {
            return S;
        }
        
        public void Crush()
        {
            Console.WriteLine("ВАШ ШИНДОУС БУДЕТ УДАЛЕН");
        }
    }
}
