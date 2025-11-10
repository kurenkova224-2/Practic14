using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic14_2
{
    internal class Message
    {
        public virtual void Send()
        {
            Console.WriteLine("Сообщение отправлено.");
        }
    }
}
