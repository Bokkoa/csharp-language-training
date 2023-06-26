


//static void func1(int arg1, int arg2)
//{
//    string result = (arg1 + arg2).ToString();
//    Console.WriteLine(result);
//};

//static void func2(int arg1, int arg2)
//{
//    string result = (arg1 * arg2).ToString();
//    Console.WriteLine(result);
//}

//SomeDelegateFormat f1 = func1;
//SomeDelegateFormat f2 = func2;

//// joining two functions
//SomeDelegateFormat composedDelegate = f1 + f2;  // executed in this order, first f1, then f2

//int arg1 = 10;
//int arg2 = 20;

//Console.WriteLine($"Executing the first delegate");
//f1(arg1, arg2);

//Console.WriteLine($"Executing the second delegate");
//f2(arg1, arg2);

//Console.WriteLine($"Executing the composed delegate");
//composedDelegate(arg1, arg2);

//// erasing the f2 delegate from the composition
//composedDelegate -= f2;
//Console.WriteLine($"Executing the altered composed delegate");
//composedDelegate(arg1, arg2);

//public delegate void SomeDelegateFormat(int arg1, int arg2);
