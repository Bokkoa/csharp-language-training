

using App04;
using System.ComponentModel;

var document = new Document("Elden ring");


if(document is IOperations)
{
    document.Save();
}

IOperations ops = document as IOperations;

if( ops != null && ops is not null)
{
    ops.Load();
}

document.SendNotification();
document.SendSms();
document.SendMail();

IMessenger messenger = document as IMessenger; 
if( messenger != null)
{
    messenger.SendSms();
}

document.PropertyChanged += delegate (object sender, PropertyChangedEventArgs e)
{
    Console.WriteLine($"The changed property is {e.PropertyName}");
};

document.DocumentName = "Elden ring";
