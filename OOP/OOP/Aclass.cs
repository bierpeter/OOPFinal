using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public abstract class Aclass
    {
        public abstract void AonoNado();
    }

    public class AonoNeNado : Aclass
    {
        public override void AonoNado()
        {
            Console.WriteLine("А оно не надо");
        }
    }
}
