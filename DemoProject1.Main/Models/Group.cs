namespace DemoProject1.Main.Models
{
    internal class Group 
    {
        private static int _no=100;
        public string No { get; }
        private Student[] _students;

        public Group()
        {
            _no++;
            No=$"AP{_no}";
            _students = new Student[0];
        }


        public void AddStudent(Student student)
        {
            Array.Resize(ref _students, _students.Length + 1);
            _students[_students.Length-1] = student;
        }

        public Student[] GetAllStudents()
        {
            return _students;
        }

        public Student[] Sort()
        {
            Student[] NewArray= _students;
            for (int i=0; i<NewArray.Length; i++)
            {
                for (int j=0; j<NewArray.Length-1; j++)
                {
                    if (NewArray[i] < NewArray[j])
                    {
                        var temp = NewArray[i];
                        NewArray[i] = NewArray[j];
                        NewArray[j] = temp;
                    }
                }
            }
            return NewArray;
        }
    }
}
