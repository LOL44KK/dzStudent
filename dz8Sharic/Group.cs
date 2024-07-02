namespace dz8Sharic
{
    public enum GroupSpecialization {
        NONE,
        IT,
        MATH,
        DRAWING
    }

    public class Group
    {
        private string _name;
        private GroupSpecialization _specialization;
        private int _courseNumber;
        private List<Student> _students;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public GroupSpecialization Specialization
        {
            get { return _specialization; }
            set { _specialization = value; }
        }

        public int CourseNumber
        {
            get { return _courseNumber; }
            set { _courseNumber = value; }
        }

        public int StudentCount
        {
            get { return _students.Count; }
        }

        public Group() 
        {
            _name = "";
            _specialization = GroupSpecialization.NONE;
            _courseNumber = 0;
            _students = new List<Student>();
        }

        public Group(string name, GroupSpecialization specialization, int courseNumber)
        {
            _name = name;
            _specialization = specialization;
            _courseNumber = courseNumber;
            _students = new List<Student>();
        }

        public Group(Group obj)
        {
            _name = obj.Name;
            _specialization = obj.Specialization;
            _courseNumber = obj.CourseNumber;
            _students = new List<Student>();

            for (int i = obj.StudentCount - 1; i >= 0; i--)
            {
                _students.Add(new Student(obj._students[i]));
            }
        }

        public void AddStudent(Student student)
        {
            _students.Add(student);
        }

        public void TransferStudent(Group where, int index)
        {
            if (index > 0 && index < StudentCount)
            {
                Student student = where._students[index];
                where._students.RemoveAt(index);
                _students.Add(student);
            }
        }

        public void ExpelAllWhoFailed()
        {
            for (int i = _students.Count - 1; i >= 0; i--)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (_students[i].Grades[j] < 3)
                    {
                        _students.RemoveAt(i);
                        break;
                    }
                }
            }
        }

        public void ExpelOneLowestPerformingStudent()
        {
            int index = 0;
            double avg = _students[0].Grades.Average();
            for (int i = 1; i < _students.Count; i++)
            {
                if (_students[i].Grades.Average() < avg)
                {
                    avg = _students[i].Grades.Average();
                    index = i;
                }
            }
            _students.RemoveAt(index);
        }

        public void ShowAllStudent()
        {
            Console.WriteLine("Group Name: " + _name);
            Console.WriteLine("Specialization: " + _specialization);
            Console.WriteLine("Course Number: " + _courseNumber);
            Console.WriteLine("Students:");

            List<Student> sortedStudents = _students.OrderBy(s => s.Surname).ToList();
            for (int i = 0; i < sortedStudents.Count; i++)
            {
                Console.WriteLine((i + 1) + ". " + sortedStudents[i].Name + " " + sortedStudents[i].Surname);
            }
        }
    }
}
