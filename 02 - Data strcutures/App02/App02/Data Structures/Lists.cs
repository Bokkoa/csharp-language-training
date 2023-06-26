
//// not recomended, just static cases and communications between systems
//string[] persons = { "Juan", "Felipe", "María", "Jose", "Jaime Uriel Parra Lerma" }; // this is static length
//                                                                                     // indexes     0        1        2        3


//// List has dynamic values
//// List Collection 
//List<string> stringList = new List<string>();

//// Add data from array string
//stringList.AddRange(persons);

//// add an element to the list
//stringList.Add("Luis");
//stringList.Add("Victoria");

//// Count list elements
//Console.WriteLine($"The list has the next item count: {stringList.Count()}");


//// Select one list element
//Console.WriteLine($"The first element {stringList[0]}");


//// Delete an element by index
//stringList.RemoveAt(3); // deleting jose
//// Delete an element by value
//stringList.Remove("María");

//// Ordering from a to z
//stringList.Sort();


//// Method to print all elements
//PrintList(stringList);
//void PrintList(List<string> listToPrint)
//{
//    Console.WriteLine("+++++++++LISTING+++++++++");
//    foreach (var element in listToPrint)
//    {
//        Console.WriteLine(element);
//    }
//}

//Console.WriteLine("!!!!!!!!!EXISTENCE!!!!!!!!!");
//// know if an element exists
//Console.WriteLine($"Exists Javier in the list? Response: {stringList.Contains("Javier")}");//false


//// Search those number with more than 10 chars
//var result = stringList.Exists(x => x.Length > 10);
//Console.WriteLine($"Exists a name with more tha 10 letters? {result}");


//Console.WriteLine("!!!!!!!!!FIND METHODS!!!!!!!!!");

//// Search by name that starts with V
//var elementFound = stringList.Find(x => x.StartsWith("V"));
//Console.WriteLine($"Exists a name with V as first letter? {elementFound}");

//// Search all that starts with J
//var elementsFound = stringList.FindAll(x => x.StartsWith("J"));
//Console.WriteLine($"Exists a name with J as first letter?");
//PrintList(elementsFound);