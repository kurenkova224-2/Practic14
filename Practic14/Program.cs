using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Instrument[] band = { new Guitar(), new Drum(), new Instrument() };

            foreach (var i in band)
            {
                i.Play();
            }
        }
    }
}
