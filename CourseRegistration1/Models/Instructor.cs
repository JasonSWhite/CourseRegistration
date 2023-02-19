using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CourseRegistration1.Models
{
    public class Instructor
    {
        [DisplayName("Instructor ID")]
        [Key]
        public int I_id { get; set; }
        [DisplayName("First Name")]
        public string I_fName { get; set; }
        [DisplayName("Last Name")]
        public string I_lName { get; set; }
        [DisplayName("Email")]
        public string I_email { get; set; }
        [ForeignKey("Courses")]
        [DisplayName("Courses")]
        public string C_name { get; set; }
    }
}
