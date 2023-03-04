using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Rights
    {
        private string rights;
        private int level = 0;
        public Rights(string rights)
        {
            this.rights = rights;
        }

        public string setlevel(int level)
        {
            if (level > 0)
            {
                this.level = level;
                return "Уровень доступа установлен успешно";
            }
            else
            {
                return "Уровень доступа не установлен";
            }
        }
        public string[] getgamerights()
        {
            string[] array = { rights, level.ToString() };
            return array;
        }
    }
}
