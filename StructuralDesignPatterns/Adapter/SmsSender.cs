using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class SmsSender
    {
        public void SendSMS(string to, string text)
        {
            Console.WriteLine($"Sending SMS to: {to}. Text: {text}");
        }
    }
}
