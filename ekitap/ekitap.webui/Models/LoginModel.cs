using System.ComponentModel.DataAnnotations;

namespace ekitap.webui.Models
{
    public class LoginModel
    {
        //email ve parola olacak,bunlara göre login işlemi yapılacak:

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }



        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public string ReturnUrl { get; set; }
        
    }
}