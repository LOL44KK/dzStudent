using System.Numerics;

namespace dz8Sharic
{
    public class Program
    {
        static void Main(string[] args)
        {
            Group p26 = new Group("P26", GroupSpecialization.IT, 2);
            Group p23 = new Group("P23", GroupSpecialization.IT, 2);

            Student student1 = new Student("Myhamed", "Lolo", new DateTime(), "asd", "asd", new List<int> { 5, 5, 5 });
            Student student2 = new Student("Elina", "Varenik", new DateTime(), "asd", "asd", new List<int> { 3, 3, 3 });
            Student student3 = new Student("Mykyta", "Kvischuk", new DateTime(), "asd", "asd", new List<int> { 5, 5, 5 });
            Student student4 = new Student("Stas", "Hil", new DateTime(), "asd", "asd", new List<int> { 5, 5, 5 });
            Student student5 = new Student("Dmitro", "Antonov", new DateTime(), "asd", "asd", new List<int> { 5, 5, 5 });
            Student student6 = new Student("Ivan", "Mohov", new DateTime(), "asd", "asd", new List<int> { 1, 1, 2 });
            Student clone6Student = new Student("Ivan", "Mohov", new DateTime(), "asd", "asd", new List<int> { 1, 1, 2 });

            p26.AddStudent(student1);
            p26.AddStudent(student2);
            p26.AddStudent(student3);
            p26.AddStudent(student4);
            p26.AddStudent(student5);
            p26.AddStudent(student6);

            p23.AddStudent(student3);
            p23.AddStudent(student4);
            p23.AddStudent(student5);
            p23.AddStudent(student6);

            Console.WriteLine("TEST1 Sort Students");
            Student[] sortStudent = p26.GetArrayStudents();
            Array.Sort(sortStudent);
            foreach (Student student in sortStudent)
            {
                student.ShowInfo();
                Console.WriteLine();
            }

            Console.WriteLine("TEST2 Clone group");
            Group p23Clone = (Group)p23.Clone();
            student3.Name = "Nikita";
            p23Clone.ShowAllStudent();
        }
    }
}
