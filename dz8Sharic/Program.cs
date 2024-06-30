 namespace dz8Sharic
{
    public class Program
    {
        static void Main(string[] args)
        {
            Group p23 = new Group("P23", GroupSpecialization.IT, 2);
            p23.AddStudent(new Student("Mykyta", "Kvischuk", new DateTime(), "asd", "asd", new List<int>{ 5, 5, 5}));
            p23.AddStudent(new Student("Stas", "Hil", new DateTime(), "asd", "asd", new List<int> { 5, 5, 5 }));
            p23.AddStudent(new Student("Dmitro", "Antonov", new DateTime(), "asd", "asd", new List<int> { 5, 5, 5 }));
            p23.AddStudent(new Student("Ivan", "Mohov", new DateTime(), "asd", "asd", new List<int> { 1, 1, 2 }));
            p23.ShowAllStudent();

            Group p26 = new Group("P26", GroupSpecialization.IT, 2);
            p26.AddStudent(new Student("Myhamed", "Lolo", new DateTime(), "asd", "asd", new List<int> { 5, 5, 5 }));
            p26.AddStudent(new Student("Elina", "Varenik", new DateTime(), "asd", "asd", new List<int> { 3, 3, 3 }));

            Group p262 = new Group(p26);
            p262.Name = "P26 OLD";

            for (int i = p23.StudentCount - 1; i >= 0; i--)
            {
                p26.TransferStudent(p23, i);
            }
            Console.WriteLine();
            p26.ShowAllStudent();

            Console.WriteLine();
            p262.ShowAllStudent();

            Console.WriteLine();
            p26.ExpelAllWhoFailed();
            p26.ShowAllStudent();

            Console.WriteLine();
            p26.ExpelOneLowestPerformingStudent();
            p26.ShowAllStudent();
        }
    }
}
