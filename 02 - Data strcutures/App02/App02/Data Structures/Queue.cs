//// Create Queue Collection

//Queue<string> myQueue = new Queue<string>();

//// Add elements
//myQueue.Enqueue("1 - Mocha");
//myQueue.Enqueue("2 - Affogato");
//myQueue.Enqueue("3 - Machiatto");
//myQueue.Enqueue("4 - Chai");
//myQueue.Enqueue("5 - Carajillo");
//myQueue.Enqueue("6 - Irish");
//myQueue.Enqueue("7 - Latte");

//// using a foreach
//foreach (string item in myQueue)
//{
//    Console.WriteLine(item);
//}

//// search the first element

//var firstEl = myQueue.Peek();

//Console.WriteLine($"The first element: {firstEl}");

//// Delete an element from the queue
//string elementToDelete = myQueue.Dequeue();
//Console.WriteLine($"The element \"{elementToDelete}\"  was deleted");

//foreach (string item in myQueue)
//{
//    Console.WriteLine(item);
//}

//// Know if element exists
//var elExists = myQueue.Contains("4 - Chai");
//Console.WriteLine($"The element exists? : {elExists}");