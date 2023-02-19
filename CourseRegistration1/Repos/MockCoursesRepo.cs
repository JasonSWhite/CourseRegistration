using CourseRegistration1.Models;
using Microsoft.DotNet.Scaffolding.Shared.CodeModifier.CodeChange;
using Newtonsoft.Json.Bson;
using System;

namespace CourseRegistration1.Repos
{
    public class MockCoursesRepo
    {
        private static List<Course> courses = new List<Course>
        {
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
        };

        public IEnumerable<Course> GetAll()
        {
            return courses;
        }

        public Course? GetById(int id) => courses.FirstOrDefault(c => c.C_id == id);

        public void Create(Course newCourse)
        {
            courses.Add(newCourse);
        }

        public void Update(int id, Course course)
        {
            var res = courses.FirstOrDefault(c => c.C_id == id);
        }

    }
}
