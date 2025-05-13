namespace CollegeManagementSystem.backend.Models
{
 public class Teacher
    {
        public int TeacherId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public ICollection<TeacherCourse> TeacherCourses { get; set; }
    }
}