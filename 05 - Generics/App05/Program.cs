
using App05;

var studentService = new StudentPrinterService( new StudentRepository() );
studentService.PrintStudents(5);

//var authorsService = new AuthorPrinterService(new AuthorRepository());
//authorsService.PrintAuthors();

//Console.WriteLine($"Total of students: {Student.StudentCount}");