//string[] songs =
//{
//    "Image",
//    "One",
//    "Billie Jean",
//    "Raining Blood",
//    "Painkiller",
//    "Cowboys from hell",
//    "The trooper",
//    "Jihad",
//    "Evisceration Plage"
//};


//// Creating the linkedlist
//LinkedList<string> songsLinkedList = new LinkedList<string>(songs);


//// Adding at the start and the end
//songsLinkedList.AddFirst("[First] Golden Brown");
//songsLinkedList.AddLast("[Last] Wild Animals");

//// Print elements
//foreach (string str in songsLinkedList)
//{
//    Console.WriteLine(str);
//}

//// searching the last one and first one from the list
//LinkedListNode<string> firstSong = songsLinkedList.First!;
//LinkedListNode<string> lastSong = songsLinkedList.Last!;

//Console.WriteLine($"First song: {firstSong.Value}");
//Console.WriteLine($"Last song: {lastSong.Value}");


//// The elements can be added or removed by a existent element
//songsLinkedList.AddAfter(firstSong, "[Second] Café de Mexico");

//Console.WriteLine("~~~~~~~ADD AFTER~~~~~~~~");
//// Print elements
//foreach (string str in songsLinkedList)
//{
//    Console.WriteLine(str);
//}


//// Seach items by contains method
//Console.WriteLine($"Looking for CFH: {songsLinkedList.Contains("Cowboys from hell")}");

//// Accesing by the data using next and previus
//Console.WriteLine($"Song that continues after the first song: {firstSong.Next!.Value} ");
//Console.WriteLine($"Song that is before from my last song: {lastSong.Previous!.Value} ");