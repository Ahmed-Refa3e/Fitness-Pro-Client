using System.ComponentModel.DataAnnotations;

namespace Fitness_Pro_Client.Models
{
    public class OtpModel
    {
        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid email.")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "OTP is required.")]
        [StringLength(6, MinimumLength = 6, ErrorMessage = "OTP must be 6 digits.")]
        public string? Code { get; set; }
    }
}
