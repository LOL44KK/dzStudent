namespace dz8Sharic
{
    public class Student
    {
        private string _name;
        private string _surname;
        private DateTime _birthday;
        private string _homeAddress;
        private string _phoneNumber;
        private List<int> _grades;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Surname
        {
            get { return _surname; }
            set { _surname = value; }
        }
        public DateTime Birthday
        {
            get { return _birthday; }
            set { _birthday = value; }
        }
        public string HomeAddress
        {
            get { return _homeAddress; }
            set { _homeAddress = value; }
        }
        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set { _phoneNumber = value; }
        }
        public List<int> Grades
        {
            get { return _grades; }
            set { _grades = value; }
        }

        public Student(Student obj)
        {
            _name = obj._name;
            _surname = obj._surname;
            _birthday = obj._birthday;
            _homeAddress = obj._homeAddress;
            _phoneNumber = obj._phoneNumber;

            _grades = new List<int> {};
            for (int i = 0; i < 3; i++)
            {
                _grades.Add(obj._grades[i]);
            }
        }

        public Student()
        {
            _name = "";
            _surname = "";
            _birthday = new DateTime(1970, 12, 12);
            _homeAddress = "";
            _phoneNumber = "";
            _grades = new List<int>();
            for (int i = 0; i < 3; i++)
            {
                _grades.Add(0);
            }
        }

        public Student (string name, string surname, DateTime birthday, string home_address, string phone_number, List<int> grades)
        {
            _name = name;
            _surname = surname;
            _birthday = birthday;
            _homeAddress = home_address;
            _phoneNumber = phone_number;
            _grades = grades;
        }

        public Student(string name, string surname, DateTime birthday, string home_address, string phone_number)
        {
            _name = name;
            _surname = surname;
            _birthday = birthday;
            _homeAddress = home_address;
            _phoneNumber = phone_number;
            _grades = new List<int>();
            for (int i = 0; i < 3; i++)
            {
                _grades.Add(0);
            }
        }

        public void ShowInfo()
        {
            Console.WriteLine("Name: " + _name);
            Console.WriteLine("Surname: " + _surname);
            Console.WriteLine("Birthday: " + _birthday.Day + "." + _birthday.Month + "." + _birthday.Year);
            Console.WriteLine("Home address: " + _homeAddress);
            Console.WriteLine("Phone number: " + _phoneNumber);
            Console.WriteLine("Home work grade: " + _grades[0]);
            Console.WriteLine("Term papers grade: " + _grades[1]);
            Console.WriteLine("Exams grade: " + _grades[2]);
        }
    }
}
