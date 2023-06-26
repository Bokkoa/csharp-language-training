using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App05
{
    internal class StudentPrinterService
    {
        private readonly IPersonRepository<Student> _studentRepository;

        // EXPLICIT DEPENDENCIES PRINCIPLE
        public StudentPrinterService(IPersonRepository<Student> studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public void PrintStudents(int max = 100)
        {
            // Take is a IEnumerable feature
            //var students = _studentRepository.List().Take(max); //.ToArray(); // To array creates another collection, so, it takes more memory when boxing
            //Array.Sort(students);
            //Console.WriteLine("Printing students from the service layer");
            //for (int i = 0; i < students.Length; i++)
            //{
            //    Console.WriteLine(students[i]);
            //}

            var students = _studentRepository.OrderList().Take(max).ToArray();
            PrintStudentsConsole(students);

            var searchedStudents = _studentRepository.Search("Drez");
            PrintStudentsSearched(searchedStudents);
        }

        private void PrintStudentsConsole(IEnumerable<Student> students)
        {
            Console.WriteLine("@@@@@@@@@Students@@@@@@@@@");
            foreach(var student in students)
            {
                Console.WriteLine(student);
            }
        }

        private void PrintStudentsSearched(IEnumerable<Student> students)
        {
            Console.WriteLine("@@@@@@@@@Students Searched@@@@@@");
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }
    }
}
