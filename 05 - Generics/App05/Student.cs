
namespace App05
{
    public class Student: Person, IComparable<Student>
    {

        public Student(): this("John", "Doe") // this() calls another constructor of the same class
        {
            
        }
        public Student(string? name, string? surName)
        {
            Name = name;
            Surname = surName;
        }

        public override string ToString()
        {
            return $"{Name} {Surname}";
        }

        public int CompareTo(Student? student)
        {
            // THE COMMENTED LINES WORKS WITH NO GENERIC ASPECT USE
            // CURRENTLY IS MORE EFFECTIVE
            //if (obj is null) return 1;
            //if(obj is Student student) // if it is the same type, generates and instance
            //{
            if (student.Name == Name) // if the student is the same current student
            {
                return this.Name!.CompareTo(student.Name);
            }

            return this.Surname!.CompareTo(student.Surname);
            //}
            //throw new ArgumentException("Its not a student instance", nameof(obj));
        }
    }


    public record FullName(string FirstName, string SurName);

}
