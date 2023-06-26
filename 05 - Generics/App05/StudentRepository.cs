using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App05
{
    public class StudentRepository : IPersonRepository<Student>
    {
        private FullName[] _names = new FullName[10];

        public StudentRepository()
        {
            // its a record not a class
            _names[0] = new ("Vaxi", "Drez");
            _names[1] = new ("Conejo", "Blaz");
            _names[2] = new ("Mario", "Brod");
            _names[3] = new ("Ba", "Nei");
            _names[4] = new ("Pancho", "Villa");
            _names[5] = new ("Chibi", "Naranjosidad");
            _names[6] = new ("El", "Uriel");
            _names[7] = new ("Mauricio", "Guerrero");
            _names[8] = new ("Angela", "Arias");
            _names[9] = new ("Nicole", "Lopez");
        }

        public Student Create(FullName name)
        {
            return new Student(name.FirstName, name.SurName);
        }

        public Student DefaultCreate()
        {
            return new Student();
        }

        public IEnumerable<Student> List()
        {
            int index = 0;

            while(index < _names.Length)
            {
                // yield add the element to the IEnumerable collection
                yield return new Student(_names[index].FirstName, _names[index].SurName);
                index++;
            }
        }

        public IEnumerable<Student> OrderList()
        {
            var students = List().ToList();
            students.Sort();
            return students;
        }

        public IEnumerable<Student> Search(string name)
        {
            return List().Where(x => x.Name!.Contains(name) 
            || x.Surname!.Contains(name));
        }
    }

}
 