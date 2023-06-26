

using App03;

var myLambdaClass = new MyLambdaClass();
myLambdaClass.valueChanged += (x) =>
{
    Console.WriteLine($"The value has changed!! {x}");
};


string str;

do
{
    Console.WriteLine("Please enter a value: ");
    str = Console.ReadLine()!;

    if (!str.Equals("Exit"))
    {
        myLambdaClass.Val = str;
    }



} while (!str.Equals("Exit"));


Console.WriteLine("Thanks for use the system");

public delegate void myEventHandler(string value);