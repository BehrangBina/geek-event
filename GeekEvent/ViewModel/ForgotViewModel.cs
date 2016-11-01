using System.ComponentModel.DataAnnotations;

namespace GeekEvent.ViewModel
{
    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}