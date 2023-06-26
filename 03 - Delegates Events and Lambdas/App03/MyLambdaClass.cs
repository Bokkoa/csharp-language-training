

namespace App03
{
    public class MyLambdaClass
    {
        private string theVal;

        public event myEventHandler valueChanged;

        public string Val
        {
            set { 
                this.theVal = value;
                this.valueChanged(value);
            }
        }
    }
}
