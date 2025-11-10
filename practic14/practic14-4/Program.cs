using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic14_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes = { new Circle(), new Triangle() };
            foreach (var s in shapes) 
                Console.WriteLine(s.Draw());
        }
    }
}
