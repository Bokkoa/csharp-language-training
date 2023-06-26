//// Create a dictionary

//Dictionary<string, string> myDictionary = new Dictionary<string, string>();

//// Add element to a dict

//myDictionary.Add(".doc", "Word documents");
//myDictionary.Add(".txt", "Note bloc files");
//myDictionary.Add(".html", "Web pages");
//myDictionary.Add(".jpg", "Images");


//Console.WriteLine("########TRYADD######");
//// trying to add a repeated key
//var ableToAdd = myDictionary.TryAdd(".doc", "Another word doc");

//if (!ableToAdd)
//{
//    Console.WriteLine("The element can't be inserted, key duplicated");
//}

//Console.WriteLine("########SEARCH######");


//// search in dictionary by key and by value
//Console.WriteLine($"Looking for a value with a key of bmp: {myDictionary.ContainsKey(".jpg")}");
//Console.WriteLine($"Looking for a value with a value of html: {myDictionary.ContainsValue("Web pages")}");

//// accesing to an element
//var txtValue = myDictionary[".txt"];
//Console.WriteLine($"The value from key .txt is {txtValue}");


//// Deleting an element from a dictionary
//myDictionary.Remove(".jpg");

//// Update dictionary value
//myDictionary[".txt"] = "New txt value (:";

//Console.WriteLine("########LISTING######");
//// print elements
//foreach (KeyValuePair<string, string> element in myDictionary)
//{
//    Console.WriteLine($"Printed key: {element.Key} value: {element.Value}");
//}