namespace DemoProject1.Main.Models
{

    internal class Student
    {
        private static int _id=0;
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public double Points { get; set; }


        public int Id { get; }

        public Student(string name, string surname, double point)
        {

            Name = name;
            Surname = surname;
            Points = point;
            _id++;
            Id = _id;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"ID: {Id}, Name: {Name}, Surname: {Surname}, Age: {Age}, Points: {Points}");
        }

        public static bool operator > (Student s1, Student s2)
        {
            return s1.Points > s2.Points ? true : false;
        }

        public static bool operator < (Student s1, Student s2)
        {
            return s1.Points < s2.Points ? true : false;
        }
    }
}

