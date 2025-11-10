using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic14_5
{
    internal class Archer : Player
    {
        public override void Attack()
        {
            Console.WriteLine("Стреляю из лука!");
        }
    }
}
