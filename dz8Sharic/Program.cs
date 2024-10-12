using System.Text.Json;

namespace dzStudent
{
    public class Program
    {
        static void Main(string[] args)
        {
            Group p26 = new Group("P26", GroupSpecialization.IT, 2);
            Group p23 = new Group("P23", GroupSpecialization.IT, 2);

            Student student1 = new Student("Myhamed", "Lolo", new DateTime(), "Germany", "+321", new List<int> { 5, 5, 5 });
            Student student2 = new Student("Elina", "Varenik", new DateTime(), "Odesa", "+380", new List<int> { 3, 3, 3 });
            Student student3 = new Student("Mykyta", "Kvischuk", new DateTime(), "Chornomorsk", "+380", new List<int> { 5, 5, 5 });
            Student student4 = new Student("Stas", "Hil", new DateTime(), "Odesa", "+380", new List<int> { 5, 5, 5 });
            Student student5 = new Student("Dmitro", "Antonov", new DateTime(), "Odesa", "+380", new List<int> { 5, 5, 5 });
            Student student6 = new Student("Ivan", "Mohov", new DateTime(), "Odesa", "+380", new List<int> { 1, 1, 2 });

            p23.AddStudent(student3);
            p23.AddStudent(student4);
            p23.AddStudent(student5);
            p23.AddStudent(student6);

            p26.AddStudent(student1);
            p26.AddStudent(student2);
            p26.AddStudent(student3);
            p26.AddStudent(student4);
            p26.AddStudent(student5);
            p26.AddStudent(student6);


            SaveManager.SaveGroup(p26, "p26.json");
            SaveManager.LoadGroup("p26.json")?.ShowAllStudent();
        }
    }
}
