using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EventEgg.Admin.Models
{
    public class PersonalLoginPageModel
    {
        [Required]
        [DataType(DataType.Text)]
        [DisplayName("Username")]
        public string Username { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [DisplayName("Password")]
        public string Password { get; set; }
    }
}