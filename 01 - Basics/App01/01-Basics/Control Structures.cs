///*
 
//    This alg handles the basic math oprations between two numbers
 
// */
//Console.WriteLine("Pls put the first number: ");
//var firstNumberString = Console.ReadLine();


////if(firstNumberString == null || firstNumberString == "")
////{
////    Console.WriteLine("Did you enter a null value, the program end.");
////    return;
////}


//if (string.IsNullOrEmpty(firstNumberString)){
//    Console.WriteLine("Did you enter a null value, the program end.");
//    return;
//}

//// alg to evaluate if a text is a number
//int firstNumberInt = 0;
//if (!int.TryParse(firstNumberString, out firstNumberInt))
//{
//    Console.WriteLine("The entered value is not a number");
//    return;
//}


//if(firstNumberInt >= 100) {
//    Console.WriteLine("Your number is higgher than 100");
//} else
//{
//    Console.WriteLine("Your number is lower than 100");
//}

//if(firstNumberInt <= 10)
//{
//    Console.WriteLine("The number is lower or equal than 10");
//}
//else if(firstNumberInt > 10 && firstNumberInt <= 20) {
//    Console.WriteLine("The number es higher than 10 and lower than 20");
//} else
//{
//    Console.WriteLine("The number es higher than 20");
//}

////var firstNumberInt = int.Parse(firstNumberString!);

//Console.WriteLine("Pls enter the second number: ");
//var secondNumberString = Console.ReadLine();

//if (string.IsNullOrEmpty(secondNumberString)) {
//    Console.WriteLine("The second number is invalid");
//    return;
//}

//var secondNumberInt = 0;

//if(!int.TryParse(secondNumberString, out secondNumberInt))
//{
//    Console.WriteLine("The entered value is not a number");
//    return;
//}


//Console.WriteLine("Select 1) sum,  2) substraction,  3) multiplication,  4) division");
//int operation = int.TryParse(Console.ReadLine(), out operation) ? operation : 0;

//var total = 0;
//switch (operation)
//{
//    case 1: total = firstNumberInt + secondNumberInt;
//        Console.WriteLine($"{firstNumberInt} + {secondNumberInt} = {total}");
//        break;
//    case 2: total = firstNumberInt - secondNumberInt;
//        Console.WriteLine($"{firstNumberInt} - {secondNumberInt} = {total}");
//        break;
//    case 3:
//        total = firstNumberInt * secondNumberInt;
//        Console.WriteLine($"{firstNumberInt} * {secondNumberInt} = {total}");
//        break;
//    case 4:
//        total = firstNumberInt / secondNumberInt;
//        Console.WriteLine($"{firstNumberInt} / {secondNumberInt} = {total}");
//        break;
//    default:
//        Console.WriteLine("Wrong value entered, must be from 1 to 4");
//        break;
//}