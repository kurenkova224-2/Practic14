using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic14_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Message[] messages = { new Email(), new SMS(), new Message() };
            foreach (var m in messages)
                m.Send();
        }
    }
}
