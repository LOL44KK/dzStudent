using System.Numerics;

namespace dzStudent
{
    public class Program
    {
        static void Main(string[] args)
        {
            Group p26 = new Group("P26", GroupSpecialization.IT, 2);
            Group p23 = new Group("P23", GroupSpecialization.IT, 2);

            p23.StudentAdded += TEST1;
            p26.StudentAdded += TEST1;
            p23.StudentExpelled += TEST2;
            p26.StudentExpelled += TEST2;

            Student student1 = new Student("Myhamed", "Lolo", new DateTime(), "asd", "asd", new List<int> { 5, 5, 5 });
            Student student2 = new Student("Elina", "Varenik", new DateTime(), "asd", "asd", new List<int> { 3, 3, 3 });
            Student student3 = new Student("Mykyta", "Kvischuk", new DateTime(), "asd", "asd", new List<int> { 5, 5, 5 });
            Student student4 = new Student("Stas", "Hil", new DateTime(), "asd", "asd", new List<int> { 5, 5, 5 });
            Student student5 = new Student("Dmitro", "Antonov", new DateTime(), "asd", "asd", new List<int> { 5, 5, 5 });
            Student student6 = new Student("Ivan", "Mohov", new DateTime(), "asd", "asd", new List<int> { 1, 1, 2 });

            p23.AddStudent(student3);
            p23.AddStudent(student4);
            p23.AddStudent(student5);
            p23.AddStudent(student6);

            p26.AddStudent(student1);
            p26.AddStudent(student2);
            
            Console.WriteLine();
            p26.TransferStudent(p23, 0);
            p26.TransferStudent(p23, 0);
            p26.TransferStudent(p23, 0);
            p26.TransferStudent(p23, 0);

            student6.UpdateGrades += TEST3;
            student6.PossibilityOfDismissal += TEST4;

            Console.WriteLine();
            student6.UpdateGrade(GradeType.HOMEWORK, 2);
            Console.WriteLine();
            student6.UpdateGrade(GradeType.HOMEWORK, 4);
        }

        static void TEST1(Group group, StudentEventArgs args)
        {
            Console.WriteLine("TEST1 StudentAdded group.Name: " + group.Name + " Student.Name: " + args.Student.Name);
        }

        static void TEST2(Group group, StudentEventArgs args)
        {
            Console.WriteLine("TEST2 StudentExpelled group.Name: " + group.Name + " Student.Name: " + args.Student.Name);
        }

        static void TEST3(Student student, EventArgs args)
        {
            Console.WriteLine("TEST3 UpdateGrades");
        }

        static void TEST4(Student student, EventArgs args)
        {
            Console.WriteLine("TEST4 PossibilityOfDismissal");
        }
    }
}
