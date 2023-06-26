
using App01;

Book donQuijote = new Book("Don quijote", "Miguel de Cervantes", 5000, 29.12m);
var bookResult = donQuijote.GetDescription();
Console.WriteLine(bookResult);


Magazine times = new Magazine("John Doe", "Times", 20, 10.23m);
var magazineResult = times.GetDescription();
Console.WriteLine(magazineResult);

