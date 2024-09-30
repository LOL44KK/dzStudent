namespace dzStudent
{
    public enum GroupSpecialization {
        NONE,
        IT,
        MATH,
        DRAWING
    }

    public class StudentEventArgs : EventArgs
    {
        public Student Student { get; }

        public StudentEventArgs(Student student)
        {
            Student = student;
        }
    }

    public class Group : ICloneable, IComparable
    {
        public delegate void GroupDelegate(Group group, StudentEventArgs args);

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

        public event GroupDelegate StudentAdded;
        public event GroupDelegate StudentExpelled;

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
            StudentAdded?.Invoke(this, new StudentEventArgs(student));
        }

        public void TransferStudent(Group where, int index)
        {
            if (index >= 0 && index < StudentCount)
            {
                Student student = where._students[index];
                where._students.RemoveAt(index);
                StudentExpelled?.Invoke(this, new StudentEventArgs(student));
                where.AddStudent(student);
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
                        Student student = _students[i];
                        _students.RemoveAt(i);
                        StudentExpelled?.Invoke(this, new StudentEventArgs(student));
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
            Student student = _students[index];
            _students.RemoveAt(index);
            StudentExpelled?.Invoke(this, new StudentEventArgs(student));
        }

        public void SortStudent(IComparer<Student> comparer)
        {
            _students.Sort(comparer);
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

        public Student[] GetArrayStudents()
        {
            return _students.ToArray();
        }

        public object Clone()
        {
            Group cloneGroup = new Group(_name, _specialization, _courseNumber);
            foreach (Student student in _students)
            {
                cloneGroup.AddStudent((Student)student.Clone());
            }
            return cloneGroup;
        }

        public int CompareTo(object? obj)
        {
            if (obj == null)
            {
                return 1;
            }
            return StudentCount.CompareTo(((Group)obj).StudentCount);
        }

        public IEnumerator<Student> GetEnumerator()
        {
            return _students.GetEnumerator();
        }

        public static bool operator==(Group group1, Group group2)
        {
            if (group1._students.Count != group2._students.Count)
            {
                return false;
            }

            for (int i = 0; i < group1._students.Count; i++)
            {
                if (group1._students[i] != group2._students[i])
                {
                    return false;
                }
            }

            return
                group1._name == group2._name &&
                group1._specialization == group2._specialization &&
                group1._courseNumber == group2._courseNumber;
        }

        public static bool operator !=(Group group1, Group group2)
        {
            return !(group1 == group2);
        }
    }
}
