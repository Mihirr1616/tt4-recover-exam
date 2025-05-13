using Microsoft.AspNetCore.Identity;

namespace CollegeManagementSystem.backend.Models
{
    public class User : IdentityUser
    {
        public string FullName { get; set; }
    }
}
