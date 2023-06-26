using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// USED BY EVENTS AND DELEGATE EXAMPLES
namespace App03
{
    public class EventPublisher
    {
        private string theVal;

        //public event MyEventHandler valueChanged;
        public event EventHandler<MyEventArgs> myEvent;
        public string Val
        {
            set { 
                this.theVal = value;
                //this.valueChanged(theVal);
                this.myEvent(this, new MyEventArgs { data = theVal });
            }
        }
    }
}
