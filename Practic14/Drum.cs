using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic14
{
    internal class Drum : Instrument
    {
        public override void Play()
        {
            Console.WriteLine("Бум-бум!");
        }
    }
}
