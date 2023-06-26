

//using App03;

//var obj = new EventPublisher();
//obj.valueChanged += delegate (string value)
//{
//    Console.WriteLine($"Hanlder 1: The property value has changed: {value}");
//};

//obj.valueChanged += new MyEventHandler(obj_valueChanged1);
//obj.valueChanged += new MyEventHandler(obj_valueChanged2);


//// .NET Event
//obj.myEvent += delegate (object sender, MyEventArgs e)
//{
//    Console.WriteLine($"The sender class: {sender.GetType()}, property value changed: {e.data}");
//};

//void obj_valueChanged1(string value)
//{
//    Console.WriteLine($"The handler 2 is executing: {value}");
//}

//void obj_valueChanged2(string value)
//{
//    Console.WriteLine($"This is the third handler!!! {value}");
//}


//string str;

//do
//{
//    Console.WriteLine("Enter a value: ");

//    str = Console.ReadLine()!;

//    if (!str.Equals("Exit"))
//    {
//        obj.Val = str;
//    }

//} while (!str.Equals("Exit"));

//Console.WriteLine("The program was exited");

//public delegate void MyEventHandler(string value);