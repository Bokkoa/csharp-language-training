

using System.ComponentModel;

namespace App04
{
    public class Document : IOperations, IMessenger, INotifyPropertyChanged
    {
        private string name;

        public string DocumentName { 
            get { return name; }
            set
            {
                name = value;
                NotifyPropChanged("DocumentName");
            }
        }

        public Document(string s)
        {
            name = s;
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        private void NotifyPropChanged(string propName)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }

        public void Load()
        {
            Console.WriteLine("THis method is for load a document");
        }

        public bool NeedSave()
        {
            return false;
        }

        public void Save()
        {
            Console.WriteLine("THis method is for save a document");
        }

        public void SendMail()
        {
            Console.WriteLine("Sending electronic mail by gmail");
        }

        public void SendNotification()
        {
            Console.WriteLine("Sending text message by iphone");
        }

        public void SendSms()
        {
            Console.WriteLine("Sending notification by login");
        }
    }
}
