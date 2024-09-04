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

            Group p26Clone = p26;

            if (student2)
            {
                Console.WriteLine("1. TRUE");
            }
            else 
            {
                Console.WriteLine("1. FALSE");
            }

            if (student6 == clone6Student)
            {
                Console.WriteLine("2. TRUE");
            }
            if (student6 != clone6Student)
            {
                Console.WriteLine("2. FALSE");
            }

            if (student1 > student6)
            {
                Console.WriteLine("3. TRUE");
            }
            if (student1 < student6)
            {
                Console.WriteLine("3. FALSE");
            }


            if (p26 == p26Clone)
            {
                Console.WriteLine("4. TRUE");
            }
            if (p26 != p23)
            {
                Console.WriteLine("5. TRUE");
            }
        }
    }
}
