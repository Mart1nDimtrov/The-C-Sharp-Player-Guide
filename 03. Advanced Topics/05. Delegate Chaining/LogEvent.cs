using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Delegate_Chaining
{
    public class LogEvent
    {
        public string Text { get; }

        public LogEvent(string text)
        {
            this.Text = text;
        }
    }
}
