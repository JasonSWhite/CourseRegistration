using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CourseRegistration1.Models
{
    public class Course
    {
        [DisplayName("Course ID")]
        [Key]
        public int C_id { get; set; }
        [DisplayName("Course Number")]
        public int C_num { get; set; }
        [DisplayName("Course Name")]
        public string C_name { get; set;}
        [DisplayName("Course Description")]
        public string C_descr { get; set;}

    }
}
