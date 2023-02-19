using CourseRegistration1.Models;

namespace CourseRegistration1.Repos
{
    public class MockStudentsRepo
    {
        private static List<Student> students = new List<Student>()
        {
            new Student
            {
                S_id = 665991,
                S_fName = "Samantha",
                S_lName = "Stacy",
                S_email = "samStacy2000@email.com",
                S_Phone = "128-951-7812",
                C_name = "Physics"
            },

            new Student 
            {
                S_id = 887720,
                S_fName = "Jim",
                S_lName = "Jacobs",
                S_email = "jj3241@email.com",
                S_Phone = "845-702-9941",
                C_name = "English Literature"
            },

            new Student
            {
                S_id = 996140,
                S_fName = "Sadie",
                S_lName = "Timmons",
                S_email = "timmons.sadie13@email.com",
                S_Phone = "667-990-5497",
                C_name = "Psychology"
            }
        };

        public IEnumerable<Student> GetAll()
        {
            return students;
        }

        public Student? GetById(int id) => students.FirstOrDefault(s => s.S_id == id);

        public void Create(Student newStudent)
        {
            int newStudentId = students.Max(s => s.S_id) + 1;
            newStudent.S_id = newStudentId;
            students.Add(newStudent);
        }

        public void Update(int id, Student student)
        {
            var res = GetById(id);

            if (res != null)
            {
                res.S_fName = student.S_fName;
                res.S_lName = student.S_lName;
                res.S_email = student.S_email;
                res.S_Phone = student.S_Phone;
                res.C_name = student.C_name;
            }
        }
    }
}
