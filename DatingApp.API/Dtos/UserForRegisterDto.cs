using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Dtos
{
    public class UserForRegisterDto
    { 
        [Required]
        public string username { get; set; }
        [Required]
        [StringLength(8, MinimumLength=4, ErrorMessage="Password length should be between 4 to 8")]
        public string password { get; set; }
    }
}