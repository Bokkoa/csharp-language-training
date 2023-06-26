//// The user enter n times number to the addition
//// if the user adds a 0 number the sum stops
//// print the total

//int accomulator = 0;
//int number = 0;
//do
//{
//    Console.WriteLine("Enter the number to add");

//    try
//    {
//        number = int.Parse(Console.ReadLine()!);
//    }
//    catch (System.FormatException e)
//    {
//        Console.WriteLine($"The error has this detail: {e.Message}");

//        if (e.Message is null)
//        {
//            throw;
//        }

//        continue; // avoid the iteration (does not sum the number in this row)
//    }


//    accomulator += number; // number is equal to the last number entered before enter in catch block
//} while (number != 0);

//Console.WriteLine($"the total is: {accomulator}");