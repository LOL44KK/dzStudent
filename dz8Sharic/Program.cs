 namespace dz8Sharic
{
    public class Program
    {
        static void Main(string[] args)
        {
            Group p26 = new Group("P26", GroupSpecialization.IT, 2);
            
            p26.AddStudent(new Student("Myhamed", "Lolo", new DateTime(), "asd", "asd", new List<int> { 5, 5, 5 }));
            p26.AddStudent(new Student("Elina", "Varenik", new DateTime(), "asd", "asd", new List<int> { 3, 3, 3 }));
            p26.AddStudent(new Student("Mykyta", "Kvischuk", new DateTime(), "asd", "asd", new List<int> { 5, 5, 5 }));
            p26.AddStudent(new Student("Stas", "Hil", new DateTime(), "asd", "asd", new List<int> { 5, 5, 5 }));
            p26.AddStudent(new Student("Dmitro", "Antonov", new DateTime(), "asd", "asd", new List<int> { 5, 5, 5 }));
            p26.AddStudent(new Student("Ivan", "Mohov", new DateTime(), "asd", "asd", new List<int> { 1, 1, 2 }));
        }
    }
}
