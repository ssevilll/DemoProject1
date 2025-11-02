using DemoProject1.Main.Models;

namespace DemoProject1.Main
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("John", "Doe", 85.5);
            student1.Age = 20;
            Student student2 = new Student("Jane", "Smith", 92.0);
            student2.Age = 21;
            Student student3 = new Student("Alice", "Johnson", 78.0);
            student3.Age = 19;
            Student student4 = new Student("Bob", "Brown", 88.5);
            student4.Age = 22;

            Group group1 = new Group();
            group1.AddStudent(student1);
            group1.AddStudent(student2);
            group1.AddStudent(student3);
            group1.AddStudent(student4);


            var students = group1.GetAllStudents();
            Console.WriteLine("All Students:\n");
            foreach (Student student in students)
            {
                student.ShowInfo();
            }

            group1.Sort();
            Console.WriteLine("\nAfter Sorting:\n");
            students = group1.GetAllStudents();
            foreach (Student student in students)
            {
                student.ShowInfo();
            }

            Group group2 = new Group();
            group2.AddStudent(student2);

            Console.WriteLine($"\nGroup1 number: { group1.No}");
            Console.WriteLine($"Group2 number: {group2.No}");
        }
    }
}
