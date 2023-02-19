using CourseRegistration1.Models;

namespace CourseRegistration1.Repos
{
    public class MockInstructorsRepo
    {
        public static List<Instructor> instructors = new List<Instructor>()
        {
            new Instructor
            {
                I_id = 7540,
                I_fName = "George",
                I_lName = "Ferguson",
                I_email = "georgeRferguson@email.com",
                C_name = "Physics"
            },

            new Instructor
            {
                I_id = 9548,
                I_fName = "Shelly",
                I_lName = "Douval",
                I_email = "shelly.douval@email.com",
                C_name = "Psychology"
            },

            new Instructor
            {
                I_id = 8120,
                I_fName = "Krystal",
                I_lName = "Jenson",
                I_email = "kj1975@email.com",
                C_name = "English Literature"
            }
        };

        public IEnumerable<Instructor> GetAll()
        {
            return instructors;
        }

        public void Create(Instructor newInstructor)
        {
            instructors.Add(newInstructor);
        }

        public void Update(int id, Instructor instructor)
        {
            var res = instructors.FirstOrDefault(i => i.I_id == id);
        }
    }
}
