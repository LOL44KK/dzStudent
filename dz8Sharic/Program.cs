 namespace dz8Sharic
{
    public class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();
            student1.Name = "mykyta";
            student1.ShowInfo();

            Console.WriteLine();
            Student student2 = new Student("asd", "asd", DateTime.Now, "asd", "asd");
            student2.Grades[0] = 12;
            student2.Grades[1] = 12;
            student2.Grades[2] = 12;
            student2.ShowInfo();

            Console.WriteLine();
            Student student3 = new Student("dsa", "dsa", DateTime.Now, "dsa", "dsa", new List<int> {3, 3, 3 });
            student3.ShowInfo();
        }
    }
}
