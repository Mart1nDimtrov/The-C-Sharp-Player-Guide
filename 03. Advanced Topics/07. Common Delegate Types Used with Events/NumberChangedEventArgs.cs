using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Common_Delegate_Types_Used_with_Events
{
    public class NumberChangedEventArgs :EventArgs
    {
        public int First { get; set; }
        public int Second { get; set; }
        public NumberChangedEventArgs(int first, int second)
        {
            this.First = first;
            this.Second = second;
        }

        public void ChangeNumbers(int first, int second)
        {
            OnNumbersChanged(first, second);
            this.First = first;
            this.Second = second;
        }

        public event EventHandler<NumberChangedEventArgs> NumbersChanged;

        public void OnNumbersChanged(int first, int second)
        {
            if (NumbersChanged != null)
            {
                NumbersChanged(this, new NumberChangedEventArgs(first, second));
            }
        }
    }
}
