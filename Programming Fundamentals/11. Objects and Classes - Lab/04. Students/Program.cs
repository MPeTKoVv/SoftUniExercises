namespace _04._Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            while (true)
            {
                string studentInfo = Console.ReadLine();

                if (studentInfo == "end")
                {
                    break;
                }

                string[] tokens = studentInfo.Split().ToArray();

                string firsName = tokens[0];
                string lastName = tokens[1];
                int age = int.Parse(tokens[2]);
                string city = tokens[3];

                Student student = new Student
                {
                    FirstName = firsName,
                    LastName = lastName,
                    Age = age,
                    City = city
                };

                students.Add(student);
            }

            string filterCity = Console.ReadLine();

            var filteredStudents = students
                .Where(s => s.City == filterCity)
                .ToList();

            foreach (var item in filteredStudents)
            {
                Console.WriteLine($"{item.FirstName} {item.LastName} is {item.Age} years old.");
            }
        }
    }

    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
    }
}