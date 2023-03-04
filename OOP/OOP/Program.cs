namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            string www = "ООП.КОРПОРЕЙШЕН ТОЧКА КОМ";
            string ratecard = "36";
            bool flag = false;
            Pasyans pas = new Pasyans(www, ratecard, flag);
            Game pas2 = new Pasyans2();
            Game pas3 = new Pasyans3();
            Console.WriteLine("Полиформизм");
            List<Game> Games = new List<Game>();
            Games.Add(pas);
            Games.Add(pas2);
            Games.Add(pas3);
            foreach (Game game in Games)
            {
                game.GameInformation();
            }

            //Ассоциация
            Rights rights = new Rights("Разнарабочий");
            rights.setlevel(3);
            pas.setRights(rights);
            Console.WriteLine("Запрашиваем права");
            Console.WriteLine(pas.getRights().getgamerights()[0]);

            //Агрегация
            Pasyans pasA0 = new Pasyans("Урул", "Право", true);
            Pasyans pasA1 = new Pasyans("Урул1", "Право1", false);
            Pasyans pasA2 = new Pasyans("Урул2", "Право2", true);
            GameList GL = new GameList(1337);
            GL.GameListAdd(pasA0);
            GL.GameListAdd(pasA1);
            GL.GameListAdd(pasA2);

            //Композиция
            Console.WriteLine("Композиция");
            Gamecomment Gm = new Gamecomment("Повезло-повезло", GL);
            Gamecomment Gma = new Gamecomment("Повезло-повезло!", GL);
            pasA0.setGamecomment(Gm);
            pasA0.setGamecomment(Gma);

            List<Gamecomment> Gm1 = pasA0.getGamecomment();
            foreach (Gamecomment game1 in Gm1)
            {
                Console.WriteLine(game1.getComment());
            }
            GL.GameListRemove(pasA0);

            //Зависимость
            GameShow GS = new GameShow();
            List<Game> GSM = new List<Game>();
            GSM.Add(pasA0);
            GSM.Add(pasA1);
            GSM.Add(pasA2);
            GS.listTutors(Games);
        }
    }
}