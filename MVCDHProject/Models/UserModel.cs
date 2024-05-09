using System.ComponentModel.DataAnnotations;

namespace MVCDHProject.Models
{
    public class UserModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        [Compare("Password", ErrorMessage = "Confirm password should match with password.")]
        public string ConfirmPassword { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email Id")]
        public string Email { get; set; }

        [Required]
        [RegularExpression("[6-9]\\d{9}", ErrorMessage = "Mobile No. Is Invalid")]
        public string Mobile { get; set; }

    }
}
