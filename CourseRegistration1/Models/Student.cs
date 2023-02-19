using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CourseRegistration1.Models
{
    public class Student
    {
        [DisplayName("Student ID")]
        [Key]
        public int S_id { get; set; }
        [DisplayName("First Name")]
        public string S_fName { get; set;}
        [DisplayName("Last Name")]
        public string S_lName { get; set;}
        [DisplayName("Email")]
        public string S_email { get; set;}
        [DisplayName("Phone Number")]
        public string S_Phone { get; set;}
        [DisplayName("Course Name")]
        [ForeignKey("Course")]
        public string C_name { get; set;}
    }
}
