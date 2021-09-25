using System.ComponentModel.DataAnnotations;

namespace ekitap.webui.Models
{
    public class RegisterModel
    {

        [Required]
        [Display(Name="Ad")]
        public string FirstName { get; set; }


        [Required]
        [Display(Name="Soyad")]
        public string LastName { get; set; }


        [Required]
        [Display(Name="Kullanıcı Adı")]
        public string UserName { get; set; }


        [DataType(DataType.Password)]
        [Required]
        [Display(Name="Parola")]
        public string Password { get; set; }


        [Required]
        [DataType(DataType.Password)]
        [Compare("Password")]
        [Display(Name="ReParola")]
        public string RePassword { get; set; }


        [DataType(DataType.EmailAddress)]
        [Required]
        [Display(Name="Email")]
        public string Email { get; set; }


    }
}