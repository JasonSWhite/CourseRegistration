using CourseRegistration1.Models;
using Microsoft.EntityFrameworkCore;

namespace CourseRegistration1.Repos
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Student> Students { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Course>().HasData
                (
                new Course
                {
                    C_id = 2548,
                    C_num = 001,
                    C_name = "Physics",
                    C_descr = "This course covers fundamental physical principles including descriptions " +
                                "of mechanical, electrical, wave, and atomic phenomena. The course highlights ways in which " +
                                "physical principles are used to describe and understand the vast array of observable phenomena" +
                                " in the universe"
                },
                new Course
                {
                    C_id = 3654,
                    C_num = 002,
                    C_name = "Psychology",
                    C_descr = "An introduction to the study of adjustment, disorders, development, personality and the social environment" +
                                "of the person. An introduction to the study of brain and behaviour, perception, learning, memory, cognition," +
                                 "motivation and emotion. An examination of research methods in psychology."
                },
                new Course
                {
                    C_id = 9548,
                    C_num = 003,
                    C_name = "English Literature",
                    C_descr = "This course introduces students of literature and writing to the discipline of English." +
                               "The course includes an overview of British and American literary history from Old English" +
                                "to hypertext; a study of the elements of literature and practice in close textual analysis" +
                                "with some introduction to critical theory; and seminar-style discussions of current topics" +
                                "in lit­erature (canon studies, multiculturalism, popular culture, etc.)"
                }
                );

            modelBuilder.Entity<Instructor>().HasData
                (
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
                );

            modelBuilder.Entity<Student>().HasData
                (
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
                );
        }
    }
}
